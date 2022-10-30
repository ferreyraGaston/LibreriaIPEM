using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  // agregamos la libreria necesaria para poder trabajar con los metodos necesarios


namespace CapaDeDatos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;// tipo de conexion true=windows , false= Mysql
        private static Conexion con=null;

        public Conexion()
        {
            this.Base = "libreria_bd";
            this.Servidor = "localhost";
            this.Usuario = "root";
            this.Clave = "13231414";
            this.Seguridad= true;  
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena= new MySqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                //validamos el tipo de seguridad
                if(this.Seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security= SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" +this.Usuario+";Password="+this.Clave;
                }               
            }
            catch(Exception ex)
            {
                cadena = null;
                throw ex; //mostramos un mensaje con el error establecido
            }
            return cadena;
        }
        // generar una instancia al constructor de esta clase

        public static Conexion crearInstancia()
        {
            if(con == null)
            {
                con = new Conexion();
            }
            return con;
        }

    }
}
