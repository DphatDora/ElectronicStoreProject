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
    public partial class FNhanvien : Form
    {

        public FNhanvien()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        public void OpenForm(Form form)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            PanelContain.Controls.Add(form);
            PanelContain.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void btnLichsu_Click(object sender, EventArgs e)
        {
            OpenForm(new FLichSuDonHang());
        }

        private void btnLinhkien_Click(object sender, EventArgs e)
        {
            OpenForm(new FLinhKien());
        }

        private void btnChamcong_Click(object sender, EventArgs e)
        {
            OpenForm(new FChamCong());
        }

        private void btnXuly_Click(object sender, EventArgs e)
        {
            OpenForm(new FXulydonhang());
        }

        private void btnDoanhthu_Click(object sender, EventArgs e)
        {
            OpenForm(new FDoanhThuCa());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
