using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDBMSWF
{
    public partial class UCChamCong : UserControl
    {
       private  string maNV;
        public UCChamCong()
        {
            InitializeComponent();
        }
        public void LoadCaLamViec(DataTable dataTable, string maNV)
        {
            this.maNV = maNV;
            if (dataTable.Rows.Count > 0)
            {
                // Lấy dữ liệu từ dòng đầu tiên
                DataRow row = dataTable.Rows[0];

                // Cập nhật các TextBox
                lb_maCa.Text += row["MaCa"].ToString();
                lb_TenCa.Text += row["TenCa"].ToString();
                lb_ngay.Text += Convert.ToDateTime(row["Ngay"]).ToString("dd-MM-yyyy"); // Định dạng ngày nếu cần
                lb_batDau.Text += row["ThoiGianBD"].ToString();
                lb_KetThuc.Text += row["ThoiGianKT"].ToString();
            }
        }

        private void btn_chamCong_Click(object sender, EventArgs e)
        {
           string maNhanVien =maNV ;
            string maCa = lb_maCa.Text;
            NhanVienDAO.chamCong(maNV, maCa);
        }
    }
}
