using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PrestamoClass
    {
        static private int idUsuario;
        static private int idLibro;

        public  int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public  int IdLibro { get => idLibro; set => idLibro = value; }
    }
}
