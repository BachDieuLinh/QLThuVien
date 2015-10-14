namespace QLThuVien_TTN
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.nhânViênToolStripMenuItem,
            this.độcGiảToolStripMenuItem,
            this.mượnTrảSáchToolStripMenuItem,
            this.mượnTrảSáchToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(845, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.độcGiảToolStripMenuItem.Text = "Độc giả";
            // 
            // mượnTrảSáchToolStripMenuItem
            // 
            this.mượnTrảSáchToolStripMenuItem.Name = "mượnTrảSáchToolStripMenuItem";
            this.mượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.mượnTrảSáchToolStripMenuItem.Text = "Sách";
            this.mượnTrảSáchToolStripMenuItem.Click += new System.EventHandler(this.mượnTrảSáchToolStripMenuItem_Click);
            // 
            // mượnTrảSáchToolStripMenuItem1
            // 
            this.mượnTrảSáchToolStripMenuItem1.Name = "mượnTrảSáchToolStripMenuItem1";
            this.mượnTrảSáchToolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            this.mượnTrảSáchToolStripMenuItem1.Text = "Mượn trả sách";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 331);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Quản lý thư viện";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem1;
    }
}