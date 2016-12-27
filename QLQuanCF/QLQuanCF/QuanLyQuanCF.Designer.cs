namespace QLQuanCF
{
    partial class QuanLyQuanCF
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
            this.tctrQLCF = new System.Windows.Forms.TabControl();
            this.ctrHeThong = new System.Windows.Forms.TabPage();
            this.tctrSanPham = new System.Windows.Forms.TabPage();
            this.tctrLoai = new System.Windows.Forms.TabPage();
            this.ctrNhanVien = new System.Windows.Forms.TabPage();
            this.tctrQLCF.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrQLCF
            // 
            this.tctrQLCF.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tctrQLCF.Controls.Add(this.ctrHeThong);
            this.tctrQLCF.Controls.Add(this.tctrSanPham);
            this.tctrQLCF.Controls.Add(this.tctrLoai);
            this.tctrQLCF.Controls.Add(this.ctrNhanVien);
            this.tctrQLCF.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tctrQLCF.Location = new System.Drawing.Point(0, 0);
            this.tctrQLCF.Name = "tctrQLCF";
            this.tctrQLCF.SelectedIndex = 0;
            this.tctrQLCF.Size = new System.Drawing.Size(933, 674);
            this.tctrQLCF.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tctrQLCF.TabIndex = 0;
            // 
            // ctrHeThong
            // 
            this.ctrHeThong.BackColor = System.Drawing.Color.Silver;
            this.ctrHeThong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrHeThong.Location = new System.Drawing.Point(4, 25);
            this.ctrHeThong.Name = "ctrHeThong";
            this.ctrHeThong.Padding = new System.Windows.Forms.Padding(3);
            this.ctrHeThong.Size = new System.Drawing.Size(925, 645);
            this.ctrHeThong.TabIndex = 0;
            this.ctrHeThong.Text = "Hệ Thống";
            this.ctrHeThong.Click += new System.EventHandler(this.ctrHeThong_Click);
            // 
            // tctrSanPham
            // 
            this.tctrSanPham.BackColor = System.Drawing.Color.Silver;
            this.tctrSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tctrSanPham.Location = new System.Drawing.Point(4, 25);
            this.tctrSanPham.Name = "tctrSanPham";
            this.tctrSanPham.Padding = new System.Windows.Forms.Padding(3);
            this.tctrSanPham.Size = new System.Drawing.Size(925, 645);
            this.tctrSanPham.TabIndex = 1;
            this.tctrSanPham.Text = "SanPham";
            // 
            // tctrLoai
            // 
            this.tctrLoai.BackColor = System.Drawing.Color.Silver;
            this.tctrLoai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tctrLoai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tctrLoai.Location = new System.Drawing.Point(4, 25);
            this.tctrLoai.Name = "tctrLoai";
            this.tctrLoai.Padding = new System.Windows.Forms.Padding(3);
            this.tctrLoai.Size = new System.Drawing.Size(925, 645);
            this.tctrLoai.TabIndex = 2;
            this.tctrLoai.Text = "Loại Sản Phẩm";
            // 
            // ctrNhanVien
            // 
            this.ctrNhanVien.BackColor = System.Drawing.Color.Silver;
            this.ctrNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ctrNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrNhanVien.Location = new System.Drawing.Point(4, 25);
            this.ctrNhanVien.Name = "ctrNhanVien";
            this.ctrNhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.ctrNhanVien.Size = new System.Drawing.Size(925, 645);
            this.ctrNhanVien.TabIndex = 3;
            this.ctrNhanVien.Text = "Nhân Viên";
            // 
            // QuanLyQuanCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(958, 636);
            this.Controls.Add(this.tctrQLCF);
            this.Name = "QuanLyQuanCF";
            this.Text = "QuanLyQuanCF";
            this.Load += new System.EventHandler(this.QuanLyQuanCF_Load);
            this.tctrQLCF.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrQLCF;
        private System.Windows.Forms.TabPage ctrHeThong;
        private System.Windows.Forms.TabPage tctrSanPham;
        private System.Windows.Forms.TabPage tctrLoai;
        private System.Windows.Forms.TabPage ctrNhanVien;
    }
}