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
    public partial class ThemMonAn : Form
    {
        public ThemMonAn()
        {
            InitializeComponent();
            _monAn = new List<MonAnDTO>();
            _form = new DoiTac_ThucDoncs();
        }
        public ThemMonAn(DoiTac_ThucDoncs form, List<MonAnDTO> list)
        {
            InitializeComponent();
            _form = new DoiTac_ThucDoncs();
            _form = form;
            _monAn = new List<MonAnDTO>();
            _monAn = list;
            
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnXemMonAn_Click(object sender, EventArgs e)
        {
            int numItems = _monAn.Count;
            for (int i = 0; i < numItems; i++)
            {
                cbbMonAn.Items.Insert(i, (String)_monAn[i].TenMonAn);
            }
        }

        private DoiTac_ThucDoncs _form;
        private List<MonAnDTO> _monAn;

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            ThucDonDTO td = new ThucDonDTO();
            td = _form.getThucDon();
            string maThucDon = td.MaThucDon.ToString();
            string maMonAn = _monAn[cbbMonAn.SelectedIndex].MaMonAn.ToString();
            Decimal Gia = Convert.ToDecimal(txtGia.Text);
            int result = DOITACBUS.ThemMonAnVaoThucDon(maThucDon, maMonAn, Gia);
            if(result > 0)
            {
                MonAnDTO monAn = new MonAnDTO();
                monAn.MaMonAn = _monAn[cbbMonAn.SelectedIndex].MaMonAn.ToString();
                monAn.TenMonAn = _monAn[cbbMonAn.SelectedIndex].TenMonAn.ToString();
                monAn.Gia = Convert.ToDecimal(txtGia.Text);
                td.DanhSachMonAn.Add(monAn);
                int numItems = td.DanhSachMonAn.Count();
                MessageBox.Show(td.DanhSachMonAn[numItems - 1].TenMonAn.ToString());
                MessageBox.Show("Thêm thành công!");
                DoiTac_ThucDoncs form = new DoiTac_ThucDoncs(_form.getDoiTacForm(), td);
                this.Hide();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm món ăn thất bại");
                this.Hide();
                _form.Show();
                this.Close();
            } 
                
        }
    }
}
