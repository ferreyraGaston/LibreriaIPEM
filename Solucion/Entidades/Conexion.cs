using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Conexion
    {
        static private string cadena = "Server=localhost;Database=libreria_bd;Uid=root;Pwd=13231414";

        public string Cadena { get => cadena; set => cadena = value; }
    }
}
