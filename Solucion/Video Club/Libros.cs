using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using MySql.Data.MySqlClient;
namespace Video_Club
{
    public partial class Libros : Form
    {
        int posicion = 0;
        public Libros()
        {
            InitializeComponent();
            CargarTablaLibro();
            btnRegistrar.Enabled = true;
            btnRegistrar.BackColor = Color.FromArgb(169, 16, 121);
        }
        void CargarTablaLibro()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select idLibros,titulo,nombreAutor,Editorial,fechaPublic,edicion,Categoria,Idioma,pagina,Estado,notas,stock,condicionLibro from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgv_detalle.DataSource = dt;
            dgv_detalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
        private void dgv_detalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            LibroClass libroObj = new LibroClass();

            posicion = dgv_detalle.CurrentRow.Index;
            libroObj.Id = int.Parse(dgv_detalle[0, posicion].Value.ToString());
            libroObj.Titulo = dgv_detalle[1, posicion].Value.ToString();
            libroObj.AutorCo = dgv_detalle[2, posicion].Value.ToString();
            libroObj.EditorCo = dgv_detalle[3, posicion].Value.ToString();
            //libroObj.FechaPublic = DateTime.Parse(dgv_detalle[4, posicion].Value.ToString());
            libroObj.FechaPublic = dgv_detalle[4, posicion].Value.ToString();
            libroObj.Edicion = dgv_detalle[5, posicion].Value.ToString();
            libroObj.CategoriaCo = dgv_detalle[6, posicion].Value.ToString();
            libroObj.IdiomaCo = dgv_detalle[7, posicion].Value.ToString();
            libroObj.Pagina = int.Parse(dgv_detalle[8, posicion].Value.ToString());
            libroObj.EstadoCo = dgv_detalle[9, posicion].Value.ToString();
            libroObj.Notas = dgv_detalle[10, posicion].Value.ToString();
            libroObj.Stock = int.Parse(dgv_detalle[11, posicion].Value.ToString());
            libroObj.CondicionLib = int.Parse(dgv_detalle[12, posicion].Value.ToString());

            libroObj.EstadoLibro = true;
            btnRegistrar.Visible = false;
            panel7.Visible = false;
            dgv_detalle.Visible = false;
            AbrirFormEnPanel(new LibroCrud());
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            btnRegistrar.Visible = false;
            panel7.Visible = false;
            dgv_detalle.Visible = false;
            LibroClass libroObj = new LibroClass();
            libroObj.EstadoLibro = false;
            libroObj.Id = 0;
            AbrirFormEnPanel(new LibroCrud());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
