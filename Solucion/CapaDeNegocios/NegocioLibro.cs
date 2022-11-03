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

        public int abmLibrosNegocio(string accion, LibroClass libroObj)
        {
            return datosLibros.abmLibros(accion, libroObj); 
        }

        public DataSet listadoLibroNegocio(string cual)
        {
            return datosLibros.listadoLibro(cual);
        }

        public List<CategoriaClass> llenarcomboCategoriaNegocio()
        {
            return datosLibros.llenarcomboCategoria();
        }

        public List<AutorClass> llenarcomboAutorNegocio()
        {
            return datosLibros.llenarcomboAutor();  
        }

        public List<EstadoClass> llenarcomboEstadoNegocio()
        {
            return datosLibros.llenarcomboEstado();
        }

        public List<IdiomaClass> llenarcomboIdiomaNegocio()
        {
            return datosLibros.llenarcomboIdioma();
        }

        public List<EditorialClass> llenarcomboEditorialNegocio()
        {
            return datosLibros.llenarcomboEditorial();
        }

    }
}
