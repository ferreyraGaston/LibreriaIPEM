using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class RepVentas : Form
    {
        public RepVentas()
        {
            InitializeComponent();
            CargarTablaPrestamo();
        }
        void CargarTablaPrestamo()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select idPrestamo as ID,idUsuario as ID_Usu,NombreUsuario as NOMBRE,ApellidoUsuario as APELLIDO,idLibro as ID_Lib,titulo as TITULO,fechaSalida as SALIDA,fechaEntrega as ENTREGA,fechaDevolucion as DEVOLUCIÓN, mora as MORA,stock as STOCK,condicion as CONDICIÓN from prestamo INNER JOIN usuario On prestamo.idUsuario = usuario.id_usuario INNER JOIN libros On prestamo.idLibro = libros.idLibros;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgDevolucion.DataSource = dt;
            dgDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void dgDevolucion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select idPrestamo as ID,idUsuario as ID_Usu,NombreUsuario as NOMBRE,ApellidoUsuario as APELLIDO,idLibro as ID_Lib,titulo as TITULO,fechaSalida as SALIDA,fechaEntrega as ENTREGA,fechaDevolucion as DEVOLUCIÓN, mora as MORA,stock as STOCK,condicion as CONDICIÓN from prestamo INNER JOIN usuario On prestamo.idUsuario = usuario.id_usuario INNER JOIN libros On prestamo.idLibro = libros.idLibros where prestamo.idPrestamo ='" + txtDevolver.Text + "' || usuario.NombreUsuario LIKE '%" + txtDevolver.Text + "%' || usuario.ApellidoUsuario LIKE '%" + txtDevolver.Text + "%' || libros.titulo LIKE '%" + txtDevolver.Text + "%';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgDevolucion.DataSource = dt;
            dgDevolucion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnDeRefrescar_Click(object sender, EventArgs e)
        {
            CargarTablaPrestamo();
        }
    }
}
