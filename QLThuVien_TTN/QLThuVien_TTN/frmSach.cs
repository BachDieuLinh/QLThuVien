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
    public partial class frmSach : Form
    {
        Sach book = new Sach();
        int check = 0;
        public frmSach()
        {
            InitializeComponent();
        }
       
        public void HienThiDGV()
        {
            dgvSach.DataSource = book.HienThiSach();
            int i = 0;
            while (i < dgvSach.Rows.Count - 1)
            {
                dgvSach.Rows[i].Cells[0].Value = (i + 1).ToString();
                i++;
            }
            
        }

        private void setNull()
        {
            txtMaSach.Enabled = txtTenSach.Enabled = txtTacGia.Enabled = txtTheLoai.Enabled = txtNoiDung.Enabled = txtNXB.Enabled= false;
        }
        private void setNotNull()
        {
            txtMaSach.Enabled = txtTenSach.Enabled = txtTacGia.Enabled = txtTheLoai.Enabled = txtNoiDung.Enabled = txtNXB.Enabled = true;
        }


        private void frmSach_Load(object sender, EventArgs e)
        {
            HienThiDGV();
        }

       
        private void btnThem_Click(object sender, EventArgs e)
        {
            setNotNull();
            //txtMaSach.Enabled = false;
            check = 0;
        }

        private void txtLuu_Click(object sender, EventArgs e)
        {
            
                if (check == 0)
                {
                    book.ThemSach(txtMaSach.Text,txtTenSach.Text, txtTheLoai.Text, txtNoiDung.Text, txtTacGia.Text, txtNXB.Text);
                    MessageBox.Show("Thêm thành công");
                }
                if (check == 1)
                {
                    book.SuaSach(txtMaSach.Text, txtTenSach.Text, txtTheLoai.Text, txtNoiDung.Text, txtTacGia.Text, txtNXB.Text);
                    MessageBox.Show("Sửa thành công");
                }
            
          
            setNull();
            HienThiDGV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn Sửa thông tin Sách này?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                setNotNull();
                txtMaSach.Enabled = false;
                check = 1;
                btnLuu.Enabled = true;
               // btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;

            }
           
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setNull();
            try
            {
                txtMaSach.Text = dgvSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTenSach.Text = dgvSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTheLoai.Text = dgvSach.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNoiDung.Text = dgvSach.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtTacGia.Text = dgvSach.Rows[e.RowIndex].Cells[5].Value.ToString(); ;
                txtNXB.Text = dgvSach.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi!!!");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = txtNoiDung.Text = txtNXB.Text = txtTacGia.Text = txtTenSach.Text = txtTheLoai.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa sách này?", "Cảnh báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                book.XoaSach(txtMaSach.Text);
            }
            HienThiDGV();
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            if (rbMaSach.Checked == true) dgvSach.DataSource = book.TimKiem_MaSach(txtTimKiem.Text);
            else if (rbTenSach.Checked == true) dgvSach.DataSource = book.TimKiem_TenSach(txtTimKiem.Text);
            else if (rbTheLoai.Checked == true) dgvSach.DataSource = book.TimKiem_TheLoai(txtTimKiem.Text);
            else if (rbNoiDung.Checked == true) dgvSach.DataSource = book.TimKiem_NoiDung(txtTimKiem.Text);
            else if (rbNXB.Checked == true) dgvSach.DataSource = book.TimKiem_NXB(txtTimKiem.Text);
            else if (rbTacGia.Checked == true) dgvSach.DataSource = book.TimKiem_TacGia(txtTimKiem.Text);
            else MessageBox.Show("Chọn nội dung tìm kiếm");
           // HienThiDGV();
        }
    }
}
