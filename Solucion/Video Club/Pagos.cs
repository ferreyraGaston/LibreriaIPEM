
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
            //Conexion conexion = new Conexion();
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select idPrestamo as ID,titulo as TITULO, NombreUsuario as NOMBRE,ApellidoUsuario as APELLIDO,DniUsuario as DNI,telefono as TELEFONO, estadoUsuario as ESTADO, mora as SALDO  from prestamo INNER JOIN usuario On prestamo.idUsuario=usuario.id_usuario INNER JOIN libros On prestamo.idLibro=libros.idLibros where estadoUsuario=1 and prestamo.mora>0";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgPagos.DataSource = dt;
            dgPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btnUsBuscar_Click(object sender, EventArgs e)
        {
            //Conexion conexion = new Conexion();
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

        private void dgPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UsuarioClass usuarioObj = new UsuarioClass();
            PrestamoClass prestamoObj = new PrestamoClass();
            posicion = dgPagos.CurrentRow.Index;
            prestamoObj.IdPrestamo = int.Parse(dgPagos[0, posicion].Value.ToString());
            usuarioObj.Nombre1 = dgPagos[2, posicion].Value.ToString();
            usuarioObj.Apellido1 = dgPagos[3, posicion].Value.ToString();
            usuarioObj.Dni1 = int.Parse(dgPagos[4, posicion].Value.ToString());
            prestamoObj.Mora = double.Parse(dgPagos[7, posicion].Value.ToString());
            usuarioObj.Estado = false;
            textNombre.Text = usuarioObj.Nombre1;
            textApellido.Text = usuarioObj.Apellido1;
            textDni.Text = Convert.ToString(usuarioObj.Dni1);



        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (ValidarCampos())
            {
                PrestamoClass prestamoObj = new PrestamoClass();
                //prestamoObj.Condicion = Convert.ToBoolean(0);
                //Conexion conexion = new Conexion();
                string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
                string sql = "update prestamo set mora='0' where idPrestamo='" + prestamoObj.IdPrestamo + "';";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.ExecuteNonQuery();
                con.Close();
            }

            CargarTablaUsuario();
        }

        private bool ValidarCampos()
        {
            bool validarOk = true;
            if (textNombre.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(textNombre, "Seleccionar el Usuario");
            }
            if (textApellido.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(textApellido, "Seleccionar el Libro");
            }
            if (textDni.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(textDni, "Seleccionar el Libro");
            }
            return validarOk;
        }

        private void BorrarError()
        {
            errorProvider1.SetError(textNombre, "");
            errorProvider1.SetError(textApellido, "");
            errorProvider1.SetError(textDni, "");

        }
    }
}
