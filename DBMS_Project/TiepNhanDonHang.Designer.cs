namespace DBMS_Project
{
    partial class TiepNhanDonHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChotDon = new System.Windows.Forms.Button();
            this.dtgDonHang = new System.Windows.Forms.DataGridView();
            this.tenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoLoi = new System.Windows.Forms.RadioButton();
            this.rdoKhongLoi = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDonHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chốt Đơn !";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtgDonHang);
            this.groupBox1.Location = new System.Drawing.Point(235, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết đơn hàng";
            // 
            // btnChotDon
            // 
            this.btnChotDon.Location = new System.Drawing.Point(203, 37);
            this.btnChotDon.Name = "btnChotDon";
            this.btnChotDon.Size = new System.Drawing.Size(108, 29);
            this.btnChotDon.TabIndex = 0;
            this.btnChotDon.Text = "Chốt đơn!";
            this.btnChotDon.UseVisualStyleBackColor = true;
            this.btnChotDon.Click += new System.EventHandler(this.btnChotDon_Click);
            // 
            // dtgDonHang
            // 
            this.dtgDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenMonAn,
            this.soLuong});
            this.dtgDonHang.Location = new System.Drawing.Point(140, 27);
            this.dtgDonHang.Name = "dtgDonHang";
            this.dtgDonHang.RowHeadersWidth = 51;
            this.dtgDonHang.RowTemplate.Height = 29;
            this.dtgDonHang.Size = new System.Drawing.Size(329, 226);
            this.dtgDonHang.TabIndex = 0;
            // 
            // tenMonAn
            // 
            this.tenMonAn.DataPropertyName = "tenMonAn";
            this.tenMonAn.HeaderText = "Tên Món Ăn";
            this.tenMonAn.MinimumWidth = 6;
            this.tenMonAn.Name = "tenMonAn";
            this.tenMonAn.ReadOnly = true;
            this.tenMonAn.Width = 150;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số Lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Đơn Hàng:";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(450, 89);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.Size = new System.Drawing.Size(140, 28);
            this.txtMaDonHang.TabIndex = 3;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(12, 12);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(94, 29);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoKhongLoi);
            this.groupBox2.Controls.Add(this.rdoLoi);
            this.groupBox2.Controls.Add(this.btnChotDon);
            this.groupBox2.Location = new System.Drawing.Point(211, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 102);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Loại";
            // 
            // rdoLoi
            // 
            this.rdoLoi.AutoSize = true;
            this.rdoLoi.Location = new System.Drawing.Point(24, 24);
            this.rdoLoi.Name = "rdoLoi";
            this.rdoLoi.Size = new System.Drawing.Size(146, 25);
            this.rdoLoi.TabIndex = 1;
            this.rdoLoi.TabStop = true;
            this.rdoLoi.Text = "Lỗi Lost Update";
            this.rdoLoi.UseVisualStyleBackColor = true;
            // 
            // rdoKhongLoi
            // 
            this.rdoKhongLoi.AutoSize = true;
            this.rdoKhongLoi.Location = new System.Drawing.Point(24, 55);
            this.rdoKhongLoi.Name = "rdoKhongLoi";
            this.rdoKhongLoi.Size = new System.Drawing.Size(153, 25);
            this.rdoKhongLoi.TabIndex = 2;
            this.rdoKhongLoi.TabStop = true;
            this.rdoKhongLoi.Text = "Sửa Lost Update";
            this.rdoKhongLoi.UseVisualStyleBackColor = true;
            // 
            // TiepNhanDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1079, 499);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "TiepNhanDonHang";
            this.Text = "TiepNhanDonHang";
            this.Load += new System.EventHandler(this.TiepNhanDonHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDonHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnChotDon;
        private DataGridView dtgDonHang;
        private Label label2;
        private TextBox txtMaDonHang;
        private DataGridViewTextBoxColumn tenMonAn;
        private DataGridViewTextBoxColumn soLuong;
        private Button btnQuayLai;
        private GroupBox groupBox2;
        private RadioButton rdoKhongLoi;
        private RadioButton rdoLoi;
    }
}