using Project.DTO;
using Project.BUS;
using Project.DAO;

namespace DBMS_Project

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtConfrimPassword.Text) 
            {
                MessageBox.Show("Mật khẩu không khớp nhau");
                return;
            }
            if(cbbAccType.SelectedIndex == -1) 
            {
                MessageBox.Show("Chưa chọn vai trò!");
                return;
            }
            TaiKhoanDTO t = new TaiKhoanDTO();
            t.TenDangNhap =  txtUserName.Text;
            t.MatKhau = txtPassword.Text;
            t.LoaiTaiKhoan = cbbAccType.SelectedIndex + 1;
            int n = TaiKhoanBUS.Insert(t);
            if(n < 0)
            {
                MessageBox.Show(txtUserName.Text);
                MessageBox.Show("Đăng kí không thành công!");
            }
            else
            {
                MessageBox.Show("Đăng kí thành công");
            } 
                
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginForm = new Login();
            loginForm.ShowDialog();
        }
    }

}