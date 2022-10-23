using Entidades;
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
    public partial class LibroCrud : Form
    {
        public LibroCrud()
        {
            InitializeComponent();        
            listarCategoria();
            listarAutor();
            listarIdioma();
            listarEditorial();
            listarEstado();
            estadoUsuario();
            CargarTextbox();
        }
        void CargarTextbox()
        {
            LibroClass libroObj = new LibroClass();
            if (libroObj.Id > 0)
            {
                txtTitulo.Text = libroObj.Titulo;
                cboAutor.ValueMember= Convert.ToString(libroObj.Autor);
                //libroObj.Editor = Convert.ToInt32(cboEditor.SelectedValue);
                //libroObj.FechaPublic = dtFecha.Value;
                //libroObj.Edicion = txtEdicion.Text;
                //libroObj.Categoria = Convert.ToInt32(cboCategoria.SelectedValue);
                //libroObj.Idioma = Convert.ToInt32(cboIdioma.SelectedValue);
                //libroObj.Pagina = Convert.ToInt32(txtPagina.Text);
                //libroObj.Estado = Convert.ToInt32(cboEstado.SelectedValue);
                //libroObj.Notas = txtNotas.Text;
                //libroObj.Stock = Convert.ToInt32(txtStock.Text);
                //libroObj.CondicionLib = Convert.ToInt32(txtCondicion.Text);
            }



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
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Libros());
        }
       private void listarCategoria()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select * from categoria order by Categoria asc";
            MySqlCommand da = new MySqlCommand(sql, con);
            MySqlDataReader dr =da.ExecuteReader();
            while(dr.Read())
            {
                cboCategoria.Items.Add(dr[1].ToString());
            }
            con.Close();           
        }
        private void listarAutor()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select * from autor order by apellidoAutor asc";
            MySqlCommand da = new MySqlCommand(sql, con);
            MySqlDataReader dr = da.ExecuteReader();
            while (dr.Read())
            {
                cboAutor.Items.Add(dr[1].ToString()+" "+ dr[2].ToString());
            }
            con.Close();
        }

        private void listarEstado()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select * from estado order by Estado asc";
            MySqlCommand da = new MySqlCommand(sql, con);
            MySqlDataReader dr = da.ExecuteReader();
            while (dr.Read())
            {
                cboEstado.Items.Add(dr[1].ToString());
            }
            con.Close();
        }

        private void listarIdioma()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select * from idioma order by Idioma asc";
            MySqlCommand da = new MySqlCommand(sql, con);
            MySqlDataReader dr = da.ExecuteReader();
            while (dr.Read())
            {
                cboIdioma.Items.Add(dr[1].ToString());
            }
            con.Close();
        }
        private void listarEditorial()
        {
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            string sql = "select * from editorial order by Editorial asc";
            MySqlCommand da = new MySqlCommand(sql, con);
            MySqlDataReader dr = da.ExecuteReader();
            while (dr.Read())
            {
                cboEditor.Items.Add(dr[1].ToString());
            }
            con.Close();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            LibroClass libroObj = new LibroClass();
            libroObj.Titulo= txtTitulo.Text;
            libroObj.Autor = Convert.ToInt32(cboAutor.SelectedValue);
            libroObj.Editor = Convert.ToInt32(cboEditor.SelectedValue);
            libroObj.FechaPublic =dtFecha.Value;
            libroObj.Edicion = txtEdicion.Text;
            libroObj.Categoria = Convert.ToInt32(cboCategoria.SelectedValue);
            libroObj.Idioma = Convert.ToInt32(cboIdioma.SelectedValue);
            libroObj.Pagina = Convert.ToInt32(txtPagina.Text);
            libroObj.Estado = Convert.ToInt32(cboEstado.SelectedValue);
            libroObj.Notas = txtNotas.Text;
            libroObj.Stock = Convert.ToInt32(txtStock.Text);
            libroObj.CondicionLib = Convert.ToInt32(txtCondicion.Text);
           
            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            string sql = "INSERT INTO libros(titulo,autor,editor,fechaPublic,edicion,categoria,idioma,pagina,estado,notas,stock,condicionLibro) VALUES('" + libroObj.Titulo + "','" + libroObj.Autor + "','" + libroObj.Editor + "','" + libroObj.FechaPublic + "','" + libroObj.Edicion + "','" + libroObj.Categoria + "','" + libroObj.Idioma + "','" + libroObj.Pagina + "','" + libroObj.Estado + "','" + libroObj.Notas + "','" + libroObj.Stock + "','" + libroObj.CondicionLib + "')";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se ingresaron exitosamente");
            con.Close();
            limpiar();
        }

        void limpiar()
        {
            //txtTitulo.Text = "";
            //cboAutor.v;
            //cboEditor.SelectedValue;
            //dtFecha.Text;
            txtEdicion.Text = "";
            //cboCategoria.SelectedValue;
            //cboIdioma.SelectedValue;
            //txtPagina.Text;
            //cboEstado.SelectedValue;
            txtNotas.Text = "";
            //txtStock.Text;
            //txtCondicion.Text;
        }

        void estadoUsuario()
        {
            LibroClass libroObj = new LibroClass();

            if (libroObj.EstadoLibro == true)
            {

                btn_eliminar.Enabled = true;
                btn_modificar.Enabled = true;
                btn_agregar.Enabled = false;
                btn_nuevo.Enabled = false;
                btn_eliminar.BackColor = Color.FromArgb(169, 16, 121);
                btn_modificar.BackColor = Color.FromArgb(169, 16, 121);
                btn_agregar.BackColor = Color.FromArgb(87, 10, 87);
                btn_nuevo.BackColor = Color.FromArgb(87, 10, 87);

                txtTitulo.Focus();
            }
            else
            {
                btn_eliminar.Enabled = false;
                btn_modificar.Enabled = false;
                btn_agregar.Enabled = true;
                btn_nuevo.Enabled = true;
                btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
                btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
                btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
                btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);

                txtTitulo.Focus();
            }


        }

    }
}
