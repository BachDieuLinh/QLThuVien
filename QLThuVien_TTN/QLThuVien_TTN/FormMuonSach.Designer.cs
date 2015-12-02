namespace QLThuVien_TTN
{
    partial class FormMuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.btl = new System.Windows.Forms.Label();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaPhieuMuon = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGhiCTM = new System.Windows.Forms.Button();
            this.lblMaSach = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.dgvChiTietMuon = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbNXB = new System.Windows.Forms.RadioButton();
            this.rbNoiDung = new System.Windows.Forms.RadioButton();
            this.rbTenSach = new System.Windows.Forms.RadioButton();
            this.rbTheLoai = new System.Windows.Forms.RadioButton();
            this.rbMaSach = new System.Windows.Forms.RadioButton();
            this.txtTKSach = new System.Windows.Forms.TextBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMoCTP = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietMuon)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnMoCTP);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnGhi);
            this.groupBox1.Controls.Add(this.dgvPhieuMuon);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtNgayTra);
            this.groupBox1.Controls.Add(this.btl);
            this.groupBox1.Controls.Add(this.txtMaDG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaPhieuMuon);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu mượn";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(371, 61);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Location = new System.Drawing.Point(371, 32);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(75, 23);
            this.btnGhi.TabIndex = 9;
            this.btnGhi.Text = "Ghi phiếu";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvPhieuMuon.Location = new System.Drawing.Point(0, 141);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.Size = new System.Drawing.Size(578, 178);
            this.dgvPhieuMuon.TabIndex = 8;
            this.dgvPhieuMuon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieu";
            this.Column1.HeaderText = "Mã phiếu";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaDG";
            this.Column2.HeaderText = "Mã DG";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNV";
            this.Column3.HeaderText = "Mã NV";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayMuon";
            this.Column4.HeaderText = "Ngày mượn";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayTra";
            this.Column5.HeaderText = "Ngày trả";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày trả";
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Location = new System.Drawing.Point(124, 115);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(200, 20);
            this.dtNgayTra.TabIndex = 6;
            // 
            // btl
            // 
            this.btl.AutoSize = true;
            this.btl.Location = new System.Drawing.Point(17, 59);
            this.btl.Name = "btl";
            this.btl.Size = new System.Drawing.Size(61, 13);
            this.btl.TabIndex = 5;
            this.btl.Text = "Mã độc giả";
            // 
            // txtMaDG
            // 
            this.txtMaDG.Location = new System.Drawing.Point(124, 53);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(200, 20);
            this.txtMaDG.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(124, 80);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 20);
            this.txtMaNV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu mượn";
            // 
            // txtMaPhieuMuon
            // 
            this.txtMaPhieuMuon.Location = new System.Drawing.Point(124, 29);
            this.txtMaPhieuMuon.Name = "txtMaPhieuMuon";
            this.txtMaPhieuMuon.Size = new System.Drawing.Size(200, 20);
            this.txtMaPhieuMuon.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.dgvDocGia);
            this.groupBox2.Location = new System.Drawing.Point(613, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Độc giả";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dgvDocGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocGia.Location = new System.Drawing.Point(3, 16);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.Size = new System.Drawing.Size(533, 137);
            this.dgvDocGia.TabIndex = 14;
            this.dgvDocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaDG";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã ĐG";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenDG";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên ĐG";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "NgheNghiep";
            this.Column13.HeaderText = "Nghề nghiệp";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "SDT";
            this.Column14.HeaderText = "SĐT";
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "DiaChi";
            this.Column15.HeaderText = "Địa chỉ";
            this.Column15.Name = "Column15";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvNhanVien);
            this.groupBox3.Location = new System.Drawing.Point(613, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 175);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhân viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(3, 16);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(533, 156);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.btnGhiCTM);
            this.groupBox4.Controls.Add(this.lblMaSach);
            this.groupBox4.Controls.Add(this.txtMaSach);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtMaPM);
            this.groupBox4.Controls.Add(this.dgvChiTietMuon);
            this.groupBox4.Location = new System.Drawing.Point(12, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 234);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết mượn";
            // 
            // btnGhiCTM
            // 
            this.btnGhiCTM.Location = new System.Drawing.Point(192, 20);
            this.btnGhiCTM.Name = "btnGhiCTM";
            this.btnGhiCTM.Size = new System.Drawing.Size(75, 23);
            this.btnGhiCTM.TabIndex = 13;
            this.btnGhiCTM.Text = "Ghi";
            this.btnGhiCTM.UseVisualStyleBackColor = true;
            this.btnGhiCTM.Click += new System.EventHandler(this.btnGhiCTM_Click);
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(41, 56);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(48, 13);
            this.lblMaSach.TabIndex = 12;
            this.lblMaSach.Text = "Mã sách";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(104, 53);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(79, 20);
            this.txtMaSach.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã phiếu mượn";
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(103, 22);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(83, 20);
            this.txtMaPM.TabIndex = 9;
            // 
            // dgvChiTietMuon
            // 
            this.dgvChiTietMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7});
            this.dgvChiTietMuon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChiTietMuon.Location = new System.Drawing.Point(3, 81);
            this.dgvChiTietMuon.Name = "dgvChiTietMuon";
            this.dgvChiTietMuon.Size = new System.Drawing.Size(443, 150);
            this.dgvChiTietMuon.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox5.Controls.Add(this.rbNXB);
            this.groupBox5.Controls.Add(this.rbNoiDung);
            this.groupBox5.Controls.Add(this.rbTenSach);
            this.groupBox5.Controls.Add(this.rbTheLoai);
            this.groupBox5.Controls.Add(this.rbMaSach);
            this.groupBox5.Controls.Add(this.txtTKSach);
            this.groupBox5.Controls.Add(this.dgvSach);
            this.groupBox5.Location = new System.Drawing.Point(467, 357);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(685, 234);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sách";
            // 
            // rbNXB
            // 
            this.rbNXB.AutoSize = true;
            this.rbNXB.Location = new System.Drawing.Point(452, 22);
            this.rbNXB.Name = "rbNXB";
            this.rbNXB.Size = new System.Drawing.Size(89, 17);
            this.rbNXB.TabIndex = 19;
            this.rbNXB.TabStop = true;
            this.rbNXB.Text = "Nhà xuất bản";
            this.rbNXB.UseVisualStyleBackColor = true;
            // 
            // rbNoiDung
            // 
            this.rbNoiDung.AutoSize = true;
            this.rbNoiDung.Location = new System.Drawing.Point(345, 42);
            this.rbNoiDung.Name = "rbNoiDung";
            this.rbNoiDung.Size = new System.Drawing.Size(68, 17);
            this.rbNoiDung.TabIndex = 18;
            this.rbNoiDung.TabStop = true;
            this.rbNoiDung.Text = "Nội dung";
            this.rbNoiDung.UseVisualStyleBackColor = true;
            // 
            // rbTenSach
            // 
            this.rbTenSach.AutoSize = true;
            this.rbTenSach.Location = new System.Drawing.Point(215, 42);
            this.rbTenSach.Name = "rbTenSach";
            this.rbTenSach.Size = new System.Drawing.Size(70, 17);
            this.rbTenSach.TabIndex = 17;
            this.rbTenSach.TabStop = true;
            this.rbTenSach.Text = "Tên sách";
            this.rbTenSach.UseVisualStyleBackColor = true;
            // 
            // rbTheLoai
            // 
            this.rbTheLoai.AutoSize = true;
            this.rbTheLoai.Location = new System.Drawing.Point(345, 22);
            this.rbTheLoai.Name = "rbTheLoai";
            this.rbTheLoai.Size = new System.Drawing.Size(63, 17);
            this.rbTheLoai.TabIndex = 16;
            this.rbTheLoai.TabStop = true;
            this.rbTheLoai.Text = "Thể loại";
            this.rbTheLoai.UseVisualStyleBackColor = true;
            // 
            // rbMaSach
            // 
            this.rbMaSach.AutoSize = true;
            this.rbMaSach.Location = new System.Drawing.Point(215, 19);
            this.rbMaSach.Name = "rbMaSach";
            this.rbMaSach.Size = new System.Drawing.Size(66, 17);
            this.rbMaSach.TabIndex = 15;
            this.rbMaSach.TabStop = true;
            this.rbMaSach.Text = "Mã sách";
            this.rbMaSach.UseVisualStyleBackColor = true;
            // 
            // txtTKSach
            // 
            this.txtTKSach.Location = new System.Drawing.Point(33, 18);
            this.txtTKSach.Name = "txtTKSach";
            this.txtTKSach.Size = new System.Drawing.Size(177, 20);
            this.txtTKSach.TabIndex = 14;
            this.txtTKSach.TextChanged += new System.EventHandler(this.txtTKSach_TextChanged);
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgvSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSach.Location = new System.Drawing.Point(3, 81);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(679, 150);
            this.dgvSach.TabIndex = 1;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "MaNV";
            this.Column16.HeaderText = "Mã NV";
            this.Column16.Name = "Column16";
            this.Column16.Width = 60;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "TenNV";
            this.Column17.HeaderText = "Tên NV";
            this.Column17.Name = "Column17";
            this.Column17.Width = 120;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "ChucVu";
            this.Column18.HeaderText = "Chức vụ";
            this.Column18.Name = "Column18";
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "DiaChi";
            this.Column19.HeaderText = "Địa chỉ";
            this.Column19.Name = "Column19";
            this.Column19.Width = 120;
            // 
            // Column20
            // 
            this.Column20.DataPropertyName = "SDT";
            this.Column20.HeaderText = "SĐT";
            this.Column20.Name = "Column20";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaSach";
            this.Column8.HeaderText = "Mã sách";
            this.Column8.Name = "Column8";
            this.Column8.Width = 120;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "TenSach";
            this.Column9.HeaderText = "Tên sách";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TheLoai";
            this.Column10.HeaderText = "Thể loại";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "NoiDung";
            this.Column11.HeaderText = "Nội dung";
            this.Column11.Name = "Column11";
            this.Column11.Width = 200;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "NXB";
            this.Column12.HeaderText = "NXB";
            this.Column12.Name = "Column12";
            this.Column12.Width = 120;
            // 
            // btnMoCTP
            // 
            this.btnMoCTP.Location = new System.Drawing.Point(371, 90);
            this.btnMoCTP.Name = "btnMoCTP";
            this.btnMoCTP.Size = new System.Drawing.Size(75, 23);
            this.btnMoCTP.TabIndex = 11;
            this.btnMoCTP.Text = "Ghi CTP";
            this.btnMoCTP.UseVisualStyleBackColor = true;
            this.btnMoCTP.Click += new System.EventHandler(this.btnMoCTP_Click);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaPhieu";
            this.Column6.HeaderText = "Mã phiếu mượn";
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaSach";
            this.Column7.HeaderText = "Mã sách";
            this.Column7.Name = "Column7";
            this.Column7.Width = 200;
            // 
            // FormMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1153, 603);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMuonSach";
            this.Text = "Mượn sách";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietMuon)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.Label btl;
        private System.Windows.Forms.TextBox txtMaDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGhiCTM;
        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.DataGridView dgvChiTietMuon;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.RadioButton rbNXB;
        private System.Windows.Forms.RadioButton rbNoiDung;
        private System.Windows.Forms.RadioButton rbTenSach;
        private System.Windows.Forms.RadioButton rbTheLoai;
        private System.Windows.Forms.RadioButton rbMaSach;
        private System.Windows.Forms.TextBox txtTKSach;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btnMoCTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}