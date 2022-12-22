namespace DBMS_Project
{
    partial class DoiTac_ThucDoncs
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
            this.dtgDSMonAn = new System.Windows.Forms.DataGridView();
            this.tenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luotLike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.ckbCapNhat = new System.Windows.Forms.CheckBox();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.txtMaThucDon = new System.Windows.Forms.TextBox();
            this.btnThemMonAn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoKhongLoi = new System.Windows.Forms.RadioButton();
            this.rdoLoi = new System.Windows.Forms.RadioButton();
            this.rdoDocBan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSMonAn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu!";
            // 
            // dtgDSMonAn
            // 
            this.dtgDSMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenMonAn,
            this.tinhTrang,
            this.Gia,
            this.luotLike});
            this.dtgDSMonAn.Location = new System.Drawing.Point(21, 104);
            this.dtgDSMonAn.Name = "dtgDSMonAn";
            this.dtgDSMonAn.RowHeadersWidth = 51;
            this.dtgDSMonAn.RowTemplate.Height = 29;
            this.dtgDSMonAn.Size = new System.Drawing.Size(574, 320);
            this.dtgDSMonAn.TabIndex = 1;
            this.dtgDSMonAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDSMonAn_CellContentClick);
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
            // tinhTrang
            // 
            this.tinhTrang.DataPropertyName = "tinhTrang";
            this.tinhTrang.HeaderText = "Tình Trạng";
            this.tinhTrang.MinimumWidth = 6;
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá Tiền";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // luotLike
            // 
            this.luotLike.DataPropertyName = "luotLike";
            this.luotLike.HeaderText = "Lượt Thích";
            this.luotLike.MinimumWidth = 6;
            this.luotLike.Name = "luotLike";
            this.luotLike.ReadOnly = true;
            this.luotLike.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã thực đơn:";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(237, 70);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 29);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(21, 442);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 29);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // ckbCapNhat
            // 
            this.ckbCapNhat.AutoSize = true;
            this.ckbCapNhat.Location = new System.Drawing.Point(623, 64);
            this.ckbCapNhat.Name = "ckbCapNhat";
            this.ckbCapNhat.Size = new System.Drawing.Size(170, 25);
            this.ckbCapNhat.TabIndex = 9;
            this.ckbCapNhat.Text = "Cho phép cập nhật";
            this.ckbCapNhat.UseVisualStyleBackColor = true;
            this.ckbCapNhat.CheckedChanged += new System.EventHandler(this.ckbCapNhat_CheckedChanged);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(21, 9);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(94, 29);
            this.btnQuayLai.TabIndex = 10;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // txtMaThucDon
            // 
            this.txtMaThucDon.Location = new System.Drawing.Point(136, 44);
            this.txtMaThucDon.Name = "txtMaThucDon";
            this.txtMaThucDon.Size = new System.Drawing.Size(125, 28);
            this.txtMaThucDon.TabIndex = 11;
            // 
            // btnThemMonAn
            // 
            this.btnThemMonAn.Location = new System.Drawing.Point(440, 442);
            this.btnThemMonAn.Name = "btnThemMonAn";
            this.btnThemMonAn.Size = new System.Drawing.Size(155, 29);
            this.btnThemMonAn.TabIndex = 12;
            this.btnThemMonAn.Text = "Thêm Món Ăn";
            this.btnThemMonAn.UseVisualStyleBackColor = true;
            this.btnThemMonAn.Click += new System.EventHandler(this.btnThemMonAn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDocBan);
            this.groupBox1.Controls.Add(this.rdoKhongLoi);
            this.groupBox1.Controls.Add(this.rdoLoi);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Location = new System.Drawing.Point(623, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 160);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn theo lỗi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoKhongLoi
            // 
            this.rdoKhongLoi.AutoSize = true;
            this.rdoKhongLoi.Location = new System.Drawing.Point(18, 74);
            this.rdoKhongLoi.Name = "rdoKhongLoi";
            this.rdoKhongLoi.Size = new System.Drawing.Size(203, 25);
            this.rdoKhongLoi.TabIndex = 8;
            this.rdoKhongLoi.TabStop = true;
            this.rdoKhongLoi.Text = "Không lỗi,  Bình thường";
            this.rdoKhongLoi.UseVisualStyleBackColor = true;
            this.rdoKhongLoi.CheckedChanged += new System.EventHandler(this.rdoKhongLoi_CheckedChanged);
            // 
            // rdoLoi
            // 
            this.rdoLoi.AutoSize = true;
            this.rdoLoi.Location = new System.Drawing.Point(18, 27);
            this.rdoLoi.Name = "rdoLoi";
            this.rdoLoi.Size = new System.Drawing.Size(156, 25);
            this.rdoLoi.TabIndex = 7;
            this.rdoLoi.TabStop = true;
            this.rdoLoi.Text = "Lỗi Unrepeatable";
            this.rdoLoi.UseVisualStyleBackColor = true;
            // 
            // rdoDocBan
            // 
            this.rdoDocBan.AutoSize = true;
            this.rdoDocBan.Location = new System.Drawing.Point(18, 117);
            this.rdoDocBan.Name = "rdoDocBan";
            this.rdoDocBan.Size = new System.Drawing.Size(136, 25);
            this.rdoDocBan.TabIndex = 9;
            this.rdoDocBan.TabStop = true;
            this.rdoDocBan.Text = "Lỗi Dirty Read";
            this.rdoDocBan.UseVisualStyleBackColor = true;
            // 
            // DoiTac_ThucDoncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(976, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemMonAn);
            this.Controls.Add(this.txtMaThucDon);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.ckbCapNhat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgDSMonAn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "DoiTac_ThucDoncs";
            this.Text = "DoiTac_ThucDoncs";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSMonAn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dtgDSMonAn;
        private Label label2;
        private Button btnLuu;
        private Button btnHuy;
        private CheckBox ckbCapNhat;
        private Button btnQuayLai;
        private TextBox txtMaThucDon;
        private DataGridViewTextBoxColumn tenMonAn;
        private DataGridViewTextBoxColumn tinhTrang;
        private DataGridViewTextBoxColumn Gia;
        private DataGridViewTextBoxColumn luotLike;
        private Button btnThemMonAn;
        private GroupBox groupBox1;
        private RadioButton rdoKhongLoi;
        private RadioButton rdoLoi;
        private RadioButton rdoDocBan;
    }
}