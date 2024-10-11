namespace ProjectDBMSWF
{
    partial class FXulydonhang
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.orderGridView = new System.Windows.Forms.DataGridView();
            this.detailProduct = new System.Windows.Forms.GroupBox();
            this.btn_huyProduct = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_giaTien = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.imageProduct = new System.Windows.Forms.PictureBox();
            this.grbox_thanhToan = new System.Windows.Forms.GroupBox();
            this.lbl_hoTen = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_capNhat = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_itemNumber = new System.Windows.Forms.Label();
            this.lbl_triGiaHoaDon = new System.Windows.Forms.Label();
            this.btn_addHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).BeginInit();
            this.detailProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).BeginInit();
            this.grbox_thanhToan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 25;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐƠN HÀNG CỦA BẠN";
            // 
            // orderGridView
            // 
            this.orderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGridView.Location = new System.Drawing.Point(5, 26);
            this.orderGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.orderGridView.Name = "orderGridView";
            this.orderGridView.RowHeadersWidth = 51;
            this.orderGridView.RowTemplate.Height = 24;
            this.orderGridView.Size = new System.Drawing.Size(518, 599);
            this.orderGridView.TabIndex = 1;
            // 
            // detailProduct
            // 
            this.detailProduct.BackColor = System.Drawing.SystemColors.ControlLight;
            this.detailProduct.Controls.Add(this.btn_capNhat);
            this.detailProduct.Controls.Add(this.btn_huyProduct);
            this.detailProduct.Controls.Add(this.label2);
            this.detailProduct.Controls.Add(this.lblSoLuong);
            this.detailProduct.Controls.Add(this.textBox1);
            this.detailProduct.Controls.Add(this.lbl_giaTien);
            this.detailProduct.Controls.Add(this.lbl_productName);
            this.detailProduct.Controls.Add(this.imageProduct);
            this.detailProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailProduct.Location = new System.Drawing.Point(576, 72);
            this.detailProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailProduct.Name = "detailProduct";
            this.detailProduct.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.detailProduct.Size = new System.Drawing.Size(524, 275);
            this.detailProduct.TabIndex = 2;
            this.detailProduct.TabStop = false;
            this.detailProduct.Text = "Chi tiết sản phẩm";
            this.detailProduct.Enter += new System.EventHandler(this.detailGroupBox_Enter);
            // 
            // btn_huyProduct
            // 
            this.btn_huyProduct.BorderRadius = 5;
            this.btn_huyProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_huyProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_huyProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_huyProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_huyProduct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_huyProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_huyProduct.ForeColor = System.Drawing.Color.White;
            this.btn_huyProduct.Location = new System.Drawing.Point(397, 228);
            this.btn_huyProduct.Name = "btn_huyProduct";
            this.btn_huyProduct.Size = new System.Drawing.Size(94, 30);
            this.btn_huyProduct.TabIndex = 9;
            this.btn_huyProduct.Text = "Xóa ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(235, 87);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(76, 20);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 84);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_giaTien
            // 
            this.lbl_giaTien.AutoSize = true;
            this.lbl_giaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giaTien.Location = new System.Drawing.Point(235, 55);
            this.lbl_giaTien.Name = "lbl_giaTien";
            this.lbl_giaTien.Size = new System.Drawing.Size(68, 20);
            this.lbl_giaTien.TabIndex = 6;
            this.lbl_giaTien.Text = "Đơn giá:";
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(235, 24);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(117, 20);
            this.lbl_productName.TabIndex = 3;
            this.lbl_productName.Text = "ProductName";
            // 
            // imageProduct
            // 
            this.imageProduct.Location = new System.Drawing.Point(13, 24);
            this.imageProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.imageProduct.Name = "imageProduct";
            this.imageProduct.Size = new System.Drawing.Size(217, 234);
            this.imageProduct.TabIndex = 0;
            this.imageProduct.TabStop = false;
            // 
            // grbox_thanhToan
            // 
            this.grbox_thanhToan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbox_thanhToan.Controls.Add(this.btn_addHoaDon);
            this.grbox_thanhToan.Controls.Add(this.label6);
            this.grbox_thanhToan.Controls.Add(this.textBox5);
            this.grbox_thanhToan.Controls.Add(this.textBox4);
            this.grbox_thanhToan.Controls.Add(this.textBox3);
            this.grbox_thanhToan.Controls.Add(this.textBox2);
            this.grbox_thanhToan.Controls.Add(this.lbl_triGiaHoaDon);
            this.grbox_thanhToan.Controls.Add(this.lbl_itemNumber);
            this.grbox_thanhToan.Controls.Add(this.label5);
            this.grbox_thanhToan.Controls.Add(this.label4);
            this.grbox_thanhToan.Controls.Add(this.label3);
            this.grbox_thanhToan.Controls.Add(this.lbl_hoTen);
            this.grbox_thanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_thanhToan.Location = new System.Drawing.Point(576, 352);
            this.grbox_thanhToan.Name = "grbox_thanhToan";
            this.grbox_thanhToan.Size = new System.Drawing.Size(524, 331);
            this.grbox_thanhToan.TabIndex = 3;
            this.grbox_thanhToan.TabStop = false;
            this.grbox_thanhToan.Text = "Thông tin thanh toán";
            // 
            // lbl_hoTen
            // 
            this.lbl_hoTen.AutoSize = true;
            this.lbl_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoTen.Location = new System.Drawing.Point(15, 38);
            this.lbl_hoTen.Name = "lbl_hoTen";
            this.lbl_hoTen.Size = new System.Drawing.Size(146, 20);
            this.lbl_hoTen.TabIndex = 7;
            this.lbl_hoTen.Text = "Họ tên Khách hàng";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 36);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 26);
            this.textBox2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số điện thoại";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 81);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(338, 26);
            this.textBox3.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(166, 126);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(338, 26);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(166, 171);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(338, 26);
            this.textBox5.TabIndex = 8;
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.BorderRadius = 5;
            this.btn_capNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_capNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_capNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_capNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_capNhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_capNhat.ForeColor = System.Drawing.Color.White;
            this.btn_capNhat.Location = new System.Drawing.Point(280, 228);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(94, 30);
            this.btn_capNhat.TabIndex = 9;
            this.btn_capNhat.Text = "Cập nhật";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 220);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(489, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "---------------";
            // 
            // lbl_itemNumber
            // 
            this.lbl_itemNumber.AutoSize = true;
            this.lbl_itemNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemNumber.Location = new System.Drawing.Point(15, 259);
            this.lbl_itemNumber.Name = "lbl_itemNumber";
            this.lbl_itemNumber.Size = new System.Drawing.Size(108, 20);
            this.lbl_itemNumber.TabIndex = 7;
            this.lbl_itemNumber.Text = "Số món hàng:";
            // 
            // lbl_triGiaHoaDon
            // 
            this.lbl_triGiaHoaDon.AutoSize = true;
            this.lbl_triGiaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_triGiaHoaDon.Location = new System.Drawing.Point(15, 294);
            this.lbl_triGiaHoaDon.Name = "lbl_triGiaHoaDon";
            this.lbl_triGiaHoaDon.Size = new System.Drawing.Size(133, 20);
            this.lbl_triGiaHoaDon.TabIndex = 7;
            this.lbl_triGiaHoaDon.Text = "Giá trị hóa đơn:";
            // 
            // btn_addHoaDon
            // 
            this.btn_addHoaDon.BorderRadius = 5;
            this.btn_addHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_addHoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_addHoaDon.Location = new System.Drawing.Point(369, 284);
            this.btn_addHoaDon.Name = "btn_addHoaDon";
            this.btn_addHoaDon.Size = new System.Drawing.Size(149, 30);
            this.btn_addHoaDon.TabIndex = 10;
            this.btn_addHoaDon.Text = "Xuất hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 630);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // FXulydonhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1111, 720);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbox_thanhToan);
            this.Controls.Add(this.detailProduct);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FXulydonhang";
            this.Text = "FXulydonhang";
            ((System.ComponentModel.ISupportInitialize)(this.orderGridView)).EndInit();
            this.detailProduct.ResumeLayout(false);
            this.detailProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduct)).EndInit();
            this.grbox_thanhToan.ResumeLayout(false);
            this.grbox_thanhToan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderGridView;
        private System.Windows.Forms.GroupBox detailProduct;
        private System.Windows.Forms.PictureBox imageProduct;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_giaTien;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_huyProduct;
        private System.Windows.Forms.GroupBox grbox_thanhToan;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_hoTen;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btn_capNhat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_itemNumber;
        private Guna.UI2.WinForms.Guna2Button btn_addHoaDon;
        private System.Windows.Forms.Label lbl_triGiaHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}