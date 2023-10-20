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
            LoadData();
        }

        public void LoadData()
        {
            grvSanPham.DataSource = from sp in db.tbSanPhams
                                    select sp;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tbSanPham insert = new tbSanPham();
            insert.sanpham_name = txtTenSanPham.Text;
            db.tbSanPhams.InsertOnSubmit(insert);
            db.SubmitChanges();
            MessageBox.Show("Lưu thành công!");
            LoadData();
        }
    }
}

