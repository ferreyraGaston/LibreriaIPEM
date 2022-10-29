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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Video_Club
{
    public partial class Conexion : Form
    {
        public Conexion()
        {
            InitializeComponent();
        }

        public string Cadena { get; internal set; }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    PruebaCon pruebaCon = new PruebaCon();
                    pruebaCon.ShowDialog();
                    
                }
            }
            catch
            {
                PruebaNoCon pruebaNoCon = new PruebaNoCon();
                pruebaNoCon.ShowDialog();
            }
            con.Close();
        }
    }
}
