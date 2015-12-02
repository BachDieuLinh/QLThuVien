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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void mượnTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach frms = new frmSach();
            frms.Show();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDocGia frmDG = new FormDocGia();
            frmDG.Show();
        }

        private void mượnTrảSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMuonSach frmMuonSach = new FormMuonSach();
            frmMuonSach.Show();
        }
    }
}
