using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDeDatos;
using Entidades;
using System.Runtime.InteropServices;

namespace CapaDeNegocios
{
    public class NegocioLibro : DatoLibros
    {
        DatoLibros datosLibros= new DatoLibros();

        public int abmLibros(string accion, LibroClass libroObj)
        {
            return datosLibros.abmLibros(accion, libroObj); 
        }

        public DataSet listadoLibro(string cual)
        {
            return datosLibros.listadoLibro(cual);
        }

    }
}
