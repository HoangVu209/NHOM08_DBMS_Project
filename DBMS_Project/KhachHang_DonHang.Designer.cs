namespace DBMS_Project
{
    partial class KhachHang_DonHang
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
            this.dtgDonHang = new System.Windows.Forms.DataGridView();
            this.tenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyDonHang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDonHang = new System.Windows.Forms.TextBox();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDonHang
            // 
            this.dtgDonHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenMonAn,
            this.Gia,
            this.soLuong});
            this.dtgDonHang.Location = new System.Drawing.Point(265, 124);
            this.dtgDonHang.Name = "dtgDonHang";
            this.dtgDonHang.ReadOnly = true;
            this.dtgDonHang.RowHeadersWidth = 51;
            this.dtgDonHang.RowTemplate.Height = 29;
            this.dtgDonHang.Size = new System.Drawing.Size(457, 337);
            this.dtgDonHang.TabIndex = 0;
            this.dtgDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá tiền";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 125;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đơn Hàng Của Bạn!";
            // 
            // btnHuyDonHang
            // 
            this.btnHuyDonHang.BackColor = System.Drawing.Color.CadetBlue;
            this.btnHuyDonHang.Location = new System.Drawing.Point(750, 405);
            this.btnHuyDonHang.Name = "btnHuyDonHang";
            this.btnHuyDonHang.Size = new System.Drawing.Size(142, 37);
            this.btnHuyDonHang.TabIndex = 2;
            this.btnHuyDonHang.Text = "Hủy Đơn Hàng";
            this.btnHuyDonHang.UseVisualStyleBackColor = false;
            this.btnHuyDonHang.Click += new System.EventHandler(this.btnHuyDonHang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Đơn Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tình Trạng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng Tiền: ";
            // 
            // txtMaDonHang
            // 
            this.txtMaDonHang.Location = new System.Drawing.Point(322, 85);
            this.txtMaDonHang.Name = "txtMaDonHang";
            this.txtMaDonHang.ReadOnly = true;
            this.txtMaDonHang.Size = new System.Drawing.Size(125, 29);
            this.txtMaDonHang.TabIndex = 7;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(652, 85);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.ReadOnly = true;
            this.txtTinhTrang.Size = new System.Drawing.Size(164, 29);
            this.txtTinhTrang.TabIndex = 8;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(597, 467);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(125, 29);
            this.txtTongTien.TabIndex = 9;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(12, 15);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(142, 29);
            this.btnQuayLai.TabIndex = 10;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // KhachHang_DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1000, 537);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.txtMaDonHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuyDonHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDonHang);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "KhachHang_DonHang";
            this.Text = "KhachHang_DonHang";
            this.Load += new System.EventHandler(this.KhachHang_DonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgDonHang;
        private Label label1;
        private Button btnHuyDonHang;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaDonHang;
        private TextBox txtTinhTrang;
        private TextBox txtTongTien;
        private DataGridViewTextBoxColumn tenMonAn;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn soLuong;
        private Button btnQuayLai;
    }
}