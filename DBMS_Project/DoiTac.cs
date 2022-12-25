using Project.BUS;
using Project.DAO;
using Project.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class DoiTac : Form
    {
        public DoiTac()
        {
            InitializeComponent();
            _doiTac = new DoiTacDTO();
            

        }
        public DoiTac(DataTable dataTable)
        {
            InitializeComponent();
            _doiTac = new DoiTacDTO();
            _doiTac.MaDoiTac =(String) dataTable.Rows[0]["maDoiTac"];
            _doiTac.Email = (String)dataTable.Rows[0]["email"];
            _doiTac.TenCuaHang = (String)dataTable.Rows[0]["tenCuaHang"];
            _doiTac.NguoiDaiDien = (String)dataTable.Rows[0]["nguoiDaiDien"];
            _doiTac.SoLuongDonDuKien = Convert.ToInt32(dataTable.Rows[0]["sLDonDuKien"]);
            //_doiTac.TGMoCua = (String)(DateTime.ParseExact(dataTable.Rows[0]["tGMoCua"], "HH:mm:ss", CultureInfo.InvariantCulture));
            //_doiTac.TGDongCua = (String)(DateTime.ParseExact(dataTable.Rows[0]["tGDongCua"]), "HH:mm");
            if (dataTable.Rows[0]["tinhTrang"] != DBNull.Value)
                _doiTac.TinhTrang = (String)dataTable.Rows[0]["tinhTrang"];
            _doiTac.SoLuongChiNhanh = Convert.ToInt32(dataTable.Rows[0]["sLChiNhanh"]);
            //_doiTac.NgayCapNhap = (String)(dataTable.Rows[0]["ngayCapNhat"]);
           _doiTac.tenDangNhap = (String)dataTable.Rows[0]["tenDangNhap"];
           txtEmail.Text = _doiTac.Email;
           txtChiNhanh.Text =  _doiTac.SoLuongChiNhanh.ToString();
           txtNgayCapNhat.Text = DateTime.Now.ToString();
            txtMaDoiTac.Text = _doiTac.MaDoiTac.ToString();
            if (_doiTac.TinhTrang == string.Empty)
                txtTinhTrang.Text = "Đang hoạt động";
            else
                txtTinhTrang.Text = _doiTac.TinhTrang;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DoiTac_Load(object sender, EventArgs e)
        {

        }
        private DoiTacDTO _doiTac;

        private void comboBox1_Click(object sender, EventArgs e)
        {
            DataTable dataTable= new DataTable();
            dataTable = DOITACBUS.LayThucDon(_doiTac.MaDoiTac);
            int numItems = dataTable.Rows.Count;   
            List<string> list = new List<string>();
            
            for(int i = 0; i < numItems; i++)
            {
                list.Add((String)dataTable.Rows[i]["maThucDon"]);
            }
            string result = list[0];
            //MessageBox.Show(result);
            cbbThucDon.Items.Clear();
            cbbThucDon.Items.AddRange(list.ToArray());
        }

        private void btnXemThucDon_Click(object sender, EventArgs e)
        {
            string maThucDon = (String)cbbThucDon.SelectedItem;
            DataTable danhSachMon = new DataTable();
            danhSachMon = KhachHangBUS.LayMonAn(maThucDon, 2);
            int numItems = danhSachMon.Rows.Count;
            List<MonAnDTO> ds = new List<MonAnDTO>();
            for (int i = 0; i < danhSachMon.Rows.Count; i++)
            {
                MonAnDTO m = new MonAnDTO();
                m.MaMonAn = (String)danhSachMon.Rows[i]["maMonAn"];
                m.TenMonAn = (String)danhSachMon.Rows[i]["tenMonAn"];
                if (danhSachMon.Rows[i]["tinhTrang"] != DBNull.Value)
                    m.TinhTrang = (String)danhSachMon.Rows[i]["tinhTrang"];
                m.Gia = (decimal)danhSachMon.Rows[i]["Gia"];
                m.LuotLike = (int)danhSachMon.Rows[i]["luotLike"];
                ds.Add(m);
            }
            ThucDonDTO td = new ThucDonDTO(_doiTac.MaDoiTac, maThucDon, "", ds);
            this.Hide();
            DoiTac_ThucDoncs formThucDon = new DoiTac_ThucDoncs(this, td);
            formThucDon.Show();

        }

        private void btnQuanLyDonHang_Click(object sender, EventArgs e)
        {
            string TinhTrang = (String)cbbDonHang.SelectedItem;
            string maTinhTrang = string.Empty;
            if(TinhTrang == "Chờ nhận")
            {
                maTinhTrang = "Waiting";
            }
            string maDoiTac = _doiTac.MaDoiTac;
            DataTable table = new DataTable();
            table = DOITACBUS.layChiTietDonHang(maDoiTac, maTinhTrang);
            //MessageBox.Show(table.Rows.Count.ToString());
            if (table.Rows.Count > 0)
            {
                string maDonHang = (String)table.Rows[0]["maDonHang"];
                int numItems = table.Rows.Count;
                List<MonAnDTO> dsMonAn = new List<MonAnDTO>();
                List<int> dsSL = new List<int>();
                int IDCuaHang = DONHANGBUS.getIDCuaHang(_doiTac.MaDoiTac);
                for (int i = 0; i < numItems; i++)
                {
                    MonAnDTO monAn = new MonAnDTO();
                    monAn.MaMonAn = (String)table.Rows[i]["tenMonAn"];
                    dsSL.Add(Convert.ToInt32(table.Rows[i]["soLuong"]));
                    dsMonAn.Add(monAn);
                }
                DONHANGDTO donHang = new DONHANGDTO(maDonHang, dsMonAn, dsSL, IDCuaHang);
                TiepNhanDonHang form = new TiepNhanDonHang(this, donHang);
                this.Hide();
                form.Show();
            }
            else
                MessageBox.Show("Hiện tại không có đơn hàng nào!");
        }

        private void cbbThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
