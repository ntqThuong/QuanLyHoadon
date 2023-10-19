using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTaiKhoan.QuanLyTaiKhoan
{
    public partial class frmSanPham : Form
    {
        dbcsdlDataContext db = new dbcsdlDataContext();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            var ListSanPham = from sp in db.tb_SanPhams
                              join spct in db.tb_SanPhamChiTiets on sp.sp_id equals spct.sp_id
                              select new
                              {
                                  sp.sp_name,
                                  spct.spct_name,
                                  spct.spct_dongia,
                                  spct.spct_tonkho,
                              };
            grvSanPham.DataSource = ListSanPham;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLoai.Text == "" && txtTen.Text == "" && txtSoLuong.Text== "" && txtDonGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                
            }
        }
    }
}
