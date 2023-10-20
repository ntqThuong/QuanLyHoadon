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
    public partial class frmQuenMatKhau : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        public frmQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnQMatKhau_Click(object sender, EventArgs e)
        {
            var getMatKhau = from u in db.admin_Users
                             where u.username_username == txtuser.Text
                             select u;
            if (getMatKhau.Count() > 0)
            {
                lbMatKhau.Text = getMatKhau.FirstOrDefault().username_password;
            }
            else
            {
                lbMatKhau.Text = "Không tồn tại tài khoảng!";
            }
        }
    }
}
