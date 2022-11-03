
using CapaDeNegocios;
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
            NegocioLibro obtjetoCategoria = new NegocioLibro();
            this.cboCategoria.DataSource = obtjetoCategoria.llenarcomboCategoria();
            this.cboCategoria.DisplayMember = "NombCategoria";
            this.cboCategoria.ValueMember = "IdCategoria";
            this.cboCategoria.SelectedIndex = -1;
        }
        private void listarAutor()
        {
            NegocioLibro obtjetoAutor = new NegocioLibro();
            this.cboAutor.DataSource = obtjetoAutor.llenarcomboAutor();
            this.cboAutor.DisplayMember = "NombAutor";
            this.cboAutor.ValueMember = "IdAutor";
            this.cboAutor.SelectedIndex = -1;
        }

        private void listarEstado()
        {
            NegocioLibro obtjetoEstado = new NegocioLibro();
            this.cboEstado.DataSource = obtjetoEstado.llenarcomboEstado();
            this.cboEstado.DisplayMember = "NombEstado";
            this.cboEstado.ValueMember = "IdEstado";
            this.cboEstado.SelectedIndex = -1;
        }

        private void listarIdioma()
        {
            NegocioLibro obtjetoIdiomar = new NegocioLibro();
            this.cboIdioma.DataSource = obtjetoIdiomar.llenarcomboIdioma();
            this.cboIdioma.DisplayMember = "NombIdioma";
            this.cboIdioma.ValueMember = "IdIdioma";
            this.cboIdioma.SelectedIndex = -1;
        }
            
        private void listarEditorial()
        {
            NegocioLibro obtjetoEditor = new NegocioLibro();
            this.cboEditor.DataSource = obtjetoEditor.llenarcomboEditorial();
            this.cboEditor.DisplayMember = "NombEditorial";
            this.cboEditor.ValueMember = "IdEditorial";
            this.cboEditor.SelectedIndex = -1;
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
                libroObj.FechaPublic1 = dtFecha.Value;
                libroObj.Edicion = txtEdicion.Text;
                libroObj.Categoria = Convert.ToInt32(cboCategoria.SelectedIndex) + 1;
                libroObj.Idioma = Convert.ToInt32(cboIdioma.SelectedIndex) + 1;
                libroObj.Pagina = Convert.ToInt32(txtPagina.Text);
                libroObj.Estado = Convert.ToInt32(cboEstado.SelectedIndex) + 1;
                libroObj.Notas = txtNotas.Text;
                libroObj.Stock = Convert.ToInt32(txtStock.Text);
                libroObj.CondicionLib = Convert.ToInt32(txtCondicion.Text);

                int nGrabados = -1;
                //llamo al método que carga los datos del objeto
                NegocioLibro objetoLibro = new NegocioLibro();
                LibroClass objEntProf=new LibroClass(); 
                nGrabados = objetoLibro.abmLibros("Alta", objEntProf); //invoco a la capa de negocio
                if (nGrabados == -1)
                {
                    //lblMensaje.Text = " No pudo grabar profesionales en el sistema";
                    DialogoError FormDialog = new DialogoError();
                    FormDialog.ShowDialog();
                }
                else
                {
                    // lblMensaje.Text = " Se grabó con éxito profesionales.";
                    Dialogo FormDialog = new Dialogo();
                    FormDialog.ShowDialog();
                }
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
                //btn_eliminar.BackColor = Color.FromArgb(169, 16, 121);
                //btn_modificar.BackColor = Color.FromArgb(169, 16, 121);
                //btn_agregar.BackColor = Color.FromArgb(87, 10, 87);
                //btn_nuevo.BackColor = Color.FromArgb(87, 10, 87);
                txtTitulo.Focus();
            }
            else
            {
                btn_eliminar.Enabled = false;
                btn_modificar.Enabled = false;
                btn_agregar.Enabled = true;
                btn_nuevo.Enabled = true;
                //btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
                //btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
                //btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
                //btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);

                txtTitulo.Focus();
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            LibroClass libroObj = new LibroClass();
            if (MessageBox.Show("el Id: " + libroObj.Id, "Estas Seguro que deseas Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int nGrabados = -1;
                //llamo al método que carga los datos del objeto
                NegocioLibro objetoLibro = new NegocioLibro();
                LibroClass objEntProf = new LibroClass();
                nGrabados = objetoLibro.abmLibros("Eliminar", objEntProf); //invoco a la capa de negocio
                if (nGrabados == -1)
                {
                    //lblMensaje.Text = " No pudo grabar profesionales en el sistema";
                    DialogoError FormDialog = new DialogoError();
                    FormDialog.ShowDialog();
                }
                else
                {
                    // lblMensaje.Text = " Se grabó con éxito profesionales.";
                    Dialogo FormDialog = new Dialogo();
                    FormDialog.ShowDialog();
                }
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
                libroObj.FechaPublic1 = dtFecha.Value;
                libroObj.Edicion = txtEdicion.Text;
                libroObj.Categoria = Convert.ToInt32(cboCategoria.SelectedIndex) + 1;
                libroObj.Idioma = Convert.ToInt32(cboIdioma.SelectedIndex) + 1;
                libroObj.Pagina = Convert.ToInt32(txtPagina.Text);
                libroObj.Estado = Convert.ToInt32(cboEstado.SelectedIndex) + 1;
                libroObj.Notas = txtNotas.Text;
                libroObj.Stock = Convert.ToInt32(txtStock.Text);
                libroObj.CondicionLib = Convert.ToInt32(txtCondicion.Text);

                int nGrabados = -1;
                //llamo al método que carga los datos del objeto
                NegocioLibro objetoLibro = new NegocioLibro();
                LibroClass objEntProf = new LibroClass();
                nGrabados = objetoLibro.abmLibros("Modificar", objEntProf); //invoco a la capa de negocio
                if (nGrabados == -1)
                {
                    //lblMensaje.Text = " No pudo grabar profesionales en el sistema";
                    DialogoError FormDialog = new DialogoError();
                    FormDialog.ShowDialog();
                }
                else
                {
                    // lblMensaje.Text = " Se grabó con éxito profesionales.";
                    Dialogo FormDialog = new Dialogo();
                    FormDialog.ShowDialog();
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

        private void cboEditor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
