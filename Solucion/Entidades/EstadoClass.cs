using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadoClass
    {

        private int idEstado;
        private string nombEstado;

        public int IdEstado { get => idEstado; set => idEstado = value; }
        public string NombEstado { get => nombEstado; set => nombEstado = value; }
    }
}
