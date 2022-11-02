using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AutorClass
    {
        private int idAutor;
        private string nombAutor;

        public int IdAutor { get => idAutor; set => idAutor = value; }
        public string NombAutor { get => nombAutor; set => nombAutor = value; }
    }
}
