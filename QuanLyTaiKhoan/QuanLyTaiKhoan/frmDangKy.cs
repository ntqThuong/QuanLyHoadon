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
    public partial class frmDangKy : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

            if (txtfullname.Text != "" && txtuser.Text != ""  && txtphone.Text != "" && cbnam.Checked == true && cbnu.Checked == true && txtpass.Text != "" && txtPassCF.Text != "" && (txtpass.Text == txtPassCF.Text))

            {
                admin_User ins = new admin_User();
                ins.username_fullname = txtfullname.Text;
                ins.username_username = txtuser.Text;
                ins.username_phone = txtphone.Text;
                ins.username_fullname = txtpass.Text;
                ins.username_password = txtpass.Text;
                db.admin_Users.InsertOnSubmit(ins);
                db.SubmitChanges();
                MessageBox.Show("Đăng ký thành công");
                this.Hide();
                frmDangNhap dangNhapForm = new frmDangNhap();
                dangNhapForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Thiếu hoặc sai mật khẩu xác nhận!");
            }
        }
    }
}
