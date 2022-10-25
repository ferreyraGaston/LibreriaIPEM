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
        public Prestamo()
        {
            InitializeComponent();
            CargarTablaLibro();
            CargarTablaUsuario();
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
            dgv_detalle.DataSource = dt;
            dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            dgUsuario.DataSource = dt;
            dgUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
