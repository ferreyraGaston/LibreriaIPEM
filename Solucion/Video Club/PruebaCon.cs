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
    public partial class PruebaCon : Form
    {
        public PruebaCon()
        {
            InitializeComponent();
            icon_delay.Start();
            label_delay.Start();
            icon1.Visible = true;
            icon1.Enabled = true;
            icon2.Visible= false;
            icon2.Enabled = false;
        }

        private void PruebaCon_Load(object sender, EventArgs e)
        {

        }

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            icon1.Visible = false;
            icon1.Enabled = false;
            icon2.Visible = true;
            icon2.Enabled = true;
            icon_delay.Stop();
            btnOk.Visible = true;
        }

        private void label_delay_Tick(object sender, EventArgs e)
        {
            label_delay.Stop();
            lbDialog.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
