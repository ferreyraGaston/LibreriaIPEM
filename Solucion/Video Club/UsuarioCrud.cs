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
    public partial class UsuarioCrud : Form
    {
        public UsuarioCrud()
        {
            InitializeComponent();
            CargarTextbox();
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
        void CargarTextbox()
        {
            UsuarioClass usuarioObj2 = new UsuarioClass();
            MessageBox.Show("nombre " + usuarioObj2.Nombre);
            textNombre.Text = usuarioObj2.Nombre;
            textApellido.Text = usuarioObj2.Apellido;
            textDireccion.Text = usuarioObj2.Direccion;
            textTelefono.Text = usuarioObj2.Telefono;
            textEmail.Text = usuarioObj2.Email;
            textDni.Text = Convert.ToString(usuarioObj2.Dni);
            textTipoUsuario.Text = Convert.ToString(usuarioObj2.TipoUsuario);
        }
        void limpiar()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
            textEmail.Text = "";
            textDni.Text = "";
            textTipoUsuario.Text = "";
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            UsuarioClass usuarioObj = new UsuarioClass();
            usuarioObj.Nombre = textNombre.Text;
            usuarioObj.Apellido = textApellido.Text;
            usuarioObj.Direccion = textDireccion.Text;
            usuarioObj.Telefono = textTelefono.Text;
            usuarioObj.Email = textEmail.Text;
            usuarioObj.Dni = Convert.ToInt32(textDni.Text);
            usuarioObj.TipoUsuario = Convert.ToInt32(textTipoUsuario.Text);

            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            string sql = "INSERT INTO usuario(NombreUsuario,ApellidoUsuario,DniUsuario,TipoUsuario,email,direccion,telefono) VALUES('" + usuarioObj.Nombre + "','" + usuarioObj.Apellido + "','" + usuarioObj.Dni + "','" + usuarioObj.TipoUsuario + "','" + usuarioObj.Email + "','" + usuarioObj.Direccion + "','" + usuarioObj.Telefono + "')";
            MySqlConnection con = new MySqlConnection(cadena);
            con.Open();
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se ingresaron exitosamente");
            con.Close();
            limpiar();
   
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            UsuarioClass usuarioObj = new UsuarioClass();
            usuarioObj.Nombre = textNombre.Text;
            usuarioObj.Apellido = textApellido.Text;
            usuarioObj.Direccion = textDireccion.Text;
            usuarioObj.Telefono = textTelefono.Text;
            usuarioObj.Email = textEmail.Text;
            usuarioObj.Dni = Convert.ToInt32(textDni.Text);
            usuarioObj.TipoUsuario = Convert.ToInt32(textTipoUsuario.Text);

            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            string sql = "update usuario set NombreUsuario='" + usuarioObj.Nombre + "',ApellidoUsuario='" + usuarioObj.Apellido + "',DniUsuario='" + usuarioObj.Dni + "',TipoUsuario='" + usuarioObj.TipoUsuario + "' ,email='" + usuarioObj.Email + "',direccion='" + usuarioObj.Direccion + "',telefono='" + usuarioObj.Telefono + "' where id_usuario='" + usuarioObj.Id + "';";
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
            textNombre.Focus();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            UsuarioClass usuarioObj = new UsuarioClass();
            if (MessageBox.Show("el Id: " + usuarioObj.Id, "Estas Seguro que deseas Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
                string sql = "delete from usuario where id_usuario='" + usuarioObj.Id + "';";
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
