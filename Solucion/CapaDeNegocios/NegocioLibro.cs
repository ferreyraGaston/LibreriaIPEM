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
    internal class NegocioLibro
    {

        public static DataTable Listar()
        {
            DatoLibros datos=new DatoLibros();
            return datos.Listar();
        }

        public static DataTable Buscar(string valor)
        {
            DatoLibros datos = new DatoLibros();
            return datos.Buscar(valor); 
        }

        public static string Insertar(string titulo, int autor, int editor, string fechaPublic, string edicion, int categoria, int idioma, int pagina, int estado, string notas, int stock, int condicionLib)
        {
            DatoLibros datos = new DatoLibros();
            LibroClass obj = new LibroClass();
            obj.Titulo= titulo; 
            obj.Autor= autor;
            obj.Editor= editor;
            obj.FechaPublic= fechaPublic;
            obj.Edicion= edicion;
            obj.Categoria= categoria;
            obj.Idioma= idioma;
            obj.Pagina= pagina;
            obj.Estado= estado;
            obj.Notas= notas;
            obj.Stock= stock;
            obj.CondicionLib= condicionLib;

            return datos.Insertar(obj); // insertar el que esta en DatoLibros
        }

        public static string Actualizar(int id, string titulo, int autor, int editor, string fechaPublic, string edicion, int categoria, int idioma, int pagina, int estado, string notas, int stock, int condicionLib)
        {
            DatoLibros datos = new DatoLibros();
            LibroClass obj = new LibroClass();
            obj.Id = id;
            obj.Titulo = titulo;
            obj.Autor = autor;
            obj.Editor = editor;
            obj.FechaPublic = fechaPublic;
            obj.Edicion = edicion;
            obj.Categoria = categoria;
            obj.Idioma = idioma;
            obj.Pagina = pagina;
            obj.Estado = estado;
            obj.Notas = notas;
            obj.Stock = stock;
            obj.CondicionLib = condicionLib;

            return datos.Actualizar(obj); // insertar el que esta en DatoLibros
        }

        public static string Eliminar(int id)
        {
            DatoLibros datos = new DatoLibros();
            return datos.Eliminar(id);
        }

    }
}
