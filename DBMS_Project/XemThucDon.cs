using Project.BUS;
using Project.DAO;
using Project.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_Project
{
    public partial class XemThucDon : Form
    {
        public XemThucDon(ThucDonDTO td, DataTable d, CustomerForm f)
        {
            InitializeComponent();
            d.Columns.Add("chkChon", typeof(bool));
            int itemsNumber = d.Rows.Count;
            /*
            for (int i = 0; i < itemsNumber; i++)
            {
                if (d.Rows[i]["tinhTrang"] != DBNull.Value)
                {
                    String value = (String)d.Rows[i]["tinhTrang"];
                    //MessageBox.Show(value);
                    if (value == "Hết hàng")
                    {
                        
                        //MessageBox.Show(i.ToString());
                        if (itemsNumber > 0)
                        {
                            d.Rows.Remove(d.Rows[i]);
                            itemsNumber--;
                            i = i - 1;
                        }
                    }
                }

            }
            */
            _td = new ThucDonDTO(td);
            DataGridViewCheckBoxColumn dgvCbc = new DataGridViewCheckBoxColumn();
            dgvCbc.ValueType = typeof(bool);
            dgvCbc.DataPropertyName = "chkChon";
            dtgMenu.Columns.Add(dgvCbc);
            DataTable _d_new = new DataTable();
            _d_new = d;
            dtgMenu.DataSource = _d_new;
         
            _form = f;
        }
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            dtgMenu.DataSource = null;
            //dtgMenu.Rows.Clear();
            foreach (DataGridViewRow item in this.dtgMenu.SelectedRows)
            {
                dtgMenu.Rows.RemoveAt(item.Index);
            }
            this.Hide();
            _form.ShowDialog();
            this.Close();
        }

        private void btnXemDonHang_Click(object sender, EventArgs e)
        {
            
            //Xử lý trên datagridview để bỏ vào sản phẩm
            DataTable table = new DataTable();
            table = (DataTable)(dtgMenu.DataSource);
            List<MonAnDTO> danhSachMonAn = new List<MonAnDTO>();
            int itemsNumber = table.Rows.Count;            
            for (int i = 0; i < itemsNumber; i++)
            {
                if (dtgMenu.Rows[i].Cells["chkChon"].Value != DBNull.Value)
                {
                    if (Convert.ToBoolean(dtgMenu.Rows[i].Cells["chkChon"].Value) == true)
                    {
                        MonAnDTO monAn = new MonAnDTO();
                        DataGridViewRow row = dtgMenu.Rows[i];
                        monAn.MaMonAn = (String)row.Cells["maMonAn"].Value;
                        monAn.TenMonAn = (String)row.Cells["tenMonAn"].Value;
                        if(row.Cells["tinhTrang"].Value != DBNull.Value)
                            monAn.TinhTrang = (String)row.Cells["tinhTrang"].Value;
                        monAn.LuotLike = (int)row.Cells["luotLike"].Value;
                        monAn.Gia = (decimal)(row.Cells["Gia"].Value);
                        danhSachMonAn.Add(monAn);
                    }
                    dtgMenu.Rows[i].Cells["chkChon"].Value = false;
                }
            }
            //string maKhachHang = _form.getMaKH();
            List<int> danhSachSL = new List<int>(1);
            string maDonHang = DONHANGBUS.TaoMa();
            int IDCuaHang = DONHANGBUS.getIDCuaHang(_td.MaDoiTac);
            DONHANGDTO donHang = new DONHANGDTO(maDonHang, danhSachMonAn, danhSachSL, IDCuaHang);
            this.Hide();
            Form DonHang = new DonHang(this, donHang);
            DonHang.Show();
            
            

            //MessageBox.Show(count.ToString());
        }
        public ThucDonDTO GetThucDon()
        {
            return _td;
        }
        public CustomerForm GetCustomerForm()
        {
            return _form;
        }
        public int LaySTT()
        {
            return THUCDONDAO.laySTT(_td.MaDoiTac);
        }
        public string layMaThucDon()
        {
            return _td.MaThucDon;
        }
        public string LayMaDoiTac()
        {
            return _td.MaDoiTac;
        }
        public string layMaKhachHang()
        {
            return _form.getMaKH();
        }
        public CustomerForm layFormKhachHang()
        {
            return _form;
        }
        public void donHangDTO(DONHANGDTO dh)
        {
            _form.donHangDTO(dh);            
        }
        public void showKH()
        {
            _form.Show();
        }
        private ThucDonDTO _td;
        private CustomerForm _form;

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
