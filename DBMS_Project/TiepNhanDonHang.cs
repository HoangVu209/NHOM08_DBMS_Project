using Project.BUS;
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
using System.Xml.XPath;

namespace DBMS_Project
{
    public partial class TiepNhanDonHang : Form
    {
        public TiepNhanDonHang()
        {
            InitializeComponent();
            _doiTacForm = new DoiTac();
            _donHang = new DONHANGDTO();
        }
        public TiepNhanDonHang(DoiTac doiTac, DONHANGDTO donHang)
        {
            InitializeComponent();
            _doiTacForm = doiTac;
            _donHang = new DONHANGDTO();
            _donHang = donHang;
            txtMaDonHang.Text = _donHang.MaDonHang.ToString();
            List<MonAnDTO> dsMonAn = new List<MonAnDTO>();
            List<int> dsSL = new List<int>();
            dsMonAn = _donHang.DanhSachMonAn;
            dsSL = _donHang.danhsachSL;
            DataTable table = new DataTable();
            table.Columns.Add("tenMonAn", typeof(string));
            table.Columns.Add("soLuong", typeof(int));
            int numItems = dsMonAn.Count;
            for(int i = 0; i < numItems; i++) 
            {
                table.Rows.Add(table.NewRow());
                
                table.Rows[i]["tenMonAn"] = (String)dsMonAn[i].MaMonAn;
                table.Rows[i]["soLuong"] = dsSL[i];
            }
            dtgDonHang.DataSource= table;

        }
        private DoiTac _doiTacForm;
        private DONHANGDTO _donHang;

        private void btnChotDon_Click(object sender, EventArgs e)
        {
            int selection = 0;
            if(rdoKhongLoi.Checked) selection = 1;
            int result = DOITACBUS.TiepNhanDonHang(_donHang.MaDonHang, selection);
            //MessageBox.Show(result.ToString());
            if (result == 1)
                MessageBox.Show("Chấp nhận thành công!");
            else if (result == 2)
                MessageBox.Show("Đơn hàng đã hủy!");
            else
                MessageBox.Show("Thêm thất bại, xem lại thông tin!");
            btnChotDon.Enabled = false;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            _doiTacForm.Show();
            this.Close();
        }

        private void TiepNhanDonHang_Load(object sender, EventArgs e)
        {

        }
    }
}
