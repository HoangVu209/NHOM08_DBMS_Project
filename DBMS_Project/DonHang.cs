using Project.BUS;
using Project.DAO;
using Project.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class DonHang : Form
    {
        public DonHang(XemThucDon form, DONHANGDTO DonHang)
        {
            InitializeComponent();
            _form = form;
            _donHang = DonHang;
            DataTable dataTable= new DataTable();
            dataTable.Columns.Add("maMonAn", typeof(string));
            dataTable.Columns.Add("tenMonAn", typeof(string));
            dataTable.Columns.Add("Gia", typeof(double));  
            dataTable.Columns.Add("soLuong", typeof(int));
            int itemsNum = DonHang.DanhSachMonAn.Count;
            List<MonAnDTO> list = new List<MonAnDTO>();
            double tongTien = 0;
            list = _donHang.DanhSachMonAn;
            for(int i = 0; i < itemsNum; i++)
            {

                DataRow dr = dataTable.NewRow();
                dataTable.Rows.Add(dr);
                dataTable.Rows[i]["maMonAn"]  = (String) list.ElementAt(i).MaMonAn;
                dataTable.Rows[i]["tenMonAn"] = (String)list.ElementAt(i).TenMonAn;
                dataTable.Rows[i]["Gia"] = (double)list.ElementAt(i).Gia;
                dataTable.Rows[i]["soLuong"] = (int)1;
                tongTien += (double)list.ElementAt(i).Gia;
            }    
            txtTongTien.Text = tongTien.ToString(); 
            dgvDonHang.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private XemThucDon _form;
        private DONHANGDTO _donHang;

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            double tongTien = Convert.ToDouble(txtTongTien.Text);
            //MessageBox.Show(index.ToString());
            int soLuong = Convert.ToInt32(dgvDonHang.Rows[index].Cells["soLuong"].Value);
            soLuong += 1;
            double Gia = Convert.ToDouble(dgvDonHang.Rows[index].Cells["Gia"].Value);
            tongTien += Gia;
            Gia = Gia * 2;
            dgvDonHang.Rows[index].Cells["soLuong"].Value = soLuong;
            dgvDonHang.Rows[index].Cells["Gia"].Value = Gia;
            txtTongTien.Text = tongTien.ToString();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {

            this.Hide();
            dgvDonHang.DataSource = null;
            dgvDonHang.Rows.Clear();
            foreach (DataGridViewRow item in this.dgvDonHang.SelectedRows)
            {
                dgvDonHang.Rows.RemoveAt(item.Index);
            }
            _form.Show(); 
            this.Close();
            
        }

        private void DonHang_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //Tổng số tiền đơn hàng 
            decimal tongTien = 0; //
            //Mã đơn hàng
            string maDonHang = _donHang.MaDonHang.ToString();
            //Lấy dữ liệu từ grid về danh sách món ăn và số lượng
            List<MonAnDTO> danhSachMonAn = new List<MonAnDTO>();
            List<int> danhSachSoLuong = new List<int>();
            string maThucDon = _form.layMaThucDon();
            int total = dgvDonHang.Rows.Count;
            for(int i = 0; i < total - 1; i++)
            {
                MonAnDTO monAn = new MonAnDTO();
                monAn.MaMonAn = (String)dgvDonHang.Rows[i].Cells["maMonAn"].Value;
                monAn.TenMonAn = (String)dgvDonHang.Rows[i].Cells["tenMonAn"].Value;               
                monAn.Gia = MONANBUS.layGiaMonAn(maThucDon, (String)dgvDonHang.Rows[i].Cells["maMonAn"].Value);                
                danhSachSoLuong.Add((Convert.ToInt32(dgvDonHang.Rows[i].Cells["soLuong"].Value)));
                tongTien = tongTien + monAn.Gia * danhSachSoLuong[i];                
                danhSachMonAn.Add(monAn);                    
            }
           
            string tenTinhTrang = "Waiting";
            int STT = _form.LaySTT();
            string maDoiTac = _form.LayMaDoiTac();
            string maKhachHang = _form.layMaKhachHang();
            int IDCuaHang = DONHANGBUS.getIDCuaHang(_form.LayMaDoiTac());
            DONHANGDTO donHang = new DONHANGDTO(maDonHang, danhSachMonAn, danhSachSoLuong,
                           tenTinhTrang, maDoiTac, STT, tongTien, maKhachHang, IDCuaHang);
            //Lưu xuống database
            int result = DONHANGBUS.LuuDonHang(maKhachHang, maDonHang, tenTinhTrang, maDoiTac, STT, IDCuaHang);
            int numItems = danhSachMonAn.Count;
            //MessageBox.Show(numItems.ToString());
            for(int i = 0; i < numItems; i++)
            {
                KhachHangDAO.ThemChiTietDonHang(maDonHang, danhSachMonAn[i].MaMonAn, danhSachSoLuong[i]);
            }    
            KhachHangDTO kh = new KhachHangDTO();
            this.Hide();
            _form.showKH();
            _form.donHangDTO(donHang);
            this.Close();
            //_formKH.Show();
            
        }
    }
}
