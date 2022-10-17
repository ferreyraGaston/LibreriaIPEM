using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;

namespace Video_Club
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PicSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PicMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            PicMax.Visible = false;
            PicRestaurar.Visible = true;
        }

        private void PicMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }

        private void PicRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            PicMax.Visible = true;
            PicRestaurar.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            Panel_SubMenu.Visible = true;
        }

        private void btn_RepVentas_Click(object sender, EventArgs e)
        {
            Panel_SubMenu.Visible = false;
            AbrirFormEnPanel(new RepVentas());

        }

        private void btn_RepALquiler_Click(object sender, EventArgs e)
        {
            Panel_SubMenu.Visible = false;
            AbrirFormEnPanel(new RepAlquiler());
        }

        private void btn_RepPagos_Click(object sender, EventArgs e)
        {
            Panel_SubMenu.Visible = false;
            AbrirFormEnPanel(new RepPagos());
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.PanelSalir.Controls.Count > 0)  // pregunta si hay algun control en el interior del panel
                this.PanelSalir.Controls.RemoveAt(0); // si hay algun control lo elimina o remueve
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;  // hace que se acople el formulario al contenedor
            this.PanelSalir.Controls.Add(fh);  // agregamos el formulario al panel
            this.PanelSalir.Tag = fh;  // establecemo la instancia como contenedor de dato al panel
            fh.Show();  // mostramos el formulario.

        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ventas());


        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new clientes());

           

        }

        private void btn_Socios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new socios());
        }

        private void btn_Compras_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new compras());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            string cadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\\BD Toldito\\Prueba\\BD\\BD_Bibloteca_V1.mdb";
            OleDbConnection conexion = new OleDbConnection(cadenaConexion);

            try
            {
                conexion.Open();
                MessageBox.Show("Conexión Exitosa");
                // btnSalir.Visible = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Conexión fallida");
            }
            conexion.Close();
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
