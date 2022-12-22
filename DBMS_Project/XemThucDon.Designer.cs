namespace DBMS_Project
{
    partial class XemThucDon
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
            this.dtgMenu = new System.Windows.Forms.DataGridView();
            this.maMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luotLike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkChon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXemDonHang = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMenu
            // 
            this.dtgMenu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMonAn,
            this.tenMonAn,
            this.luotLike,
            this.tinhTrang,
            this.Gia,
            this.chkChon});
            this.dtgMenu.Location = new System.Drawing.Point(24, 109);
            this.dtgMenu.Name = "dtgMenu";
            this.dtgMenu.RowHeadersWidth = 51;
            this.dtgMenu.RowTemplate.Height = 29;
            this.dtgMenu.Size = new System.Drawing.Size(899, 367);
            this.dtgMenu.TabIndex = 0;
            // 
            // maMonAn
            // 
            this.maMonAn.DataPropertyName = "maMonAn";
            this.maMonAn.HeaderText = "Mã món ăn";
            this.maMonAn.MinimumWidth = 6;
            this.maMonAn.Name = "maMonAn";
            this.maMonAn.Width = 125;
            // 
            // tenMonAn
            // 
            this.tenMonAn.DataPropertyName = "tenMonAn";
            this.tenMonAn.HeaderText = "Tên Món Ăn";
            this.tenMonAn.MinimumWidth = 6;
            this.tenMonAn.Name = "tenMonAn";
            this.tenMonAn.Width = 150;
            // 
            // luotLike
            // 
            this.luotLike.DataPropertyName = "luotLike";
            this.luotLike.HeaderText = "Lượt thích";
            this.luotLike.MinimumWidth = 6;
            this.luotLike.Name = "luotLike";
            this.luotLike.Width = 125;
            // 
            // tinhTrang
            // 
            this.tinhTrang.DataPropertyName = "tinhTrang";
            this.tinhTrang.HeaderText = "Tình Trạng";
            this.tinhTrang.MinimumWidth = 6;
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.Width = 175;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá Tiền";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // chkChon
            // 
            this.chkChon.DataPropertyName = "chkChon";
            this.chkChon.HeaderText = "Thêm vào đơn hàng";
            this.chkChon.MinimumWidth = 6;
            this.chkChon.Name = "chkChon";
            this.chkChon.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(348, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 105);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuayLai.Location = new System.Drawing.Point(64, 482);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(94, 26);
            this.btnQuayLai.TabIndex = 2;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnXemDonHang
            // 
            this.btnXemDonHang.Location = new System.Drawing.Point(728, 482);
            this.btnXemDonHang.Name = "btnXemDonHang";
            this.btnXemDonHang.Size = new System.Drawing.Size(152, 26);
            this.btnXemDonHang.TabIndex = 3;
            this.btnXemDonHang.Text = "Xem đơn hàng";
            this.btnXemDonHang.UseVisualStyleBackColor = true;
            this.btnXemDonHang.Click += new System.EventHandler(this.btnXemDonHang_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRefresh.Location = new System.Drawing.Point(36, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 26);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // XemThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(960, 520);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnXemDonHang);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgMenu);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "XemThucDon";
            this.Text = "XemThucDon";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgMenu;
        private Label label1;
        private Button btnQuayLai;
        private Button btnXemDonHang;
        private DataGridViewTextBoxColumn maMonAn;
        private DataGridViewTextBoxColumn tenMonAn;
        private DataGridViewTextBoxColumn luotLike;
        private DataGridViewTextBoxColumn tinhTrang;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewCheckBoxColumn chkChon;
        private Button btnRefresh;
    }
}