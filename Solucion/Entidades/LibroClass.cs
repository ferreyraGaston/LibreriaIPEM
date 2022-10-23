using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class LibroClass
    {
        static private int id;
        static private string titulo;
        static private int autor;
        static private int editor;
        static private DateTime fechaPublic;
        static private string edicion;
        static private int categoria;
        static private int idioma;
        static private int pagina;
        static private int estado;
        static private string notas;
        static private int stock;
        static private int condicionLib;
        static private bool estadoLibro;

        static private string autorCo;
        static private string editorCo;
        static private string categoriaCo;
        static private string idiomaCo;
        static private string estadoCo;

        public string AutorCo { get => autorCo; set => autorCo = value; }
        public string EditorCo { get => editorCo; set => editorCo = value; }
        public string CategoriaCo { get => categoriaCo; set => categoriaCo = value; }
        public string IdiomaCo { get => idiomaCo; set => idiomaCo = value; }
        public string EstadoCo { get => estadoCo; set => estadoCo = value; }
        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int Autor { get => autor; set => autor = value; }
        public int Editor { get => editor; set => editor = value; }
        public DateTime FechaPublic { get => fechaPublic; set => fechaPublic = value; }
        public string Edicion { get => edicion; set => edicion = value; }
        public int Categoria { get => categoria; set => categoria = value; }
        public int Idioma { get => idioma; set => idioma = value; }
        public int Pagina { get => pagina; set => pagina = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Notas { get => notas; set => notas = value; }
        public int Stock { get => stock; set => stock = value; }
        public int CondicionLib { get => condicionLib; set => condicionLib = value; }
        public bool EstadoLibro { get => estadoLibro; set => estadoLibro = value; }
    }
}
