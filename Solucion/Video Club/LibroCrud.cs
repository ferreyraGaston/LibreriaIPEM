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
    public partial class LibroCrud : Form
    {
        public LibroCrud()
        {
            InitializeComponent();
            listarCategoria();
            listarAutor();
            listarIdioma();
            listarEditorial();
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

    }
}
