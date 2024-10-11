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
            UClinhkien uClinhkien1 = new UClinhkien();
            UClinhkien uClinhkien2 = new UClinhkien();
            UClinhkien uClinhkien3 = new UClinhkien();
            panel_Product.Controls.Add(uClinhkien1);
            panel_Product.Controls.Add(uClinhkien2);
            panel_Product.Controls.Add(uClinhkien3);
        }
    }
}
