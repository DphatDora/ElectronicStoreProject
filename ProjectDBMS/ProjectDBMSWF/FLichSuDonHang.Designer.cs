namespace ProjectDBMSWF
{
    partial class FLichSuDonHang
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
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txb_tenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateHD = new System.Windows.Forms.DateTimePicker();
            this.cbtn_timTheoGia = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cbtn_timTheoNgay = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txb_maxValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.txb_minValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.danhSachHD_gridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chiTietHD_gridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachHD_gridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHD_gridView)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lịch Sử Đơn Hàng";
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 25;
            // 
            // txb_tenKH
            // 
            this.txb_tenKH.BorderRadius = 5;
            this.txb_tenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_tenKH.DefaultText = "";
            this.txb_tenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_tenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_tenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_tenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_tenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_tenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_tenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_tenKH.Location = new System.Drawing.Point(15, 59);
            this.txb_tenKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_tenKH.Name = "txb_tenKH";
            this.txb_tenKH.PasswordChar = '\0';
            this.txb_tenKH.PlaceholderText = "Nhập tên khách hàng";
            this.txb_tenKH.SelectedText = "";
            this.txb_tenKH.Size = new System.Drawing.Size(449, 44);
            this.txb_tenKH.TabIndex = 3;
            this.txb_tenKH.TextChanged += new System.EventHandler(this.txb_tenKH_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.dateHD);
            this.groupBox1.Controls.Add(this.cbtn_timTheoGia);
            this.groupBox1.Controls.Add(this.cbtn_timTheoNgay);
            this.groupBox1.Controls.Add(this.txb_maxValue);
            this.groupBox1.Controls.Add(this.txb_minValue);
            this.groupBox1.Controls.Add(this.txb_tenKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 463);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(472, 354);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm đơn hàng";
            // 
            // dateHD
            // 
            this.dateHD.Location = new System.Drawing.Point(15, 284);
            this.dateHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateHD.Name = "dateHD";
            this.dateHD.Size = new System.Drawing.Size(359, 26);
            this.dateHD.TabIndex = 5;
            // 
            // cbtn_timTheoGia
            // 
            this.cbtn_timTheoGia.AutoSize = true;
            this.cbtn_timTheoGia.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtn_timTheoGia.CheckedState.BorderRadius = 0;
            this.cbtn_timTheoGia.CheckedState.BorderThickness = 0;
            this.cbtn_timTheoGia.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtn_timTheoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtn_timTheoGia.Location = new System.Drawing.Point(15, 219);
            this.cbtn_timTheoGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbtn_timTheoGia.Name = "cbtn_timTheoGia";
            this.cbtn_timTheoGia.Size = new System.Drawing.Size(178, 24);
            this.cbtn_timTheoGia.TabIndex = 7;
            this.cbtn_timTheoGia.Text = "Tìm theo giá trị HĐ:";
            this.cbtn_timTheoGia.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbtn_timTheoGia.UncheckedState.BorderRadius = 0;
            this.cbtn_timTheoGia.UncheckedState.BorderThickness = 0;
            this.cbtn_timTheoGia.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbtn_timTheoGia.CheckedChanged += new System.EventHandler(this.cbtn_timTheoGia_CheckedChanged);
            // 
            // cbtn_timTheoNgay
            // 
            this.cbtn_timTheoNgay.AutoSize = true;
            this.cbtn_timTheoNgay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtn_timTheoNgay.CheckedState.BorderRadius = 0;
            this.cbtn_timTheoNgay.CheckedState.BorderThickness = 0;
            this.cbtn_timTheoNgay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbtn_timTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtn_timTheoNgay.Location = new System.Drawing.Point(15, 319);
            this.cbtn_timTheoNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbtn_timTheoNgay.Name = "cbtn_timTheoNgay";
            this.cbtn_timTheoNgay.Size = new System.Drawing.Size(136, 24);
            this.cbtn_timTheoNgay.TabIndex = 7;
            this.cbtn_timTheoNgay.Text = "Tìm theo ngày";
            this.cbtn_timTheoNgay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbtn_timTheoNgay.UncheckedState.BorderRadius = 0;
            this.cbtn_timTheoNgay.UncheckedState.BorderThickness = 0;
            this.cbtn_timTheoNgay.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbtn_timTheoNgay.CheckedChanged += new System.EventHandler(this.cbtn_timTheoNgay_CheckedChanged);
            // 
            // txb_maxValue
            // 
            this.txb_maxValue.BorderRadius = 5;
            this.txb_maxValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_maxValue.DefaultText = "";
            this.txb_maxValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_maxValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_maxValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maxValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_maxValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maxValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_maxValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_maxValue.Location = new System.Drawing.Point(249, 169);
            this.txb_maxValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_maxValue.Name = "txb_maxValue";
            this.txb_maxValue.PasswordChar = '\0';
            this.txb_maxValue.PlaceholderText = "Giá trị cao nhất";
            this.txb_maxValue.SelectedText = "";
            this.txb_maxValue.Size = new System.Drawing.Size(215, 43);
            this.txb_maxValue.TabIndex = 0;
            // 
            // txb_minValue
            // 
            this.txb_minValue.BorderRadius = 5;
            this.txb_minValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txb_minValue.DefaultText = "";
            this.txb_minValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txb_minValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txb_minValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_minValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txb_minValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_minValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txb_minValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txb_minValue.Location = new System.Drawing.Point(15, 169);
            this.txb_minValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_minValue.Name = "txb_minValue";
            this.txb_minValue.PasswordChar = '\0';
            this.txb_minValue.PlaceholderText = "Giá trị thấp nhất";
            this.txb_minValue.SelectedText = "";
            this.txb_minValue.Size = new System.Drawing.Size(215, 43);
            this.txb_minValue.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.danhSachHD_gridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(515, 463);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(951, 354);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn:";
            // 
            // danhSachHD_gridView
            // 
            this.danhSachHD_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachHD_gridView.Location = new System.Drawing.Point(8, 27);
            this.danhSachHD_gridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.danhSachHD_gridView.Name = "danhSachHD_gridView";
            this.danhSachHD_gridView.RowHeadersWidth = 51;
            this.danhSachHD_gridView.Size = new System.Drawing.Size(935, 320);
            this.danhSachHD_gridView.TabIndex = 0;
            this.danhSachHD_gridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachHD_gridView_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.chiTietHD_gridView);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 71);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(1431, 384);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn:";
            // 
            // chiTietHD_gridView
            // 
            this.chiTietHD_gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chiTietHD_gridView.Location = new System.Drawing.Point(15, 26);
            this.chiTietHD_gridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chiTietHD_gridView.Name = "chiTietHD_gridView";
            this.chiTietHD_gridView.RowHeadersWidth = 51;
            this.chiTietHD_gridView.Size = new System.Drawing.Size(1400, 351);
            this.chiTietHD_gridView.TabIndex = 1;
            // 
            // FLichSuDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1481, 886);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FLichSuDonHang";
            this.Text = "FLichSuDonHang";
            this.Load += new System.EventHandler(this.FLichSuDonHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachHD_gridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chiTietHD_gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox txb_tenKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txb_maxValue;
        private Guna.UI2.WinForms.Guna2TextBox txb_minValue;
        private System.Windows.Forms.DateTimePicker dateHD;
        private Guna.UI2.WinForms.Guna2CheckBox cbtn_timTheoNgay;
        private Guna.UI2.WinForms.Guna2CheckBox cbtn_timTheoGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView chiTietHD_gridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView danhSachHD_gridView;
    }
}