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

namespace Video_Club
{
    public partial class Usuario : Form
    {
       // int i = 1;
        int posicion = 0;
        string Id = "";
        public Usuario()
        {
            InitializeComponent();
            CargarTablaUsuario();
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = true;
            btn_nuevo.Enabled = true;
            btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
            btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
            btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textNombre.Focus();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            //string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\\BD Toldito\\Prueba\\BD\\BD_Bibloteca_V1.mdb";
            //OleDbConnection con = new OleDbConnection(cadena);
            //con.Open();
           



            //string sql = "select * from Libros";
            //OleDbDataAdapter da = new OleDbDataAdapter(sql, cadena);
            //DataTable dt = new DataTable();
            //con.Close();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string direcc = textDireccion.Text;
            string telefono = textTelefono.Text;
            string email = textEmail.Text;          
            int dni = Convert.ToInt32(textDni.Text);
            int tipoUsuario = Convert.ToInt32(textTipoUsuario.Text);

            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            string sql = "INSERT INTO usuario(NombreUsuario,ApellidoUsuario,DniUsuario,TipoUsuario,email,direccion,telefono) VALUES('" + nombre + "','" + apellido + "','" + dni + "','" + tipoUsuario + "','" + email + "','" + direcc + "','" + telefono + "')";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se ingresaron exitosamente");
            con.Close();
            limpiar();
            CargarTablaUsuario();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string direcc = textDireccion.Text;
            string telefono = textTelefono.Text;
            string email = textEmail.Text;
            int dni = Convert.ToInt32(textDni.Text);
            int tipoUsuario = Convert.ToInt32(textTipoUsuario.Text);

            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            string sql = "update usuario set NombreUsuario='" + nombre + "',ApellidoUsuario='" + apellido + "',DniUsuario='" + dni + "',TipoUsuario='" + tipoUsuario + "' ,email='" + email + "',direccion='" + direcc + "',telefono='" + telefono + "' where id_usuario='" + this.Id + "';";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se ingresaron exitosamente");
            con.Close();
            limpiar();
            CargarTablaUsuario();

            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = true;
            btn_nuevo.Enabled = true;

            btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
            btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
            btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textNombre.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(posicion);
            limpiar();
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = true;
            btn_nuevo.Enabled = true;

            btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
            btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
            btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textNombre.Focus();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = true;
            btn_nuevo.Enabled = true;

            btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
            btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
            btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textNombre.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;
            this.Id = dataGridView1[0, posicion].Value.ToString();
            textNombre.Text = dataGridView1[1, posicion].Value.ToString();
            textApellido.Text = dataGridView1[2, posicion].Value.ToString();
            textDni.Text = dataGridView1[3, posicion].Value.ToString();
            textTipoUsuario.Text = dataGridView1[4, posicion].Value.ToString();
            textEmail.Text = dataGridView1[5, posicion].Value.ToString();
            textDireccion.Text = dataGridView1[6, posicion].Value.ToString();
            textTelefono.Text = dataGridView1[7, posicion].Value.ToString();
         
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            btn_agregar.Enabled = false;
            btn_nuevo.Enabled = true;

            btn_eliminar.BackColor = Color.FromArgb(169, 16, 121);
            btn_modificar.BackColor = Color.FromArgb(169, 16, 121);
            btn_agregar.BackColor = Color.FromArgb(87, 10, 87);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textNombre.Focus();
        }
        void limpiar()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
            textEmail.Text = "";

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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
