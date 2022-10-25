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
            estadoUsuario();
            CargarTextbox();
        }
        void CargarTextbox()
        {
            LibroClass libroObj = new LibroClass();
            listarCategoria();
            listarAutor();
            listarIdioma();
            listarEditorial();
            listarEstado();
            if (libroObj.Id > 0)
            {
                cboAutor.Text=libroObj.AutorCo;
                cboEditor.Text = libroObj.EditorCo;
                cboCategoria.Text=libroObj.CategoriaCo;
                cboIdioma.Text=libroObj.IdiomaCo;
                cboEstado.Text=libroObj.EstadoCo;

                txtTitulo.Text = libroObj.Titulo;
                txtEdicion.Text = libroObj.Edicion;
                txtPagina.Text = Convert.ToString(libroObj.Pagina);
                txtNotas.Text = libroObj.Notas;
                txtStock.Text = Convert.ToString(libroObj.Stock);
                txtCondicion.Text = Convert.ToString(libroObj.CondicionLib);

            }else
            {

                cboAutor.Text = "";
                cboEditor.Text = "";
                cboCategoria.Text = "";
                cboIdioma.Text = "";
                cboEstado.Text = "";

                txtTitulo.Text = "";
                txtEdicion.Text = "";
                txtPagina.Text = "";
                txtNotas.Text = "";
                txtStock.Text = "";
                txtCondicion.Text = "";
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
            limpiar();
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
            BorrarError();
            if (ValidarCampos())
            {
                LibroClass libroObj = new LibroClass();
                libroObj.Titulo = txtTitulo.Text;
                libroObj.Autor = Convert.ToInt32(cboAutor.SelectedIndex) + 1;
                libroObj.Editor = Convert.ToInt32(cboEditor.SelectedIndex) + 1;
                libroObj.FechaPublic = dtFecha.Text;
                libroObj.Edicion = txtEdicion.Text;
                libroObj.Categoria = Convert.ToInt32(cboCategoria.SelectedIndex) + 1;
                libroObj.Idioma = Convert.ToInt32(cboIdioma.SelectedIndex) + 1;
                libroObj.Pagina = Convert.ToInt32(txtPagina.Text);
                libroObj.Estado = Convert.ToInt32(cboEstado.SelectedIndex) + 1;
                libroObj.Notas = txtNotas.Text;
                libroObj.Stock = Convert.ToInt32(txtStock.Text);
                libroObj.CondicionLib = Convert.ToInt32(txtCondicion.Text);

                string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
                string sql = "INSERT INTO libros(titulo,id_autor,id_editor,fechaPublic,edicion,id_categoria,id_idioma,pagina,id_estado,notas,stock,condicionLibro) VALUES('" + libroObj.Titulo + "','" + libroObj.Autor + "','" + libroObj.Editor + "','" + libroObj.FechaPublic + "','" + libroObj.Edicion + "','" + libroObj.Categoria + "','" + libroObj.Idioma + "','" + libroObj.Pagina + "','" + libroObj.Estado + "','" + libroObj.Notas + "','" + libroObj.Stock + "','" + libroObj.CondicionLib + "')";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se ingresaron exitosamente");
                con.Close();
                limpiar();
            }
            
        }

        void limpiar()
        {
            txtTitulo.Text= "";
            txtEdicion.Text = "";
            txtPagina.Text = "";
            txtStock.Text = "";
            txtCondicion.Text = "";
            txtNotas.Text = "";
            cboAutor.Text = "";
            cboEditor.Text = "";
            cboCategoria.Text = "";
            cboIdioma.Text = "";
            cboEstado.Text = "";
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
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            LibroClass libroObj = new LibroClass();
            if (MessageBox.Show("el Id: " + libroObj.Id, "Estas Seguro que deseas Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
                string sql = "delete from libros where idLibros='" + libroObj.Id + "';";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se elimino exitosamente");
                con.Close();
            }

            limpiar();

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
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (ValidarCampos())
            {
                LibroClass libroObj = new LibroClass();
                libroObj.Titulo = txtTitulo.Text;
                libroObj.Autor = Convert.ToInt32(cboAutor.SelectedIndex) + 1;
                libroObj.Editor = Convert.ToInt32(cboEditor.SelectedIndex) + 1;
                libroObj.FechaPublic = dtFecha.Text;
                libroObj.Edicion = txtEdicion.Text;
                libroObj.Categoria = Convert.ToInt32(cboCategoria.SelectedIndex) + 1;
                libroObj.Idioma = Convert.ToInt32(cboIdioma.SelectedIndex) + 1;
                libroObj.Pagina = Convert.ToInt32(txtPagina.Text);
                libroObj.Estado = Convert.ToInt32(cboEstado.SelectedIndex) + 1;
                libroObj.Notas = txtNotas.Text;
                libroObj.Stock = Convert.ToInt32(txtStock.Text);
                libroObj.CondicionLib = Convert.ToInt32(txtCondicion.Text);

                string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
                string sql = "update libros set titulo='" + libroObj.Titulo + "',id_autor='" + libroObj.Autor + "',id_editor='" + libroObj.Editor + "',fechaPublic='" + libroObj.FechaPublic + "' ,edicion='" + libroObj.Edicion + "',id_categoria='" + libroObj.Categoria + "',id_idioma='" + libroObj.Idioma + "',pagina='" + libroObj.Pagina + "',id_estado='" + libroObj.Estado + "',notas='" + libroObj.Notas + "',stock='" + libroObj.Stock + "',condicionLibro='" + libroObj.CondicionLib + "' where idLibros='" + libroObj.Id + "';";
                MySqlConnection con = new MySqlConnection(cadena);
                con.Open();
                MySqlCommand comando = new MySqlCommand(sql, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se actualizaron exitosamente");
                con.Close();
                limpiar();


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



        private void BorrarError()
        {
            errorProvider1.SetError(txtTitulo, "");
            errorProvider1.SetError(txtEdicion, "");
            errorProvider1.SetError(txtPagina, "");
            errorProvider1.SetError(txtStock, "");
            errorProvider1.SetError(txtCondicion, "");
            errorProvider1.SetError(txtNotas, "");
            errorProvider1.SetError(cboAutor, "");
            errorProvider1.SetError(cboEditor, "");
            errorProvider1.SetError(cboCategoria, "");
            errorProvider1.SetError(cboIdioma, "");
            errorProvider1.SetError(cboEstado, "");
         
        }
        private bool ValidarCampos()
        {
            bool validarOk = true;
            if (txtTitulo.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(txtTitulo, "Ingresar Titulo");
            }
            if (txtEdicion.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(txtEdicion, "Ingresar el tipo de edicion");
            }
            if (txtPagina.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(txtPagina, "Ingresar el numero de pagina");
            }
            if (txtStock.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(txtStock, "Ingresar la cantidad de ejemplares");
            }
            if (txtCondicion.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(txtCondicion, "Ingresar el tipo de condicion");
            }
            if (txtNotas.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(txtNotas, "Detalle el libro");
            }
            //
            if (cboAutor.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(cboAutor, "Seleccione el tipo de autor");
            }
            if (cboEditor.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(cboEditor, "Seleccione el tipo de editor");
            }
            if (cboCategoria.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(cboCategoria, "Seleccione el tipo de categoría");
            }
            if (cboIdioma.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(cboIdioma, "Seleccione el tipo de idioma");
            }
            if (cboEstado.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(cboEstado, "Seleccione el tipo de estado");
            }

            return validarOk;
        }

        private void txtPagina_Validating(object sender, CancelEventArgs e)
        {
            bool error = false;
            foreach (Char caracter in txtPagina.Text)
                if (char.IsDigit(caracter)) // recorre caracter por caracter buscando un char
                {
                    
                }
                else
                {
                    error = true;
                    break;
                }

            if (error)
            {
                errorProvider1.SetError(txtPagina, "No se admiten letras");
    
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtStock_Validating(object sender, CancelEventArgs e)
        {
            bool error = false;
            foreach (Char caracter in txtStock.Text)
                if (char.IsDigit(caracter)) // recorre caracter por caracter buscando un char
                {

                }
                else
                {
                    error = true;
                    break;
                }

            if (error)
            {
                errorProvider1.SetError(txtStock, "No se admiten letras");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtCondicion_Validating(object sender, CancelEventArgs e)
        {
            bool error = false;
            foreach (Char caracter in txtCondicion.Text)
                if (char.IsDigit(caracter)) // recorre caracter por caracter buscando un char
                {

                }
                else
                {
                    error = true;
                    break;
                }

            if (error)
            {
                errorProvider1.SetError(txtCondicion, "No se admiten letras");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void pnl_opciones_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
