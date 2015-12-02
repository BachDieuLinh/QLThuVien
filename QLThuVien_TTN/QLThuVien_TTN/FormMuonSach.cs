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
    public partial class FormMuonSach : Form
    {
        objPhieuMuonSach phieumuon = new objPhieuMuonSach();
        objNhanVien nhanvien = new objNhanVien();
        objDocGia docgia = new objDocGia();
        objChiTietMuon chitietmuon = new objChiTietMuon();
        objSach sach  = new objSach();
        public FormMuonSach()
        {
            InitializeComponent();
         
            HienThiDGVDocGia();
            HienThiDGVNhanVien();
            HienThiDGVPhieuMuon();
            txtMaPhieuMuon.Enabled = txtMaDG.Enabled = txtMaNV.Enabled = false;
          
        }

        public void HienThiDGVPhieuMuon()
        {
            dgvPhieuMuon.DataSource = phieumuon.HienThiPhieuMuon();
        }

        public void HienThiDGVChiTietMuon()
        {
            dgvChiTietMuon.DataSource = chitietmuon.HienThiChiTietMuon();
        }

        public void HienThiDGVDocGia()
        {
            dgvDocGia.DataSource = docgia.HienThiBanDoc();
        }


        public void HienThiDGVNhanVien()
        {
            dgvNhanVien.DataSource = nhanvien.HienThiNhanVien();
        }

        public void HienThiSach()
        {
            dgvSach.DataSource = sach.HienThiSach();
        }

        private void dgvDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDG.Text = dgvDocGia.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSach.Text = dgvSach.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnMoCTP_Click(object sender, EventArgs e)
        {
            HienThiDGVChiTietMuon();
            HienThiSach();
        }

        private void dgvPhieuMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPM.Text = dgvPhieuMuon.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnGhiCTM_Click(object sender, EventArgs e)
        {
            chitietmuon.GhiChiTietMuon(txtMaPM.Text, txtMaSach.Text);
            HienThiDGVChiTietMuon();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            txtMaPhieuMuon.Enabled = txtMaDG.Enabled = txtMaNV.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            phieumuon.GhiPhieuMuonSach(txtMaPhieuMuon.Text, txtMaDG.Text, txtMaNV.Text, DateTime.Now.ToString(),dtNgayTra.Value.ToShortDateString(),1);
            HienThiDGVPhieuMuon();
        }

        private void txtTKSach_TextChanged(object sender, EventArgs e)
        {
            if (rbMaSach.Checked == true) dgvSach.DataSource = sach.TimKiem_MaSach(txtTKSach.Text);
            if (rbTenSach.Checked == true) dgvSach.DataSource = sach.TimKiem_TenSach(txtTKSach.Text);
            if (rbNoiDung.Checked == true) dgvSach.DataSource = sach.TimKiem_NoiDung(txtTKSach.Text);
            if (rbTheLoai.Checked == true) dgvSach.DataSource = sach.TimKiem_TheLoai(txtTKSach.Text);
            if (rbNXB.Checked == true) dgvSach.DataSource = sach.TimKiem_NXB(txtTKSach.Text);
        }

        


        
    }
}
