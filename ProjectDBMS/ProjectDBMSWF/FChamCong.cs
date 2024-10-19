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
    public partial class FChamCong : Form
    {
        public FChamCong()
        {
            InitializeComponent();
        }

        private void FChamCong_Load(object sender, EventArgs e)
        {
            DataTable dt = NhanVienDAO.GetCaLamViec(FNhanvien.maNV);
            if (dt.Rows.Count>0)
            {
                UCChamCong uc = new UCChamCong();
                uc.LoadCaLamViec(dt,FNhanvien.maNV);
              
            }
            else
            {
                lb_ChamCong.Text = "Bạn đã châm công cho phân ca rồi";
                lb_ChamCong.Visible = true;
            }
            FNhanvien.lb_ngayLamViec.Text= Convert.ToDateTime(dt.Rows[0]["Ngay"]).ToString("dd-MM-yyyy");
            FNhanvien.lb_ngayLamViec.Visible = true;

        }
    }
}
