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
using CapaDeNegocios;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CapaDeDatos;

namespace Video_Club
{
    public partial class Libros : Form
    {
        int posicion = 0;
        public Libros()
        {
            InitializeComponent();
      
            CargarTablaLibro();
            btnReg.Enabled = true;
            btnReg.BackColor = Color.FromArgb(8, 58, 169);
        }
        private void CargarTablaLibro()
        {
            dgv_detalle.Columns.Clear();
            cargarColumnas();
            NegocioLibro objetoLibro = new NegocioLibro();

            dgv_detalle.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objetoLibro.listadoLibro("Todos");
            if(ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_detalle.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], dr[5].ToString(), dr[6], dr[7], dr[8], dr[9].ToString(), dr[10], dr[11].ToString(), dr[12].ToString());
                }
            }
            else
            {
               // MessageBox.Show("no hay datos cargado en la base de datos Libros");
            }

        }

        private void CargarTablaLibroBuscar(string cual)
        {
            try { 
            dgv_detalle.Columns.Clear();
            cargarColumnas();
            NegocioLibro objetoLibro = new NegocioLibro();

            dgv_detalle.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objetoLibro.listadoLibro(cual);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_detalle.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], dr[5].ToString(), dr[6], dr[7], dr[8], dr[9].ToString(), dr[10], dr[11].ToString(), dr[12].ToString());
                }
            }
            else
            {
               // MessageBox.Show("no hay datos cargado en la base de datos Libros");
            }
            }
            catch
            {
                DialogoError FormDialog = new DialogoError();
                FormDialog.ShowDialog();
            }

        }

        private void cargarColumnas()
        {
            dgv_detalle.Columns.Add("0","ID");
            dgv_detalle.Columns.Add("1", "TITULO");
            dgv_detalle.Columns.Add("2", "AUTOR");
            dgv_detalle.Columns.Add("3", "EDITORIAL");
            dgv_detalle.Columns.Add("4", "FECHA P");
            dgv_detalle.Columns.Add("5", "TIPO");
            dgv_detalle.Columns.Add("6", "CATEGORÍA");
            dgv_detalle.Columns.Add("7", "IDIOMA");
            dgv_detalle.Columns.Add("8", "PAGINAS");
            dgv_detalle.Columns.Add("9", "ESTADO");
            dgv_detalle.Columns.Add("10", "DETALLE");
            dgv_detalle.Columns.Add("11", "STOCK");
            dgv_detalle.Columns.Add("12", "CONDICION");


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
            libroObj.FechaPublic1 =DateTime.Parse(dgv_detalle[4, posicion].Value.ToString());
            libroObj.Edicion = dgv_detalle[5, posicion].Value.ToString();
            libroObj.CategoriaCo = dgv_detalle[6, posicion].Value.ToString();
            libroObj.IdiomaCo = dgv_detalle[7, posicion].Value.ToString();
            libroObj.Pagina = int.Parse(dgv_detalle[8, posicion].Value.ToString());
            libroObj.EstadoCo = dgv_detalle[9, posicion].Value.ToString();
            libroObj.Notas = dgv_detalle[10, posicion].Value.ToString();
            libroObj.Stock = int.Parse(dgv_detalle[11, posicion].Value.ToString());
            libroObj.CondicionLib = int.Parse(dgv_detalle[12, posicion].Value.ToString());

            libroObj.EstadoLibro = true;
            btnReg.Visible = false;
            panel7.Visible = false;
            panel3.Visible = false;
            dgv_detalle.Visible = false;
            groupBox1.Visible = false;
            AbrirFormEnPanel(new LibroCrud());
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtBuscar.Text!="")
            { 
            rbReservado.Checked = false;
            rbNoDisponible.Checked = false;
            rbDisponible.Checked = false;
            dgv_detalle.Columns.Clear();
            cargarColumnas();
            CargarTablaLibroBuscar(txtBuscar.Text);
            txtBuscar.Text = "";
            }
            txtBuscar.Text = "";
            
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            rbReservado.Checked = false;
            rbNoDisponible.Checked = false;
            rbDisponible.Checked = false;
            CargarTablaLibro();
            txtBuscar.Text = "";
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CargarTablaLibroBuscar("reserva");
            txtBuscar.Text = "";
        }

        private void rbNoDisponible_CheckedChanged(object sender, EventArgs e)
        {
            CargarTablaLibroBuscar("nodisponible");
            txtBuscar.Text = "";
        }

        private void rbDisponible_CheckedChanged(object sender, EventArgs e)
        {
            CargarTablaLibroBuscar("disponible");
            txtBuscar.Text = "";
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            groupBox1.Visible = false;
            btnReg.Visible = false;
            panel7.Visible = false;
            panel3.Visible = false;
            dgv_detalle.Visible = false;
            LibroClass libroObj = new LibroClass();
            libroObj.EstadoLibro = false;
            libroObj.Id = 0;
            AbrirFormEnPanel(new LibroCrud());
        }

    }
}
