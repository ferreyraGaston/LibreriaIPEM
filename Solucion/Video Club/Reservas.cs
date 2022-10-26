using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Video_Club
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conexión Exitosa");
                    button1.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "    Falla de Conexión");
            }
            con.Close();
        }

        private void RepPagos_Load(object sender, EventArgs e)
        {

        }
    }
}
