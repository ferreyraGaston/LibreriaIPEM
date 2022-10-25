using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using CapaDatos;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using Entidades;

namespace Video_Club
{
    public partial class Usuario : Form
    {

        int posicion = 0;

        public Usuario()
        {
            InitializeComponent();
            CargarTablaUsuario();
            btn_registrar.Enabled = true;
            btn_registrar.BackColor = Color.FromArgb(169, 16, 121);
        }
        void CargarTablaUsuario()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select * from usuario";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panel2.Controls.Count > 0)  // pregunta si hay algun control en el interior del panel
                this.panel2.Controls.RemoveAt(0); // si hay algun control lo elimina o remueve
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;  // hace que se acople el formulario al contenedor
            this.panel2.Controls.Add(fh);  // agregamos el formulario al panel
            this.panel2.Tag = fh;  // establecemo la instancia como contenedor de dato al panel
            fh.Show();  // mostramos el formulario.
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsuarioClass usuarioObj = new UsuarioClass();
            posicion = dataGridView1.CurrentRow.Index;
            usuarioObj.Id1 = int.Parse(dataGridView1[0, posicion].Value.ToString());
            usuarioObj.Nombre1 = dataGridView1[1, posicion].Value.ToString();
            usuarioObj.Apellido1 = dataGridView1[2, posicion].Value.ToString();
            usuarioObj.Dni1 = int.Parse(dataGridView1[3, posicion].Value.ToString());
            usuarioObj.TipoUsuario1 = int.Parse(dataGridView1[4, posicion].Value.ToString());
            usuarioObj.Email1 = dataGridView1[5, posicion].Value.ToString();
            usuarioObj.Direccion1 = dataGridView1[6, posicion].Value.ToString();
            usuarioObj.Telefono1 = dataGridView1[7, posicion].Value.ToString();
            usuarioObj.Estado = true;
            //MessageBox.Show("nombre "+ usuarioObj.Nombre1);
            btn_registrar.Visible = false;
            panel6.Visible = false;
            panel3.Visible = false;
            dataGridView1.Visible = false;
            AbrirFormEnPanel(new UsuarioCrud());
        }
        private void btn_registrar_Click_1(object sender, EventArgs e)
        {     
            btn_registrar.Visible=false;
            panel6.Visible = false;
            panel3.Visible = false;
            dataGridView1.Visible = false;
            UsuarioClass usuarioObj = new UsuarioClass();
            usuarioObj.Id1 = 0;
            usuarioObj.Nombre1 = "";
            usuarioObj.Apellido1 = "";
            usuarioObj.Dni1 = 0;
            usuarioObj.TipoUsuario1 = 0;
            usuarioObj.Email1 = "";
            usuarioObj.Direccion1 = "";
            usuarioObj.Telefono1 = "";
            usuarioObj.Estado = false;
            AbrirFormEnPanel(new UsuarioCrud());
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "estadoUsuario")
            {
                if(Convert.ToInt32(e.Value)==1)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Red;
              
                }
                if (Convert.ToInt32(e.Value) == 0)
                {
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.BackColor = Color.Green;
                
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select * from usuario where usuario.id_usuario ='" + txtBuscar.Text + "' || usuario.NombreUsuario='" + txtBuscar.Text + "' || usuario.ApellidoUsuario='" + txtBuscar.Text + "' || usuario.DniUsuario='" + txtBuscar.Text + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtBuscar.Text = "";
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarTablaUsuario();
            txtBuscar.Text = "";
        }

        private void rbDisponible_CheckedChanged(object sender, EventArgs e)
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select * from usuario where usuario.estadoUsuario ='0';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtBuscar.Text = "";
        }

        private void rbNoDisponible_CheckedChanged(object sender, EventArgs e)
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select * from usuario where usuario.estadoUsuario ='1';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtBuscar.Text = "";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
