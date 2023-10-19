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
    public partial class frmTrangChu : Form
    {
        public frmTrangChu(string name)
        {
            InitializeComponent();
            lbName.Text = "Chào mừng bạn " + name;

          
        }

        public void nhung(Form f)
        {
            panel_nd.Controls.Clear();//Xõa các control trong form cũ
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;//quan trọng là dòng này thiếu là chít
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            panel_nd.Controls.Add(f);//thêm form mới vào panel
            panel_nd.Show();
        }


        private void mn_DangKy_Click(object sender, EventArgs e)
        {
            frmDangKy showDangKy = new frmDangKy();
            nhung(showDangKy);
        }

        private void mn_QuenMatKhau_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau showQuenMatKhau = new frmQuenMatKhau();
            nhung(showQuenMatKhau);
        }

        private void mn_DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap showDangNhap = new frmDangNhap();
            showDangNhap.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mn_SanPham_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan.frmSanPham frmSP = new QuanLyTaiKhoan.frmSanPham();
            frmSP.Show();
        }
    }
}
