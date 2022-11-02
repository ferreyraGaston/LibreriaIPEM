using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class IdiomaClass
    {
        private int idIdioma;
        private string nombIdioma;

        public int IdIdioma { get => idIdioma; set => idIdioma = value; }
        public string NombIdioma { get => nombIdioma; set => nombIdioma = value; }

        public IdiomaClass()
        {

        }
    }
}
