using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EditorialClass
    {
        private int idEditorial;
        private string nombEditorial;

        public int IdEditorial { get => idEditorial; set => idEditorial = value; }
        public string NombEditorial { get => nombEditorial; set => nombEditorial = value; }
    }
}
