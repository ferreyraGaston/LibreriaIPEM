using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conexion
    {

        protected MySqlConnection conexion;
        protected string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";

        public Conexion(string cadena)
        {
            this.cadena = cadena;
        }

        public string Cadena { get => cadena; set => cadena = value; }
    }
}
