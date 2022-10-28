using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Club
{
    public partial class PruebaNoCon : Form
    {
        public PruebaNoCon()
        {
            InitializeComponent();
            icon_delay.Start();

            icon1.Visible = true;
            icon1.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            icon_delay.Stop();
            icon1.Visible = false;
            icon1.Enabled = false;

            label_delay.Start();
            icon2.Enabled = true;
            lbDialog.Visible = true;
        }

        private void label_delay_Tick(object sender, EventArgs e)
        {
            label_delay.Stop();
            icon2.Enabled = false;
            btnOk.Visible = true;
        }
    }
}
