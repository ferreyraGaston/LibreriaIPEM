
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
        int contador = 0;
        public Pagos()
        {
            InitializeComponent();
            CargarTablaUsuario();
            dgPagos.Columns[2].Visible = false;
        }
        void CargarTablaUsuario()
        {
            //Conexion conexion = new Conexion();
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select idPrestamo as ID,titulo as TITULO,id_usuario as ID_USER, NombreUsuario as NOMBRE,ApellidoUsuario as APELLIDO,DniUsuario as DNI,telefono as TELEFONO, estadoUsuario as ESTADO, mora as SALDO  from prestamo INNER JOIN usuario On prestamo.idUsuario=usuario.id_usuario INNER JOIN libros On prestamo.idLibro=libros.idLibros where estadoUsuario=1 and prestamo.mora>0";
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
            string sql = "select idPrestamo as ID,titulo as TITULO,id_usuario as ID_USER, NombreUsuario as NOMBRE,ApellidoUsuario as APELLIDO,DniUsuario as DNI,telefono as TELEFONO, estadoUsuario as ESTADO, mora as SALDO from prestamo INNER JOIN usuario On prestamo.idUsuario=usuario.id_usuario INNER JOIN libros On prestamo.idLibro=libros.idLibros where estadoUsuario=1 and prestamo.mora>0 and prestamo.idPrestamo ='" + txtPagos.Text + "' || estadoUsuario=1 and prestamo.mora>0 and usuario.NombreUsuario LIKE '%" + txtPagos.Text + "%' || estadoUsuario=1 and prestamo.mora>0 and usuario.ApellidoUsuario LIKE '%" + txtPagos.Text + "%' || estadoUsuario=1 and prestamo.mora>0 and usuario.DniUsuario LIKE '%" + txtPagos.Text + "%';";
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
            usuarioObj.Id1= int.Parse(dgPagos[2, posicion].Value.ToString());
            usuarioObj.Nombre1 = dgPagos[3, posicion].Value.ToString();
            usuarioObj.Apellido1 = dgPagos[4, posicion].Value.ToString();
            usuarioObj.Dni1 = int.Parse(dgPagos[5, posicion].Value.ToString());
            prestamoObj.Mora = double.Parse(dgPagos[8, posicion].Value.ToString());
            usuarioObj.Estado = false;
            textNombre.Text = usuarioObj.Nombre1;
            textApellido.Text = usuarioObj.Apellido1;
            textDni.Text = Convert.ToString(usuarioObj.Dni1);

            //Conexion conexion = new Conexion();
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            string sql = "select COUNT(DniUsuario) as cont from prestamo INNER JOIN usuario On prestamo.idUsuario=usuario.id_usuario where estadoUsuario=1 and prestamo.mora>0 and DniUsuario='" + usuarioObj.Dni1 + "';";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand contar = new MySqlCommand(sql, con);
            contador = int.Parse(contar.ExecuteScalar()+"");
            txtContador.Text = contador.ToString();
            con.Close();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            BorrarError();
            UsuarioClass usuarioObj = new UsuarioClass();
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
            if (contador == 1)
            {
                    string sql2 = "update usuario set estadoUsuario='0' where id_usuario='" + usuarioObj.Id1 + "';";
                    MySqlConnection con2 = new MySqlConnection(cadena);
                    con2.Open();
                    MySqlCommand comando2 = new MySqlCommand(sql2, con2);
                    comando2.ExecuteNonQuery();
                    con2.Close();
            }
            limpiar();
            CargarTablaUsuario();
            Dialogo FormDialog = new Dialogo();
            FormDialog.ShowDialog();
            
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
        void limpiar()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textDni.Text = "";
            txtContador.Text = "";
        }
        private void BorrarError()
        {
            errorProvider1.SetError(textNombre, "");
            errorProvider1.SetError(textApellido, "");
            errorProvider1.SetError(textDni, "");

        }
    }
}
