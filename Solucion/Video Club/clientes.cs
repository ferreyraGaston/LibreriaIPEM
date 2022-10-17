using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using CapaDatos;

namespace Video_Club
{
    public partial class clientes : Form
    {
       // int i = 1;
        int posicion = 0;
        public clientes()
        {
            InitializeComponent();
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = true;
            btn_nuevo.Enabled = true;
            btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
            btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
            btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textNombre.Focus();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\\BD Toldito\\Prueba\\BD\\BD_Bibloteca_V1.mdb";
            OleDbConnection con = new OleDbConnection(cadena);
            con.Open();
           



            string sql = "select * from Libros";
            OleDbDataAdapter da = new OleDbDataAdapter(sql, cadena);
            DataTable dt = new DataTable();
            con.Close();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
           
            string nombre = textNombre.Text;
            string apellido = textApellido.Text;
            string domicilio = textDireccion.Text;
            decimal telefono = Convert.ToDecimal(textTelefono.Text);
            string email = textEmail.Text;
            string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\\BD Toldito\\Prueba\\BD\\BD_Bibloteca_V1.mdb";
            string sql = "INSERT INTO clientes(Nombre,Apellido,Domicilio,Telefono,Email) VALUES('" + nombre + "','" + apellido + "','" + domicilio + "'," + telefono + ",'" + email + "')";

            OleDbConnection con = new OleDbConnection(cadena);
            con.Open();

            OleDbCommand comando = new OleDbCommand(sql, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se ingresaron exitosamente");
            con.Close();
            limpiar();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            string nombre, apellido, direccion, telefono, email;

            nombre = textNombre.Text;
            apellido = textApellido.Text;
            direccion = textDireccion.Text;
            telefono = textTelefono.Text;
            email = textEmail.Text;

            dataGridView1[1, posicion].Value = nombre;
            dataGridView1[2, posicion].Value = apellido;
            dataGridView1[3, posicion].Value = direccion;
            dataGridView1[4, posicion].Value = telefono;
            dataGridView1[5, posicion].Value = email;

            limpiar();
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = true;
            btn_nuevo.Enabled = true;

            btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
            btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
            btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textNombre.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(posicion);
            limpiar();
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            btn_agregar.Enabled = true;
            btn_nuevo.Enabled = true;

            btn_eliminar.BackColor = Color.FromArgb(87, 10, 87);
            btn_modificar.BackColor = Color.FromArgb(87, 10, 87);
            btn_agregar.BackColor = Color.FromArgb(169, 16, 121);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textNombre.Focus();
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
            textNombre.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentRow.Index;

            textNombre.Text = dataGridView1[1, posicion].Value.ToString();
            textApellido.Text = dataGridView1[2, posicion].Value.ToString();
            textDireccion.Text = dataGridView1[3, posicion].Value.ToString();
            textTelefono.Text = dataGridView1[4, posicion].Value.ToString();
            textEmail.Text = dataGridView1[5, posicion].Value.ToString();

            btn_eliminar.Enabled = true;
            btn_modificar.Enabled = true;
            btn_agregar.Enabled = false;
            btn_nuevo.Enabled = true;

            btn_eliminar.BackColor = Color.FromArgb(169, 16, 121);
            btn_modificar.BackColor = Color.FromArgb(169, 16, 121);
            btn_agregar.BackColor = Color.FromArgb(87, 10, 87);
            btn_nuevo.BackColor = Color.FromArgb(169, 16, 121);
            textNombre.Focus();
        }
        void limpiar()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
            textEmail.Text = "";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
