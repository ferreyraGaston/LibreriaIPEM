using CapaDato;
using Entidades;
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
using static Bunifu.UI.WinForms.BunifuSnackbar;

namespace Video_Club
{
    public partial class Pagos : Form
    {
        int posicion=0;
        public Pagos()
        {
            InitializeComponent();
            CargarTablaUsuario();
        }
        void CargarTablaUsuario()
        {
            Class1 conexion = new Class1();
            MySqlConnection con = new MySqlConnection(conexion.Cadena);
            con.Open();
            string sql = "select id_usuario as ID,NombreUsuario as NOMBRE,ApellidoUsuario as APELLIDO,DniUsuario as DNI,telefono as TELEFONO, estadoUsuario as ESTADO,mora as SALDO  from usuario INNER JOIN prestamo On usuario.id_usuario = prestamo.idUsuario  where estadoUsuario=1";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion.Cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgPagos.DataSource = dt;
            dgPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btnUsBuscar_Click(object sender, EventArgs e)
        {
            Class1 conexion = new Class1();
            MySqlConnection con = new MySqlConnection(conexion.Cadena);
            con.Open();
            string sql = "select * from usuario where usuario.id_usuario ='" + txtPagos.Text + "' || usuario.NombreUsuario LIKE '%" + txtPagos.Text + "%' || usuario.ApellidoUsuario LIKE '%" + txtPagos.Text + "%' || usuario.DniUsuario LIKE '%" + txtPagos.Text + "%';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, conexion.Cadena);
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

        private void dgPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsuarioClass usuarioObj = new UsuarioClass();
            posicion = dgPagos.CurrentRow.Index;
            usuarioObj.Id1 = int.Parse(dgPagos[0, posicion].Value.ToString());
            usuarioObj.Nombre1 = dgPagos[1, posicion].Value.ToString();
            usuarioObj.Apellido1 = dgPagos[2, posicion].Value.ToString();
            usuarioObj.Dni1 = int.Parse(dgPagos[3, posicion].Value.ToString());

            usuarioObj.Telefono1 = dgPagos[4, posicion].Value.ToString();
            usuarioObj.Estado = false;
            //MessageBox.Show("nombre "+ usuarioObj.Nombre1);
            
            panel6.Visible = false;

            dgPagos.Visible = false;
        }
    }
}
