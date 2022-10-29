using MySql.Data.MySqlClient;
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
    public partial class Pagos : Form
    {
        public Pagos()
        {
            InitializeComponent();
            CargarTablaUsuario();
        }
        void CargarTablaUsuario()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select id_usuario as ID,NombreUsuario as NOMBRE,ApellidoUsuario as APELLIDO,DniUsuario as DNI,telefono as TELEFONO, estadoUsuario as ESTADO  from usuario where estadoUsuario=1";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgPagos.DataSource = dt;
            dgPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select * from usuario where usuario.id_usuario ='" + txtPagos.Text + "' || usuario.NombreUsuario LIKE '%" + txtPagos.Text + "%' || usuario.ApellidoUsuario LIKE '%" + txtPagos.Text + "%' || usuario.DniUsuario LIKE '%" + txtPagos.Text + "%';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgPagos.DataSource = dt;
            dgPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtPagos.Text = "";
        }

        private void btnUsRefrescar_Click(object sender, EventArgs e)
        {
            CargarTablaUsuario();
            txtPagos.Text = "";
        }
    }
}
