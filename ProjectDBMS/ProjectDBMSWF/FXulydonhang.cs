﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;
using System.IO;

namespace ProjectDBMSWF
{
    public partial class FXulydonhang : Form
    {
        public FXulydonhang()
        {
            InitializeComponent();
        }

        private void detailGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadListOrder()
        {
            orderGridView.DataSource = FNhanvien.bindingList;
           
            lbl_maLK.DataBindings.Add("Text", orderGridView.DataSource, "MaLK");
            lbl_productName.DataBindings.Add("Text", orderGridView.DataSource, "TenLk");
            txb_soLuong.DataBindings.Add("Text", orderGridView.DataSource, "SoLuong");
            lbl_giaTien.DataBindings.Add("Text", orderGridView.DataSource, "DonGia");
            lbl_tongTien.DataBindings.Add("Text", orderGridView.DataSource, "TongTien");
            imageProduct.DataBindings.Add("Image", orderGridView.DataSource, "AnhLK");
            lbl_itemNumber.Text = FNhanvien.listOrder.Count().ToString();
            lbl_triGiaHoaDon.Text = FNhanvien.listOrder.Sum(i => i.TongTien).ToString();
        }
        private void FXulydonhang_Load(object sender, EventArgs e)
        {
            orderGridView.DataSource = null;
            loadListOrder();
        }

        private void btn_capNhat_Click(object sender, EventArgs e)
        {
            orderGridView.DataSource = null;
            OrderItem order = new OrderItem(lbl_maLK.Text, lbl_productName.Text, int.Parse(txb_soLuong.Text), float.Parse(lbl_giaTien.Text), imageProduct.Image);
            FNhanvien.AddOrderItem(order);
            loadListOrder();
        }

        private void btn_huyProduct_Click(object sender, EventArgs e)
        {
            orderGridView.DataSource = null;
            OrderItem order = new OrderItem(lbl_maLK.Text, lbl_productName.Text, int.Parse(txb_soLuong.Text), float.Parse(lbl_giaTien.Text), imageProduct.Image);
            FNhanvien.RemoveOrderItem(lbl_maLK.Text);
            loadListOrder();
        }

        private void btn_addHoaDon_Click(object sender, EventArgs e)
        {
            NhanVienDAO.saveInfoKH(txb_hoten.Text, txb_sdt.Text, txb_email.Text, txb_diachi.Text);
            DateTime ngayXuatHD;

            if (DateTime.TryParse(FNhanvien.ngayLamViec, out ngayXuatHD))
            {
                string maKH = "KH" + txb_sdt.Text;
                NhanVienDAO.xuatHoaDon(ngayXuatHD, float.Parse(lbl_triGiaHoaDon.Text), maKH, FNhanvien.maNV);
            }
            else
            {              
                MessageBox.Show("Ngày không hợp lệ.");
            }
           
        }
    }
}
