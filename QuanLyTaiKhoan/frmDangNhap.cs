using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoan
{
    public partial class frmDangNhap : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public string UserName { get; private set; }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            var check = from u in db.tb_Users
                        where u.username_name == txtuser.Text
                        && u.username_pass == txtpass.Text
                        select u;
            if (check.Count() > 0)
            {
                this.Hide();
                MessageBox.Show("Đăng nhập thanh công" );
                frmTrangChu frmChu = new frmTrangChu(check.FirstOrDefault().username_fullname);
                frmChu.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangKy dangKyForm = new frmDangKy();
            dangKyForm.ShowDialog();
            this.Show();
        }

        private void btnQMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuenMatKhau dangKyForm = new frmQuenMatKhau();
            dangKyForm.ShowDialog();
            this.Show();
        }

      
    }
}
