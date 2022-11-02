using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CategoriaClass
    {
        private int idCategoria;
        private string nombCategoria;

        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string NombCategoria { get => nombCategoria; set => nombCategoria = value; }
    }
}
