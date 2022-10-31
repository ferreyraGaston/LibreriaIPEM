using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  // agregamos la libreria necesaria para poder trabajar con los metodos necesarios


namespace CapaDeDatos
{
    public class Conexion
    {

        protected string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";
        protected MySqlConnection conexion; // protected lo de la misma clases y los que estan hederados

        public Conexion()
        {

          conexion = new MySqlConnection(cadena);

        }
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }

}

