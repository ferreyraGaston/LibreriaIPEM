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
            CargarTextbox();;
            estadoUsuario();
        }
        void CargarTextbox()
        {
            UsuarioClass usuarioObj2 = new UsuarioClass();
            //MessageBox.Show("nombre " + usuarioObj2.Nombre1);
            textNombre.Text = usuarioObj2.Nombre1;
            textApellido.Text = usuarioObj2.Apellido1;
            textDireccion.Text = usuarioObj2.Direccion1;
            textTelefono.Text = usuarioObj2.Telefono1;
            textEmail.Text = usuarioObj2.Email1;
            textDni.Text = Convert.ToString(usuarioObj2.Dni1);
            textTipoUsuario.Text = Convert.ToString(usuarioObj2.TipoUsuario1);
        }
        void estadoUsuario()
        {
            UsuarioClass usuarioObj = new UsuarioClass();

            if (usuarioObj.Estado == true)
            {
                
                btn_eliminar.Enabled = true;
                btn_modificar.Enabled = true;
                btn_agregar.Enabled = false;
                btn_nuevo.Enabled = false;
                btn_eliminar.BackColor = Color.FromArgb(169, 16, 121);
                btn_modificar.BackColor = Color.FromArgb(169, 16, 121);
                btn_agregar.BackColor = Color.FromArgb(87, 10, 87);
                btn_nuevo.BackColor = Color.FromArgb(87, 10, 87);
                textNombre.Focus();
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
                textNombre.Focus();
            }
            

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
            usuarioObj.Nombre1 = textNombre.Text;
            usuarioObj.Apellido1 = textApellido.Text;
            usuarioObj.Direccion1 = textDireccion.Text;
            usuarioObj.Telefono1 = textTelefono.Text;
            usuarioObj.Email1 = textEmail.Text;
            usuarioObj.Dni1 = Convert.ToInt32(textDni.Text);
            usuarioObj.TipoUsuario1 = Convert.ToInt32(textTipoUsuario.Text);
            usuarioObj.EstadoUsuario = 0;

            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            string sql = "INSERT INTO usuario(NombreUsuario,ApellidoUsuario,DniUsuario,TipoUsuario,email,direccion,telefono,estadoUsuario) VALUES('" + usuarioObj.Nombre1 + "','" + usuarioObj.Apellido1 + "','" + usuarioObj.Dni1 + "','" + usuarioObj.TipoUsuario1 + "','" + usuarioObj.Email1 + "','" + usuarioObj.Direccion1 + "','" + usuarioObj.Telefono1 + "','" + usuarioObj.EstadoUsuario + "')";
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
            usuarioObj.Nombre1 = textNombre.Text;
            usuarioObj.Apellido1 = textApellido.Text;
            usuarioObj.Direccion1 = textDireccion.Text;
            usuarioObj.Telefono1 = textTelefono.Text;
            usuarioObj.Email1 = textEmail.Text;
            usuarioObj.Dni1 = Convert.ToInt32(textDni.Text);
            usuarioObj.TipoUsuario1 = Convert.ToInt32(textTipoUsuario.Text);

            string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
            string sql = "update usuario set NombreUsuario='" + usuarioObj.Nombre1 + "',ApellidoUsuario='" + usuarioObj.Apellido1 + "',DniUsuario='" + usuarioObj.Dni1 + "',TipoUsuario='" + usuarioObj.TipoUsuario1 + "' ,email='" + usuarioObj.Email1 + "',direccion='" + usuarioObj.Direccion1 + "',telefono='" + usuarioObj.Telefono1 + "' where id_usuario='" + usuarioObj.Id1 + "';";
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
            if (MessageBox.Show("el Id: " + usuarioObj.Id1, "Estas Seguro que deseas Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
                string sql = "delete from usuario where id_usuario='" + usuarioObj.Id1 + "';";
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
        private void BorrarError()
        {
            errorProvider1.SetError(textNombre, "");
            errorProvider1.SetError(textApellido, "");
            errorProvider1.SetError(textTelefono, "");
            errorProvider1.SetError(textDni, "");
            errorProvider1.SetError(textDireccion, "");
            errorProvider1.SetError(textTipoUsuario, "");
            errorProvider1.SetError(textEmail, "");
        }
        private bool ValidarCampos()
        {
            bool validarOk = true;
            if (textNombre.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(textNombre, "Ingresar el nombre");
            }
            if (textApellido.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(textApellido, "Ingresar el apellido");
            }
            if (textTelefono.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(textTelefono, "Ingresar el télefono");
            }
            if (textDni.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(textDni, "Ingresar el DNI");
            }
            if (textDireccion.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(textDireccion, "Ingresar la dirección");
            }
            if (textTipoUsuario.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(textTipoUsuario, "Seleccione el tipo de usuario");
            }
            //
            if (textEmail.Text == "")
            {
                validarOk = false;
                errorProvider1.SetError(textEmail, "Ingrese el email");
            }     

            return validarOk;
        }

        private void textNombre_Validating(object sender, CancelEventArgs e)
        {
            bool error = false;
            foreach (Char caracter in textNombre.Text)
                if (char.IsDigit(caracter)) // recorre caracter por caracter buscando un char
                {
                    error = true;
                    break;
                }
                else
                {
                    
                }

            if (error)
            {
                errorProvider1.SetError(textNombre, "No se admiten nomeros");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textApellido_Validating(object sender, CancelEventArgs e)
        {
            bool error = false;
            foreach (Char caracter in textApellido.Text)
                if (char.IsDigit(caracter)) // recorre caracter por caracter buscando un char
                {
                    error = true;
                    break;
                }
                else
                {

                }

            if (error)
            {
                errorProvider1.SetError(textApellido, "No se admiten nomeros");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textTelefono_Validating(object sender, CancelEventArgs e)
        {
            bool error = false;
            foreach (Char caracter in textTelefono.Text)
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
                errorProvider1.SetError(textTelefono, "No se admiten letras");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textDni_Validating(object sender, CancelEventArgs e)
        {
            bool error = false;
            foreach (Char caracter in textDni.Text)
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
                errorProvider1.SetError(textDni, "No se admiten letras");

            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
