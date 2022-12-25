using Project.BUS;
using Project.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class CustomerForm : Form
    {
        public CustomerForm(DataTable table)
        {
            InitializeComponent();
            txtID.Text = (String)table.Rows[0]["maKhachHang"];
            txtEmail.Text = (String)table.Rows[0]["Email"];
            txtPhone.Text = (String)table.Rows[0]["dienThoai"];
            txtName.Text = (String)table.Rows[0]["hoTen"];
            _kh = new KhachHangDTO();
            _dh = new DONHANGDTO();
            _kh.MaKhachHang = (String)table.Rows[0]["maKhachHang"];
            _kh.Email = (String)table.Rows[0]["Email"];
            _kh.HoTen = (String)table.Rows[0]["hoTen"];
            _kh.DienThoai = (String)table.Rows[0]["dienThoai"];
            // _kh.TenDangNhap = (String)table.Rows[0]["tenDangNhap"];
            _kh.IDTaiKhoan = Convert.ToInt32(table.Rows[0]["IDTaiKhoan"]);

        }
        public CustomerForm(KhachHangDTO kh, DONHANGDTO dh)
        {
            InitializeComponent();
            txtID.Text = kh.MaKhachHang;
            txtEmail.Text = kh.Email;
            txtPhone.Text = kh.DienThoai;
            txtName.Text = kh.HoTen;
            _kh = new KhachHangDTO();
            _kh = kh;
            _dh = new DONHANGDTO();
            _dh = dh;
        }
        public CustomerForm(DONHANGDTO dh)
        {
            if(_kh == null)
                _kh = new KhachHangDTO();
            _dh = new DONHANGDTO();
            _dh = dh;
        }
        //Xử lý combobox đối tác
        private void cboDoiTac_SelectedIndexChange(object sender, EventArgs e)
        {
            DataTable table= new DataTable();
            table = DOITACBUS.GetInfor();
            List<string> list = new List<string>();
            foreach (DataRow row in table.Rows)
            {
                list.Add((string)row["maDoiTac"]);
            }
            cbbDoiTac.Items.Clear();
            cbbDoiTac.Items.AddRange(list.ToArray());
            
        }
        //Xử lý combobox Chi nhánh
        private void cboChiNhanh_SelectedIndexChange(Object sender, EventArgs e)
        {
            DataTable tableCN = new DataTable();
            string maDoiTac = (String) cbbDoiTac.SelectedItem;
            List<string> list = new List<string>();
            tableCN = DOITACBUS.LayThucDon(maDoiTac);
            foreach (DataRow row in tableCN.Rows)
            {
                list.Add((string)row["maThucDon"]);
            }
            
            cbbDiaChiChiNhanh.Items.Clear();
            cbbDiaChiChiNhanh.Items.AddRange(list.ToArray());
        }
        private void btnXemThucDon_Click(object sender, EventArgs e)
        {
            string maDoiTac = (String)cbbDoiTac.SelectedItem;
            string maThucDon = (String)cbbDiaChiChiNhanh.SelectedItem;
            int selection = 0;

            //3 là bị unrepeatable
            //4 là không bị unrepeatable
            if (rdoKhongLoi.Checked)
            {
                selection = 1;
            }
            else if (rdoLoi.Checked)
                selection = 0;
            else if (rdoLoiUn.Checked)
                selection = 3;
            else if (rdoSuaLoiUn.Checked)
                selection = 4;
            else
                selection = 2;
         
            DataTable danhSachMon = new DataTable();
            danhSachMon = KhachHangBUS.LayMonAn(maThucDon, selection);
            int numItems = danhSachMon.Rows.Count;
            //list mon an
            List<MonAnDTO> ds = new List<MonAnDTO>();
            //chuyển qua list thức ăn
            for (int i = 0; i < numItems; i++)
            {
                
                MonAnDTO m = new MonAnDTO();
                m.MaMonAn =(String) danhSachMon.Rows[i]["maMonAn"];
                m.TenMonAn = (String)danhSachMon.Rows[i]["tenMonAn"];
                if(danhSachMon.Rows[i]["tinhTrang"] != DBNull.Value )
                    m.TinhTrang = (String)danhSachMon.Rows[i]["tinhTrang"];
                m.Gia = (decimal)danhSachMon.Rows[i]["Gia"];
                m.LuotLike = (int)danhSachMon.Rows[i]["luotLike"];
                ds.Add(m);
            }
            ThucDonDTO td = new ThucDonDTO(maDoiTac, maThucDon, "", ds);

            //MessageBox.Show(numItems.ToString());
            this.Hide();
            Form XemThucDon = new XemThucDon(td, danhSachMon, this);
            XemThucDon.Show();
            
        }
        public string getMaKH()
        {
            return _kh.MaKhachHang;
        }
        
        private KhachHangDTO _kh;
        private DONHANGDTO _dh;
        private void rdoBinhThuong_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void donHangDTO(DONHANGDTO dh)
        {
            //MessageBox.Show(dh.DanhSachMonAn.Count.ToString());
            string _maDonHang = dh.MaDonHang;
             List<MonAnDTO> _danhSachMonAn = dh.DanhSachMonAn;
             List<int> _danhSachSL = dh.danhsachSL;
             string _maTinhTrang = dh.MaTinhTrang;
             string _maDoiTac = dh.MaDoiTac;
             int _STT = dh.STT;
             decimal _tongTien = dh.TongTien;
            string _maKhachHang = dh.maKhachHang;
            int IDCuaHang = dh.IDCuaHang;

            _dh = new DONHANGDTO(_maDonHang, _danhSachMonAn, _danhSachSL, _maTinhTrang, _maDoiTac, _STT, _tongTien, _maKhachHang, IDCuaHang);

        }

        private void btnXemDonHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            KhachHang_DonHang form = new KhachHang_DonHang(this, _dh);
            form.Show();
        }

        private void cbbDoiTac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
