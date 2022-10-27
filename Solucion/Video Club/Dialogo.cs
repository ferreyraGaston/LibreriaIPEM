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
    public partial class Dialogo : Form
    {
        public Dialogo()
        {
            InitializeComponent();
            icon_delay.Start(); 
            label_delay.Start();
            icon.Enabled= true; 
        }
        private void icon_delay_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            icon_delay.Stop();
            btnOk.Visible= true;   
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label_delay_Tick(object sender, EventArgs e)
        {
            label_delay.Stop();
            lbDialog.Visible= true;
        }

        private void lbDialog_Click(object sender, EventArgs e)
        {

        }
    }
}
