﻿namespace ProjectDBMSWF
{
    partial class FLinhKien
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
            this.components = new System.ComponentModel.Container();
            this.btn_addToOrder = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_giaTien = new System.Windows.Forms.Label();
            this.lbl_moTa = new System.Windows.Forms.Label();
            this.lbl_soLuong = new System.Windows.Forms.Label();
            this.lbl_nhomLK = new System.Windows.Forms.Label();
            this.lbl_tenLK = new System.Windows.Forms.Label();
            this.productImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.box_nhomLk = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_gia = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.box_trangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txb_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listProduct_gridView = new System.Windows.Forms.DataGridView();
            this.lbl_maLK = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listProduct_gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addToOrder
            // 
            this.btn_addToOrder.BorderRadius = 5;
            this.btn_addToOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addToOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addToOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addToOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addToOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addToOrder.ForeColor = System.Drawing.Color.White;
            this.btn_addToOrder.Location = new System.Drawing.Point(1025, 773);
            this.btn_addToOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addToOrder.Name = "btn_addToOrder";
            this.btn_addToOrder.Size = new System.Drawing.Size(283, 46);
            this.btn_addToOrder.TabIndex = 6;
            this.btn_addToOrder.Text = "Thêm vào đơn hàng";
            this.btn_addToOrder.Click += new System.EventHandler(this.btn_addToOrder_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.lbl_giaTien);
            this.guna2Panel1.Controls.Add(this.lbl_moTa);
            this.guna2Panel1.Controls.Add(this.lbl_soLuong);
            this.guna2Panel1.Controls.Add(this.lbl_nhomLK);
            this.guna2Panel1.Controls.Add(this.lbl_maLK);
            this.guna2Panel1.Controls.Add(this.lbl_tenLK);
            this.guna2Panel1.Controls.Add(this.productImage);
            this.guna2Panel1.Location = new System.Drawing.Point(826, 100);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(641, 647);
            this.guna2Panel1.TabIndex = 8;
            // 
            // lbl_giaTien
            // 
            this.lbl_giaTien.AutoSize = true;
            this.lbl_giaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giaTien.Location = new System.Drawing.Point(48, 597);
            this.lbl_giaTien.Name = "lbl_giaTien";
            this.lbl_giaTien.Size = new System.Drawing.Size(77, 20);
            this.lbl_giaTien.TabIndex = 1;
            this.lbl_giaTien.Text = "Giá tiền:";
            // 
            // lbl_moTa
            // 
            this.lbl_moTa.AutoSize = true;
            this.lbl_moTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_moTa.Location = new System.Drawing.Point(48, 493);
            this.lbl_moTa.Name = "lbl_moTa";
            this.lbl_moTa.Size = new System.Drawing.Size(49, 20);
            this.lbl_moTa.TabIndex = 1;
            this.lbl_moTa.Text = "mô tả";
            // 
            // lbl_soLuong
            // 
            this.lbl_soLuong.AutoSize = true;
            this.lbl_soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soLuong.Location = new System.Drawing.Point(308, 456);
            this.lbl_soLuong.Name = "lbl_soLuong";
            this.lbl_soLuong.Size = new System.Drawing.Size(76, 20);
            this.lbl_soLuong.TabIndex = 1;
            this.lbl_soLuong.Text = "Số lượng:";
            // 
            // lbl_nhomLK
            // 
            this.lbl_nhomLK.AutoSize = true;
            this.lbl_nhomLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhomLK.Location = new System.Drawing.Point(48, 456);
            this.lbl_nhomLK.Name = "lbl_nhomLK";
            this.lbl_nhomLK.Size = new System.Drawing.Size(49, 20);
            this.lbl_nhomLK.TabIndex = 1;
            this.lbl_nhomLK.Text = "nhóm";
            // 
            // lbl_tenLK
            // 
            this.lbl_tenLK.AutoSize = true;
            this.lbl_tenLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenLK.Location = new System.Drawing.Point(48, 422);
            this.lbl_tenLK.Name = "lbl_tenLK";
            this.lbl_tenLK.Size = new System.Drawing.Size(49, 20);
            this.lbl_tenLK.TabIndex = 1;
            this.lbl_tenLK.Text = "name";
            // 
            // productImage
            // 
            this.productImage.ImageRotate = 0F;
            this.productImage.Location = new System.Drawing.Point(23, 23);
            this.productImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(592, 331);
            this.productImage.TabIndex = 0;
            this.productImage.TabStop = false;
            // 
            // box_nhomLk
            // 
            this.box_nhomLk.BackColor = System.Drawing.Color.Transparent;
            this.box_nhomLk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_nhomLk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_nhomLk.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_nhomLk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_nhomLk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.box_nhomLk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.box_nhomLk.ItemHeight = 30;
            this.box_nhomLk.Location = new System.Drawing.Point(516, 25);
            this.box_nhomLk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_nhomLk.Name = "box_nhomLk";
            this.box_nhomLk.Size = new System.Drawing.Size(140, 36);
            this.box_nhomLk.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhóm";
            // 
            // box_gia
            // 
            this.box_gia.BackColor = System.Drawing.Color.Transparent;
            this.box_gia.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_gia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_gia.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_gia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_gia.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.box_gia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.box_gia.ItemHeight = 30;
            this.box_gia.Location = new System.Drawing.Point(780, 25);
            this.box_gia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_gia.Name = "box_gia";
            this.box_gia.Size = new System.Drawing.Size(140, 36);
            this.box_gia.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(737, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Giá";
            // 
            // box_trangThai
            // 
            this.box_trangThai.BackColor = System.Drawing.Color.Transparent;
            this.box_trangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.box_trangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_trangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_trangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.box_trangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.box_trangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.box_trangThai.ItemHeight = 30;
            this.box_trangThai.Location = new System.Drawing.Point(1068, 25);
            this.box_trangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_trangThai.Name = "box_trangThai";
            this.box_trangThai.Size = new System.Drawing.Size(140, 36);
            this.box_trangThai.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(973, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Trạng thái";
            // 
            // btn_search
            // 
            this.btn_search.BorderRadius = 5;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(1335, 25);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(132, 44);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txb_search
            // 
            this.txb_search.BackgroundImage = global::ProjectDBMSWF.Properties.Resources.magnifying_glass;
            this.txb_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txb_search.BorderRadius = 5;
            this.txb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_search.DefaultText = "";
            this.txb_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_search.Location = new System.Drawing.Point(27, 25);
            this.txb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_search.Name = "txb_search";
            this.txb_search.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_search.PasswordChar = '\0';
            this.txb_search.PlaceholderText = "nhập tên sản phẩm";
            this.txb_search.SelectedText = "";
            this.txb_search.Size = new System.Drawing.Size(373, 36);
            this.txb_search.TabIndex = 0;
            this.txb_search.TextChanged += new System.EventHandler(this.txb_search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listProduct_gridView);
            this.groupBox1.Location = new System.Drawing.Point(27, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 757);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // listProduct_gridView
            // 
            this.listProduct_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listProduct_gridView.Location = new System.Drawing.Point(6, 21);
            this.listProduct_gridView.Name = "listProduct_gridView";
            this.listProduct_gridView.RowTemplate.Height = 24;
            this.listProduct_gridView.Size = new System.Drawing.Size(773, 730);
            this.listProduct_gridView.TabIndex = 0;
            // 
            // lbl_maLK
            // 
            this.lbl_maLK.AutoSize = true;
            this.lbl_maLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maLK.Location = new System.Drawing.Point(48, 388);
            this.lbl_maLK.Name = "lbl_maLK";
            this.lbl_maLK.Size = new System.Drawing.Size(96, 20);
            this.lbl_maLK.TabIndex = 1;
            this.lbl_maLK.Text = "Mã linh kiện:";
            // 
            // FLinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1481, 886);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_trangThai);
            this.Controls.Add(this.box_gia);
            this.Controls.Add(this.box_nhomLk);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_addToOrder);
            this.Controls.Add(this.txb_search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FLinhKien";
            this.Text = "FLinhKien";
            this.Load += new System.EventHandler(this.FLinhKien_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listProduct_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txb_search;
        private Guna.UI2.WinForms.Guna2Button btn_addToOrder;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox box_nhomLk;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox box_gia;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox box_trangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_giaTien;
        private System.Windows.Forms.Label lbl_moTa;
        private System.Windows.Forms.Label lbl_nhomLK;
        private System.Windows.Forms.Label lbl_tenLK;
        private Guna.UI2.WinForms.Guna2PictureBox productImage;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView listProduct_gridView;
        private System.Windows.Forms.Label lbl_soLuong;
        private System.Windows.Forms.Label lbl_maLK;
    }
}