namespace DBMS_Project
{
    partial class DonHang
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
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.maMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tangSL = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(334, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin đơn hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonAn,
            this.tenMonAn,
            this.Gia,
            this.soLuong,
            this.tangSL});
            this.dgvDonHang.Location = new System.Drawing.Point(5, 99);
            this.dgvDonHang.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 29;
            this.dgvDonHang.Size = new System.Drawing.Size(835, 426);
            this.dgvDonHang.TabIndex = 1;
            this.dgvDonHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(465, 539);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng Tiền:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Location = new System.Drawing.Point(604, 542);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(236, 25);
            this.txtTongTien.TabIndex = 3;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnQuayLai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuayLai.Location = new System.Drawing.Point(5, 533);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(221, 42);
            this.btnQuayLai.TabIndex = 4;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.Location = new System.Drawing.Point(250, 598);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(279, 43);
            this.btnXacNhan.TabIndex = 5;
            this.btnXacNhan.Text = "Xác Nhận Đơn Hàng";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // maMonAn
            // 
            this.maMonAn.DataPropertyName = "maMonAn";
            this.maMonAn.HeaderText = "Mã Món Ăn";
            this.maMonAn.MinimumWidth = 6;
            this.maMonAn.Name = "maMonAn";
            this.maMonAn.ReadOnly = true;
            this.maMonAn.Width = 150;
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
            // tangSL
            // 
            this.tangSL.DataPropertyName = "tangSL";
            this.tangSL.HeaderText = "Thêm";
            this.tangSL.MinimumWidth = 6;
            this.tangSL.Name = "tangSL";
            this.tangSL.UseColumnTextForButtonValue = true;
            this.tangSL.Width = 70;
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1188, 710);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDonHang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "DonHang";
            this.Text = "DonHang";
            this.Load += new System.EventHandler(this.DonHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvDonHang;
        private Label label2;
        private TextBox txtTongTien;
        private Button btnQuayLai;
        private Button btnXacNhan;
        private DataGridViewTextBoxColumn maMonAn;
        private DataGridViewTextBoxColumn tenMonAn;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn soLuong;
        private DataGridViewButtonColumn tangSL;
    }
}