using Microsoft.VisualBasic;
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

namespace DBMS_Project
{
    public partial class DoiTac_ThucDoncs : Form
    {
        public DoiTac_ThucDoncs()
        {
            InitializeComponent();
            _doiTacForm = new DoiTac();
            _thucDon = new ThucDonDTO();
           
        }
        public DoiTac_ThucDoncs(DoiTac doiTacForm, ThucDonDTO thucDon)
        {
            InitializeComponent();
            _doiTacForm = doiTacForm;
            _thucDon = new ThucDonDTO();
            _thucDon = thucDon;
            txtMaThucDon.Text = _thucDon.MaThucDon;
            List<MonAnDTO> list = new List<MonAnDTO>();
            list = _thucDon.DanhSachMonAn;
            int numItems = list.Count;
     
            for(int i =0; i < numItems; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                dtgDSMonAn.Rows.Add(row);
                dtgDSMonAn.Rows[i].Cells["tenMonAn"].Value = list[i].TenMonAn.ToString();
                dtgDSMonAn.Rows[i].Cells["tinhTrang"].Value = list[i].TinhTrang.ToString();
                dtgDSMonAn.Rows[i].Cells["Gia"].Value = list[i].Gia;
                dtgDSMonAn.Rows[i].Cells["luotLike"].Value = list[i].LuotLike;
            }
            dtgDSMonAn.ReadOnly= true;
          
        }
        private DoiTac _doiTacForm;
        private ThucDonDTO _thucDon;

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            _doiTacForm.Show();
            this.Close();
        }
        private void setGridViewEditable(bool b)
        {
            dtgDSMonAn.AllowUserToAddRows = b;
            dtgDSMonAn.ReadOnly = !b;
            dtgDSMonAn.AllowUserToDeleteRows = b;
        }
        private void ckbCapNhat_CheckedChanged(object sender, EventArgs e)
        {
            setGridViewEditable(ckbCapNhat.Checked);
        }
        
        private void btnHuy_Click(object sender, EventArgs e)
        {
            /*
            List<MonAnDTO> list = new List<MonAnDTO>();
            list = _thucDon.DanhSachMonAn;
            f

            DataTable dt = new DataTable();
            dt = _thucDon.DanhSachMonAn(
            dt = (DataTable)dtgDSMonAn.DataSource;
            dt.RejectChanges();
           */
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            int iUpdate = 0;

            int numItems = _thucDon.DanhSachMonAn.Count;
            int selection = 1;
            if(rdoLoi.Checked)
            {
                selection = 0;
            }
            else if(rdoDocBan.Checked) { selection = 2; }
            for(int i = 0; i < numItems; i++)
            {
                string tinhTrang = (String) dtgDSMonAn.Rows[i].Cells["tinhTrang"].Value;
                decimal Gia = Convert.ToDecimal(dtgDSMonAn.Rows[i].Cells["Gia"].Value);
                string maThucDon = _thucDon.MaThucDon;
                string maMonAn = _thucDon.DanhSachMonAn[i].MaMonAn;
                if (_thucDon.DanhSachMonAn[i].TinhTrang != tinhTrang || _thucDon.DanhSachMonAn[i].Gia != Gia)
                {
                    
                    int result = DOITACBUS.capNhatThucDon(maThucDon, maMonAn, tinhTrang, Gia, selection);
                    if (result > 0)
                       iUpdate++;
                }
                

            }
            if(iUpdate >0)
                MessageBox.Show("Đã cập nhật thành công: " +  iUpdate.ToString());
            else
                MessageBox.Show("Cập nhật thất bại");
        }

        private void btnThemMonAn_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = MONANBUS.layMaMonAn();
            int numItems = table.Rows.Count;
            List<MonAnDTO> list = new List<MonAnDTO>();
            for (int i = 0; i < numItems; i++)
            {
                MonAnDTO monAn = new MonAnDTO();
                if (table.Rows[i]["tenMonAn"] != DBNull.Value)
                {
                    monAn.MaMonAn = (String)table.Rows[i]["maMonAn"];
                    monAn.TenMonAn = (String)table.Rows[i]["tenMonAn"];
                }
                list.Add(monAn);
            }
            this.Hide();
            ThemMonAn themMonAn = new ThemMonAn(this, list);
            themMonAn.Show();
            this.Close();
        }
        public ThucDonDTO getThucDon()
        {
            return _thucDon;
        }
        public DoiTac getDoiTacForm()
        {
            return _doiTacForm;
        }
        private void ShowDoiTac()
        {
            _doiTacForm.Show();
        }

        private void dtgDSMonAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdoKhongLoi_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    
}
