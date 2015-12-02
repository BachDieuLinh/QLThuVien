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
    public partial class FormDocGia : Form
    {
        public FormDocGia()
        {
            InitializeComponent();
        }

        objDocGia bd = new objDocGia();
        int chon;
        public void KhoaDK()
        {
            txtMaDG.Enabled = txtTenDG.Enabled = txtNgheNghiep.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        public void MoDK()
        {
            txtMaDG.Enabled = txtTenDG.Enabled = txtNgheNghiep.Enabled = txtSDT.Enabled = txtDiaChi.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }

        public void SetNull()
        {
            txtMaDG.Text = txtTenDG.Text = txtNgheNghiep.Text = txtSDT.Text = txtDiaChi.Text = txtTimKiem.Text = "";
            cbTK.Text = "";
            //dtpNgaySinh.Text = DateTime.Now.ToString();
        }

        private void DocGia_Load(object sender, EventArgs e)
        {
            dgvBanDoc.DataSource = bd.HienThiBanDoc();
            KhoaDK();
            SetNull();
            chon = 0;
        }

        private void dgvBanDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaDG.Text = dgvBanDoc.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenDG.Text = dgvBanDoc.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNgheNghiep.Text = dgvBanDoc.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dgvBanDoc.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvBanDoc.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch { }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoDK();
            SetNull();
            chon = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDK();
            chon = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text == "")
                MessageBox.Show("Mời bạn chọn người xóa!");
            else
            {
                if (DialogResult.Yes == MessageBox.Show("Bạn muốn xóa Bạn đọc này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    bd.XoaBanDoc(txtMaDG.Text);
                    MessageBox.Show("Xóa thành công!");
                    DocGia_Load(sender, e);
                    SetNull();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DocGia_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chon == 1)
            {
                if (txtTenDG.Text == "" || txtNgheNghiep.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thêm Độc giả này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        bd.ThemBanDoc(txtMaDG.Text, txtTenDG.Text, txtNgheNghiep.Text, txtSDT.Text, txtDiaChi.Text);
                        MessageBox.Show("Thêm thành công!");
                        SetNull();
                        DocGia_Load(sender, e);
                    }
            }
            else if (chon == 2)
            {
                if (txtTenDG.Text == "" || txtNgheNghiep.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
                    MessageBox.Show("Mời nhập đầy đủ thông tin!");
                else
                    if (DialogResult.Yes == MessageBox.Show("Bạn có muốn Sửa Độc giả này?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        bd.SuaBanDoc(txtMaDG.Text, txtTenDG.Text, txtNgheNghiep.Text, txtSDT.Text, txtDiaChi.Text);
                        MessageBox.Show("Sửa thành công!");
                        SetNull();
                        DocGia_Load(sender, e);
                    }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbTK.Text == "Mã bạn đọc")
                dgvBanDoc.DataSource = bd.TKDG_MaDG(txtTimKiem.Text);
            else
            {
                if (cbTK.Text == "Họ tên")
                    dgvBanDoc.DataSource = bd.TKDG_TenDG(txtTimKiem.Text);
            }
        }
    }

}
