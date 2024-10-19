using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDBMSWF
{
    public partial class FLinhKien : Form
    {
        public FLinhKien()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FLinhKien_Load(object sender, EventArgs e)
        {
            listProduct_gridView.DataSource = NhanVienDAO.listProduct();

            lbl_maLK.DataBindings.Add("Text", listProduct_gridView.DataSource, "MaLK");
            lbl_tenLK.DataBindings.Add("Text", listProduct_gridView.DataSource, "TenLK");
            lbl_nhomLK.DataBindings.Add("Text", listProduct_gridView.DataSource, "TenNhom");
            lbl_moTa.DataBindings.Add("Text", listProduct_gridView.DataSource, "MoTa");
            lbl_giaTien.DataBindings.Add("Text", listProduct_gridView.DataSource, "GiaTien");
            lbl_soLuong.DataBindings.Add("Text", listProduct_gridView.DataSource, "SoLuong");
            // load ảnh sản phẩm
            Binding imageBinding = new Binding("Image", listProduct_gridView.DataSource, "AnhLK");
            imageBinding.Format += new ConvertEventHandler(DataConnector.ImageFormat);
            productImage.DataBindings.Add(imageBinding);
        }

        private void txb_search_TextChanged(object sender, EventArgs e)
        {
            string tenLK = txb_search.Text;
            listProduct_gridView.DataSource = NhanVienDAO.getProductByName(tenLK);

            lbl_maLK.DataBindings.Add("Text", listProduct_gridView.DataSource, "MaLK");
            lbl_tenLK.DataBindings.Add("Text", listProduct_gridView.DataSource, "TenLK");
            lbl_nhomLK.DataBindings.Add("Text", listProduct_gridView.DataSource, "TenNhom");
            lbl_moTa.DataBindings.Add("Text", listProduct_gridView.DataSource, "MoTa");
            lbl_giaTien.DataBindings.Add("Text", listProduct_gridView.DataSource, "GiaTien");
            lbl_soLuong.DataBindings.Add("Text", listProduct_gridView.DataSource, "SoLuong");
            // load ảnh sản phẩm
            Binding imageBinding = new Binding("Image", listProduct_gridView.DataSource, "AnhLK");
            imageBinding.Format += new ConvertEventHandler(DataConnector.ImageFormat);
            productImage.DataBindings.Add(imageBinding);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string tenNhom = box_nhomLk.SelectedItem?.ToString();
            string gia = box_gia.SelectedItem?.ToString();
            string trangThai = box_trangThai.SelectedItem?.ToString();

            listProduct_gridView.DataSource = NhanVienDAO.getProductByFilter(tenNhom, gia, trangThai);

            lbl_maLK.DataBindings.Add("Text", listProduct_gridView.DataSource, "MaLK");
            lbl_tenLK.DataBindings.Add("Text", listProduct_gridView.DataSource, "TenLK");
            lbl_nhomLK.DataBindings.Add("Text", listProduct_gridView.DataSource, "TenNhom");
            lbl_moTa.DataBindings.Add("Text", listProduct_gridView.DataSource, "MoTa");
            lbl_giaTien.DataBindings.Add("Text", listProduct_gridView.DataSource, "GiaTien");
            lbl_soLuong.DataBindings.Add("Text", listProduct_gridView.DataSource, "SoLuong");
            // load ảnh sản phẩm
            Binding imageBinding = new Binding("Image", listProduct_gridView.DataSource, "AnhLK");
            imageBinding.Format += new ConvertEventHandler(DataConnector.ImageFormat);
            productImage.DataBindings.Add(imageBinding);
        }

        private void btn_addToOrder_Click(object sender, EventArgs e)
        {
            // thêm vào đơn hàng 1 sản phẩm
            OrderItem order = new OrderItem(lbl_maLK.Text, lbl_tenLK.Text, 1, float.Parse(lbl_giaTien.Text), productImage.Image);
            FNhanvien.AddOrderItem(order);
            /*
            try
            {
                OrderItem order1 = new OrderItem("LK001", "Bánh Pizza", 2, 14000, Image.FromFile("C:\\Users\\PC\\OneDrive\\Tài liệu\\Hình ảnh\\arrow.png"));
                OrderItem order2 = new OrderItem("LK002", "Bánh Kem", 4, 32000, Image.FromFile("C:\\Users\\PC\\OneDrive\\Tài liệu\\Hình ảnh\\arrow.png"));
                FNhanvien.AddOrderItem(order1);
                FNhanvien.AddOrderItem(order2);
                MessageBox.Show("Thêm thành công");
            }
            catch(Exception ex)
            {

            MessageBox.Show(ex.Message); }
            */
        }
    }
}
