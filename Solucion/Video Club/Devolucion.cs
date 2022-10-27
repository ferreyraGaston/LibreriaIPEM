using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Club
{
    public partial class Devolucion : Form
    {
        int posicion = 0;
        public Devolucion()
        {
            InitializeComponent();
            CargarTablaPrestamo();
        }
        void CargarTablaPrestamo()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select idPrestamo as ID,idUsuario as ID_Usu,NombreUsuario as Nombre,ApellidoUsuario as Apellido,idLibro as ID_Lib,titulo as Titulo,fechaSalida as Salida,fechaEntrega as Entrega, mora as Mora,stock as Stock from prestamo INNER JOIN usuario On prestamo.idUsuario = usuario.id_usuario INNER JOIN libros On prestamo.idLibro = libros.idLibros where condicion=0;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgDevolucion.DataSource = dt;
            dgDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btnDeBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select idPrestamo as ID,idUsuario as ID_Usu,NombreUsuario as Nombre,ApellidoUsuario as Apellido,idLibro as ID_Lib,titulo as Titulo,fechaSalida as Salida,fechaEntrega as Entrega, mora as Mora,stock as Stock from prestamo INNER JOIN usuario On prestamo.idUsuario = usuario.id_usuario INNER JOIN libros On prestamo.idLibro = libros.idLibros where prestamo.idPrestamo ='" + txtDevolver.Text + "' || usuario.NombreUsuario LIKE '%" + txtDevolver.Text + "%' || usuario.ApellidoUsuario LIKE '%" + txtDevolver.Text + "%' || libros.titulo LIKE '%" + txtDevolver.Text + "%';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgDevolucion.DataSource = dt;
            dgDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btn_registrar_Click(object sender, EventArgs e)
        {
            PrestamoClass prestamoObj = new PrestamoClass();
            prestamoObj.FechaDevolucion = dtFechaDevolucion.Text;
            //prestamoObj.Condicion = Convert.ToBoolean(0);
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            string sql = "update libros set stock='" + prestamoObj.Stock + "', id_estado=1  where idLibros='" + prestamoObj.IdLibro + "';";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.ExecuteNonQuery();
            con.Close();

            string sql2 = "update prestamo set fechaDevolucion='" + prestamoObj.FechaDevolucion + "', condicion=1  where idPrestamo='" + prestamoObj.IdPrestamo + "';";
            MySqlConnection con2 = new MySqlConnection(cadena);
            con2.Open();
            MySqlCommand comando2 = new MySqlCommand(sql2, con2);
            comando2.ExecuteNonQuery();
            //MessageBox.Show("Los datos se actualizaron exitosamente");
            con2.Close();
            Dialogo FormDialog = new Dialogo();
            FormDialog.ShowDialog();
            CargarTablaPrestamo();
        }

        private void dgDevolucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrestamoClass prestamoObj = new PrestamoClass();
            posicion = dgDevolucion.CurrentRow.Index;
            prestamoObj.IdPrestamo = int.Parse(dgDevolucion[0, posicion].Value.ToString());
            prestamoObj.IdUsuario = int.Parse(dgDevolucion[1, posicion].Value.ToString());
            prestamoObj.IdLibro = int.Parse(dgDevolucion[4, posicion].Value.ToString());
            prestamoObj.Stock = int.Parse(dgDevolucion[9, posicion].Value.ToString()) + 1;
          
        }

        private void btnDeRefrescar_Click(object sender, EventArgs e)
        {
            CargarTablaPrestamo();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Dialogo FormDialog = new Dialogo();
            FormDialog.ShowDialog();
        }
    }
}
