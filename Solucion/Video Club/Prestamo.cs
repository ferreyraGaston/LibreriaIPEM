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

namespace Video_Club
{
    public partial class Prestamo : Form
    {
        int posicion = 0;
        int posicion2 = 0;
        int posicion3 = 0;
        public Prestamo()
        {
            InitializeComponent();
            CargarTablaLibro();
            CargarTablaUsuario();
            CargarTablaPrestamo();
        }
        void CargarTablaLibro()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select idLibros as ID,titulo as TITULO,nombreAutor as AUTOR,Editorial as EDITORIAL,fechaPublic as FECHA,edicion as EDICION,Categoria as CATEGORIA,Idioma as IDIOMA,pagina as PAGINA,Estado as ESTADO,notas as NOTA,stock as STOCK,condicionLibro as CONDICIÓN from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgLibro.DataSource = dt;
            dgLibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        void CargarTablaPrestamo()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select idPrestamo as ID,NombreUsuario as Nombre,ApellidoUsuario as Apellido,titulo as Titulo,fechaSalida as Salida,fechaEntrega as Entrega from prestamo INNER JOIN usuario On prestamo.idUsuario = usuario.id_usuario INNER JOIN libros On prestamo.idLibro = libros.idLibros;";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgPrestamo.DataSource = dt;
            dgPrestamo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        void CargarTablaUsuario()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select id_usuario as ID,NombreUsuario as NOMBRE,ApellidoUsuario as APELLIDO,DniUsuario as DNI,telefono as TELEFONO from usuario";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgUsuario.DataSource = dt;
            dgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btnUsBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select id_usuario as ID,NombreUsuario as NOMBRE,ApellidoUsuario as APELLIDO,DniUsuario as DNI,telefono as TELEFONO from usuario where usuario.id_usuario ='" + txtUsuario.Text + "' || usuario.NombreUsuario='" + txtUsuario.Text + "' || usuario.ApellidoUsuario='" + txtUsuario.Text + "' || usuario.DniUsuario='" + txtUsuario.Text + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgUsuario.DataSource = dt;
            dgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtUsuario.Text = "";
        }

        private void btnUsRefrescar_Click(object sender, EventArgs e)
        {
            CargarTablaUsuario();
            txtUsuario.Text = "";
        }

        private void btnLiBuscar_Click(object sender, EventArgs e)
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select idLibros as ID,titulo as TITULO,nombreAutor as AUTOR,Editorial as EDITORIAL,fechaPublic as FECHA,edicion as EDICION,Categoria as CATEGORIA,Idioma as IDIOMA,pagina as PAGINA,Estado as ESTADO,notas as NOTA,stock as STOCK,condicionLibro as CONDICIÓN from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado where libros.idLibros ='" + txtLibro.Text + "' || libros.titulo='" + txtLibro.Text + "'|| autor.nombreAutor= '" + txtLibro.Text + "' || idioma.Idioma='" + txtLibro.Text + "' || categoria.Categoria='" + txtLibro.Text + "' || editorial.Editorial='" + txtLibro.Text + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgLibro.DataSource = dt;
            dgLibro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            txtLibro.Text = "";
        }

        private void btnLiRefrescar_Click(object sender, EventArgs e)
        {
            CargarTablaLibro();
            txtLibro.Text = "";
        }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrestamoClass prestamoObj = new PrestamoClass();
            posicion = dgUsuario.CurrentRow.Index;
            prestamoObj.IdUsuario = int.Parse(dgUsuario[0, posicion].Value.ToString());
            txtIdUsuario.Text = dgUsuario[0, posicion].Value.ToString();
        }

        private void dgLibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrestamoClass prestamoObj = new PrestamoClass();
            posicion2 = dgLibro.CurrentRow.Index;
            prestamoObj.IdLibro = int.Parse(dgLibro[0, posicion2].Value.ToString());
            prestamoObj.Stock = int.Parse(dgLibro[12, posicion2].Value.ToString())-1;
            txtIdLibro.Text = dgLibro[0, posicion2].Value.ToString();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (ValidarCampos())
            {
            PrestamoClass prestamoObj = new PrestamoClass();
            prestamoObj.FechaSalida= dtFechaSalida.Text;
            prestamoObj.FechaEntrega= dtFechaEntrega.Text;  
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            string sql = "INSERT INTO prestamo(idUsuario,idLibro,fechaSalida,fechaEntrega) VALUES('" + prestamoObj.IdUsuario + "','" + prestamoObj.IdLibro + "','" + prestamoObj.FechaSalida + "','" + prestamoObj.FechaEntrega + "')";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se ingresaron exitosamente");
            con.Close();
            }
            else
            {
                if(txtIdUsuario.Text=="")
                {
                    MessageBox.Show("Debes seleccionar el un Usuario.. ");
                }
                else
                {
                    MessageBox.Show("Debes seleccionar el un Libro.. ");
                }
                
            }
            CargarTablaPrestamo();
        }

        private void BorrarError()
        {
            errorProvider1.SetError(txtIdUsuario, "");
            errorProvider1.SetError(txtIdLibro, "");
            errorProvider1.SetError(dtFechaSalida, "");
            errorProvider1.SetError(dtFechaEntrega, "");
        }
        private bool ValidarCampos()
        {
            bool validarOk = true;
            if (txtIdUsuario.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(txtIdUsuario, "Seleccionar el Usuario");
            }
            if (txtIdLibro.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(txtIdLibro, "Seleccionar el Libro");
            }
           
            return validarOk;
        }

        private void pnl_opciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            PrestamoClass prestamoObj = new PrestamoClass();
            if (prestamoObj.IdPrestamo > 0)
            {
            if (MessageBox.Show("el Id: " + prestamoObj.IdPrestamo, "Estas Seguro que deseas Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
                string sql = "delete from prestamo where idPrestamo='" + prestamoObj.IdPrestamo + "';";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se elimino exitosamente");
                con.Close();
                CargarTablaPrestamo();
            }
            btn_eliminar.Enabled = false;
            btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
            }
            else
            {
                MessageBox.Show("Selecciona el prestamo que dese eliminar");
            }
        }

        private void dgPrestamo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrestamoClass prestamoObj = new PrestamoClass();
            posicion3 = dgPrestamo.CurrentRow.Index;
            prestamoObj.IdPrestamo = int.Parse(dgPrestamo[0, posicion3].Value.ToString());

        }
    }
}
