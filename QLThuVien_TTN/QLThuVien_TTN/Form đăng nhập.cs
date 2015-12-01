using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien_TTN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            frmSach frm = new frmSach();
            frm.Show();
          
        }
       
          
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FormMenu frmMenu = new FormMenu();
           // Form frm = new Form();
            if (txtTenDN.Text == "admin" && txtMK.Text == "123456")
                frmMenu.Show();
                
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
