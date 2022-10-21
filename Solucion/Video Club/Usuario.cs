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
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_nuevo.Enabled = false;
            btn_registrar.Enabled = true;
        
            btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
            btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
            btn_nuevo.BackColor = Color.FromArgb(87, 10, 87);
            btn_registrar.BackColor = Color.FromArgb(169, 16, 121);
            
   
        }

        private void clientes_Load(object sender, EventArgs e)
        {

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
            usuarioObj.Id = int.Parse(dataGridView1[0, posicion].Value.ToString());
            usuarioObj.Nombre = dataGridView1[1, posicion].Value.ToString();
            usuarioObj.Apellido = dataGridView1[2, posicion].Value.ToString();
            usuarioObj.Dni = int.Parse(dataGridView1[3, posicion].Value.ToString());
            usuarioObj.TipoUsuario = int.Parse(dataGridView1[4, posicion].Value.ToString());
            usuarioObj.Email = dataGridView1[5, posicion].Value.ToString();
            usuarioObj.Direccion = dataGridView1[6, posicion].Value.ToString();
            usuarioObj.Telefono = dataGridView1[7, posicion].Value.ToString();
         
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            btn_registrar.Enabled = false;
            btn_nuevo.Enabled = true;

            btn_eliminar.BackColor = Color.FromArgb(169, 16, 121);
            btn_modificar.BackColor = Color.FromArgb(169, 16, 121);
            btn_registrar.BackColor = Color.FromArgb(87, 10, 87);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            AbrirFormEnPanel(new UsuarioCrud());
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
            dataGridView1.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn_registrar_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new UsuarioCrud());
        }
    }
}
