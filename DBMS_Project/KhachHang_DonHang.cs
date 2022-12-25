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
    public partial class KhachHang_DonHang : Form
    {
        public KhachHang_DonHang(CustomerForm form, DONHANGDTO dh)
        {
            InitializeComponent();
            //MessageBox.Show(dh.MaDonHang.ToString());
            _dh = new DONHANGDTO();
            _dh = dh;
            
            _kh = form;
            //_kh = new CustomerForm(kh, dh);
            //Show lên datagird view
            DataTable table = new DataTable();
            table.Columns.Add("tenMonAn", typeof(string));
            table.Columns.Add("Gia", typeof(decimal));
            table.Columns.Add("soLuong", typeof(int));

            List<MonAnDTO> danhSachMonAn = new List<MonAnDTO>();
            danhSachMonAn = dh.DanhSachMonAn;
            List<int> danhSachSoLuong = new List<int>();
            danhSachSoLuong = dh.danhsachSL;
            int numItems = dh.DanhSachMonAn.Count;
            for (int i = 0; i < numItems; i++)
            {
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                table.Rows[i]["tenMonAn"] = danhSachMonAn[i].TenMonAn;
                table.Rows[i]["Gia"] = danhSachMonAn[i].Gia;
                table.Rows[i]["soLuong"] = danhSachSoLuong[i];
            }
            //MessageBox.Show(DONHANGBUS.layTinhTrang(dh.MaDonHang).ToString());
            txtMaDonHang.Text = dh.MaDonHang.ToString();
            txtTinhTrang.Text = DONHANGBUS.layTinhTrang(dh.MaDonHang).ToString();
            /*
            if(dh.MaTinhTrang == "ST4")
            {
                txtTinhTrang.Text = "Đang chờ nhận";
            }
            */
            if(txtTinhTrang.Text != "Chờ nhận")
            {
                btnHuyDonHang.Enabled = false;
            }    
            txtTongTien.Text = dh.TongTien.ToString();
            dtgDonHang.DataSource = table;

        }
        private KhachHang_DonHang(DONHANGDTO dh, CustomerForm khform)
        {
            _dh = new DONHANGDTO();
            _dh = dh;
            _kh =  khform;
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DONHANGDTO _dh;
        private CustomerForm _kh;

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            _kh.Show();
            this.Close();
        }

        private void btnHuyDonHang_Click(object sender, EventArgs e)
        {
           
            int result = DONHANGDAO.HuyDonHang(_dh.MaDonHang);
            //MessageBox.Show(result.ToString());

            if (result == 0)
            {
                MessageBox.Show("Hủy thất bại!");
            }
            else if(result == 2)
            {
                MessageBox.Show("Đơn hàng đã được tiếp nhận");
            }    
            else
            {
                MessageBox.Show("Hủy thành công");
            }
        }

        private void KhachHang_DonHang_Load(object sender, EventArgs e)
        {

        }
    }
}
