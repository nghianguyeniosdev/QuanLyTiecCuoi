﻿namespace QuanLyTiecCuoiUI
{
    partial class frmQuanLySanh
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
            this.grpChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvQuanLySanh = new System.Windows.Forms.DataGridView();
            this.grpThongTinSanh = new System.Windows.Forms.GroupBox();
            this.txtSoLuongBanTD = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblSoLuongBanTD = new System.Windows.Forms.Label();
            this.lblDonGiaBanTT = new System.Windows.Forms.Label();
            this.lblLoaiSanh = new System.Windows.Forms.Label();
            this.lblTenSanh = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.cbbDonGiaBanTT = new System.Windows.Forms.ComboBox();
            this.cbbLoaiSanh = new System.Windows.Forms.ComboBox();
            this.txtTenSanh = new System.Windows.Forms.TextBox();
            this.grpDanhSachSanh = new System.Windows.Forms.GroupBox();
            this.grpChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLySanh)).BeginInit();
            this.grpThongTinSanh.SuspendLayout();
            this.grpDanhSachSanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChucNang
            // 
            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Controls.Add(this.btnHuy);
            this.grpChucNang.Controls.Add(this.btnLuu);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Location = new System.Drawing.Point(558, 14);
            this.grpChucNang.Name = "grpChucNang";
            this.grpChucNang.Size = new System.Drawing.Size(114, 207);
            this.grpChucNang.TabIndex = 30;
            this.grpChucNang.TabStop = false;
            this.grpChucNang.Text = "Chức năng";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Location = new System.Drawing.Point(7, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Location = new System.Drawing.Point(7, 59);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.Location = new System.Drawing.Point(7, 167);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 30);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.Location = new System.Drawing.Point(7, 131);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 30);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Location = new System.Drawing.Point(7, 95);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvQuanLySanh
            // 
            this.dgvQuanLySanh.AllowUserToAddRows = false;
            this.dgvQuanLySanh.AllowUserToDeleteRows = false;
            this.dgvQuanLySanh.AllowUserToResizeRows = false;
            this.dgvQuanLySanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLySanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLySanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuanLySanh.Location = new System.Drawing.Point(3, 19);
            this.dgvQuanLySanh.MultiSelect = false;
            this.dgvQuanLySanh.Name = "dgvQuanLySanh";
            this.dgvQuanLySanh.ReadOnly = true;
            this.dgvQuanLySanh.RowHeadersVisible = false;
            this.dgvQuanLySanh.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvQuanLySanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuanLySanh.Size = new System.Drawing.Size(654, 200);
            this.dgvQuanLySanh.TabIndex = 10;
            // 
            // grpThongTinSanh
            // 
            this.grpThongTinSanh.Controls.Add(this.txtSoLuongBanTD);
            this.grpThongTinSanh.Controls.Add(this.lblGhiChu);
            this.grpThongTinSanh.Controls.Add(this.lblSoLuongBanTD);
            this.grpThongTinSanh.Controls.Add(this.lblDonGiaBanTT);
            this.grpThongTinSanh.Controls.Add(this.lblLoaiSanh);
            this.grpThongTinSanh.Controls.Add(this.lblTenSanh);
            this.grpThongTinSanh.Controls.Add(this.txtGhiChu);
            this.grpThongTinSanh.Controls.Add(this.cbbDonGiaBanTT);
            this.grpThongTinSanh.Controls.Add(this.cbbLoaiSanh);
            this.grpThongTinSanh.Controls.Add(this.txtTenSanh);
            this.grpThongTinSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpThongTinSanh.Location = new System.Drawing.Point(12, 14);
            this.grpThongTinSanh.Name = "grpThongTinSanh";
            this.grpThongTinSanh.Size = new System.Drawing.Size(523, 207);
            this.grpThongTinSanh.TabIndex = 29;
            this.grpThongTinSanh.TabStop = false;
            this.grpThongTinSanh.Text = "Thông tin sảnh";
            // 
            // txtSoLuongBanTD
            // 
            this.txtSoLuongBanTD.Location = new System.Drawing.Point(174, 117);
            this.txtSoLuongBanTD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuongBanTD.Name = "txtSoLuongBanTD";
            this.txtSoLuongBanTD.Size = new System.Drawing.Size(342, 23);
            this.txtSoLuongBanTD.TabIndex = 3;
            this.txtSoLuongBanTD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongBanTD_KeyPress);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(7, 152);
            this.lblGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(57, 17);
            this.lblGhiChu.TabIndex = 39;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // lblSoLuongBanTD
            // 
            this.lblSoLuongBanTD.AutoSize = true;
            this.lblSoLuongBanTD.Location = new System.Drawing.Point(7, 120);
            this.lblSoLuongBanTD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoLuongBanTD.Name = "lblSoLuongBanTD";
            this.lblSoLuongBanTD.Size = new System.Drawing.Size(131, 17);
            this.lblSoLuongBanTD.TabIndex = 38;
            this.lblSoLuongBanTD.Text = "Số lượng bàn tối đa";
            // 
            // lblDonGiaBanTT
            // 
            this.lblDonGiaBanTT.AutoSize = true;
            this.lblDonGiaBanTT.Location = new System.Drawing.Point(7, 89);
            this.lblDonGiaBanTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonGiaBanTT.Name = "lblDonGiaBanTT";
            this.lblDonGiaBanTT.Size = new System.Drawing.Size(139, 17);
            this.lblDonGiaBanTT.TabIndex = 37;
            this.lblDonGiaBanTT.Text = "Đơn giá bàn tối thiểu";
            // 
            // lblLoaiSanh
            // 
            this.lblLoaiSanh.AutoSize = true;
            this.lblLoaiSanh.Location = new System.Drawing.Point(7, 57);
            this.lblLoaiSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiSanh.Name = "lblLoaiSanh";
            this.lblLoaiSanh.Size = new System.Drawing.Size(70, 17);
            this.lblLoaiSanh.TabIndex = 36;
            this.lblLoaiSanh.Text = "Loại sảnh";
            // 
            // lblTenSanh
            // 
            this.lblTenSanh.AutoSize = true;
            this.lblTenSanh.Location = new System.Drawing.Point(7, 26);
            this.lblTenSanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSanh.Name = "lblTenSanh";
            this.lblTenSanh.Size = new System.Drawing.Size(68, 17);
            this.lblTenSanh.TabIndex = 35;
            this.lblTenSanh.Text = "Tên sảnh";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(174, 149);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(342, 48);
            this.txtGhiChu.TabIndex = 4;
            // 
            // cbbDonGiaBanTT
            // 
            this.cbbDonGiaBanTT.FormattingEnabled = true;
            this.cbbDonGiaBanTT.Location = new System.Drawing.Point(174, 86);
            this.cbbDonGiaBanTT.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDonGiaBanTT.Name = "cbbDonGiaBanTT";
            this.cbbDonGiaBanTT.Size = new System.Drawing.Size(342, 24);
            this.cbbDonGiaBanTT.TabIndex = 2;
            this.cbbDonGiaBanTT.SelectedIndexChanged += new System.EventHandler(this.cbbDonGiaBanTT_SelectedIndexChanged);
            // 
            // cbbLoaiSanh
            // 
            this.cbbLoaiSanh.FormattingEnabled = true;
            this.cbbLoaiSanh.Location = new System.Drawing.Point(174, 54);
            this.cbbLoaiSanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiSanh.Name = "cbbLoaiSanh";
            this.cbbLoaiSanh.Size = new System.Drawing.Size(342, 24);
            this.cbbLoaiSanh.TabIndex = 1;
            this.cbbLoaiSanh.SelectedIndexChanged += new System.EventHandler(this.cbbLoaiSanh_SelectedIndexChanged);
            // 
            // txtTenSanh
            // 
            this.txtTenSanh.Location = new System.Drawing.Point(174, 23);
            this.txtTenSanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSanh.Name = "txtTenSanh";
            this.txtTenSanh.Size = new System.Drawing.Size(342, 23);
            this.txtTenSanh.TabIndex = 0;
            // 
            // grpDanhSachSanh
            // 
            this.grpDanhSachSanh.Controls.Add(this.dgvQuanLySanh);
            this.grpDanhSachSanh.Location = new System.Drawing.Point(12, 227);
            this.grpDanhSachSanh.Name = "grpDanhSachSanh";
            this.grpDanhSachSanh.Size = new System.Drawing.Size(660, 222);
            this.grpDanhSachSanh.TabIndex = 33;
            this.grpDanhSachSanh.TabStop = false;
            this.grpDanhSachSanh.Text = "Danh sách sảnh";
            // 
            // frmQuanLySanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.grpDanhSachSanh);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.grpThongTinSanh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "frmQuanLySanh";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SẢNH";
            this.Load += new System.EventHandler(this.frmQuanLySanh_Load);
            this.grpChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLySanh)).EndInit();
            this.grpThongTinSanh.ResumeLayout(false);
            this.grpThongTinSanh.PerformLayout();
            this.grpDanhSachSanh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvQuanLySanh;
        private System.Windows.Forms.GroupBox grpThongTinSanh;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.ComboBox cbbDonGiaBanTT;
        private System.Windows.Forms.ComboBox cbbLoaiSanh;
        private System.Windows.Forms.TextBox txtTenSanh;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblSoLuongBanTD;
        private System.Windows.Forms.Label lblDonGiaBanTT;
        private System.Windows.Forms.Label lblLoaiSanh;
        private System.Windows.Forms.Label lblTenSanh;
        private System.Windows.Forms.TextBox txtSoLuongBanTD;
        private System.Windows.Forms.GroupBox grpDanhSachSanh;


    }
}