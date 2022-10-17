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

namespace Video_Club
{
    public partial class ventas : Form
    {

        int i = 1;
        int posicion = 0;
        public ventas()
        {
            InitializeComponent();
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = true;
            btn_nuevo.Enabled = true;
            btn_eliminar.BackColor= Color.FromArgb(87, 10, 87);
            btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
            btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textCodigo.Focus();
        }

       void limpiar()
        {
            textCodigo.Text="";
            textDescripcion.Text = "";
            textStock.Text = "";
            textPrecio.Text = "";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
           
            string v_codigo, v_descripcion, v_stock, v_precio;

            v_codigo = textCodigo.Text;
            v_descripcion = textDescripcion.Text;
            v_stock = textStock.Text;
            v_precio = textPrecio.Text;

            dgv_detalle.Rows.Add(i + "", v_codigo, v_descripcion, v_stock, v_precio);
            i = i + 1;
            limpiar();
            textCodigo.Focus();
        }

        private void dgv_detalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dgv_detalle.CurrentRow.Index;

            textCodigo.Text = dgv_detalle[1,posicion].Value.ToString();
            textDescripcion.Text = dgv_detalle[2, posicion].Value.ToString();
            textStock.Text = dgv_detalle[3, posicion].Value.ToString();
            textPrecio.Text = dgv_detalle[4, posicion].Value.ToString();
            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            btn_agregar.Enabled = false;
            btn_nuevo.Enabled = true;

            btn_eliminar.BackColor = Color.FromArgb(169, 16, 121);
            btn_modificar.BackColor = Color.FromArgb(169, 16, 121);
            btn_agregar.BackColor = Color.FromArgb(87, 10, 87);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textCodigo.Focus();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string codigo, descripcion, stock, precio;

            codigo = textCodigo.Text;
            descripcion = textDescripcion.Text;
            stock = textStock.Text;
            precio = textPrecio.Text;

            dgv_detalle[1, posicion].Value = textCodigo.Text;
            dgv_detalle[2, posicion].Value = textDescripcion.Text;
            dgv_detalle[3, posicion].Value = textStock.Text;
            dgv_detalle[4, posicion].Value = textPrecio.Text;

            limpiar();
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = true;
            btn_nuevo.Enabled = true;

            btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
            btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
            btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textCodigo.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            dgv_detalle.Rows.RemoveAt(posicion);
            limpiar();
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = true;
            btn_nuevo.Enabled = true;

            btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
            btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
            btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textCodigo.Focus();
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
            textCodigo.Focus();
        }

        private void ventas_Load(object sender, EventArgs e)
        {
            //string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\BD Toldito\\Prueba\\BD\\toldito_pba.mdb;User Id=admin;Password=;";
            //OleDbConnection con = new OleDbConnection(cadena);
            //con.Open();
            //string sql = "select * from Factura";
            //OleDbDataAdapter da = new OleDbDataAdapter(sql, cadena);
            //DataTable dt = new DataTable();
            //con.Close();
            //da.Fill(dt);
            //dgv_detalle.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\BD Toldito\\Prueba\\BD\\Toldito_pba.mdb";
            OleDbConnection con = new OleDbConnection(cadena);
            con.Open();
            string sql = "select * from Factura";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dgv_detalle.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
