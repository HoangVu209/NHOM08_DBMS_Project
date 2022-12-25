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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUserName.Text;
            string matKhau = txtPasword.Text;

            TaiKhoanDTO p  = new TaiKhoanDTO();
            
            p.TenDangNhap = tenDangNhap;
            p.MatKhau= matKhau;
            
            
            int n = TaiKhoanBUS.Login(p);
            p.LoaiTaiKhoan = n;
            if (n > 0)
            {

                // Lấy mã sau khi thực hiện
                int IDAccount = TaiKhoanBUS.getIDAccount(tenDangNhap);
                p.IDAccount = IDAccount;
                MessageBox.Show(IDAccount.ToString());
                string Ma = TaiKhoanBUS.TokenValue(p);
                //MessageBox.Show(p.LoaiTaiKhoan.ToString());
                //Nếu là khách hàng thì thể gọi constructor để hiện thị form khách hàng
                if (p.LoaiTaiKhoan == 4)
                {
                    DataTable table = new DataTable();
                    table = KhachHangBUS.GetInfor(Ma);
                    this.Hide();
                    Form CustomerForm = new CustomerForm(table);
                    CustomerForm.ShowDialog();
                    //Aaron044
                    //yp@2421LX                                                                                                                                                                                               
                }
                if (p.LoaiTaiKhoan == 2) 
                {
                    DataTable table = new DataTable();
                    table = DOITACBUS.layThongTinDoiTac(Ma);
                    this.Hide();
                    DoiTac form = new DoiTac(table);
                    form.Show();
                    this.Close();
                    //sozcx
                    //57182
                }

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
