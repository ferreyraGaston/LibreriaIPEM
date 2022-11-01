using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySqlX.XDevAPI.Relational;
using System.Net.NetworkInformation;
using System.Data.OleDb;

namespace CapaDeDatos
{
    public class DatoLibros : Conexion
    {

        public int abmLibros(string accion, LibroClass libroObj)
        {
            int resultado = -1;
            string orden = string.Empty; // no crea ningun objeto en la memoria mientras que "" crea un nuevo objeto de cadena
            if (accion == "Alta")
            {
                orden = "INSERT INTO libros(titulo,id_autor,id_editor,fechaPublic,edicion,id_categoria,id_idioma,pagina,id_estado,notas,stock,condicionLibro) VALUES('" + libroObj.Titulo + "','" + libroObj.Autor + "','" + libroObj.Editor + "','" + libroObj.FechaPublic + "','" + libroObj.Edicion + "','" + libroObj.Categoria + "','" + libroObj.Idioma + "','" + libroObj.Pagina + "','" + libroObj.Estado + "','" + libroObj.Notas + "','" + libroObj.Stock + "','" + libroObj.CondicionLib + "');";
            }
                
            if (accion == "Modificar")
            {
                orden = "update libros set titulo='" + libroObj.Titulo + "',id_autor='" + libroObj.Autor + "',id_editor='" + libroObj.Editor + "',fechaPublic='" + libroObj.FechaPublic + "' ,edicion='" + libroObj.Edicion + "',id_categoria='" + libroObj.Categoria + "',id_idioma='" + libroObj.Idioma + "',pagina='" + libroObj.Pagina + "',id_estado='" + libroObj.Estado + "',notas='" + libroObj.Notas + "',stock='" + libroObj.Stock + "',condicionLibro='" + libroObj.CondicionLib + "' where idLibros='" + libroObj.Id + "';";
            }

            if (accion == "Eliminar")
            {
                orden = "delete from libros where idLibros='" + libroObj.Id + "';";
            }
            // falta la orden de borrar
            MySqlCommand cmd = new MySqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de Profesionales",e);
            }
            finally
            {
                Cerrarconexion(); // cerramos la conexion
                cmd.Dispose(); //liberamos el command
            }
            return resultado;
        }


        public DataSet listadoLibro(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
            orden = "select idLibros,titulo,nombreAutor,Editorial,fechaPublic,edicion,Categoria,Idioma,pagina,Estado,notas,stock,condicionLibro from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado where libros.idLibros ='" + int.Parse(cual) + "' || libros.titulo LIKE '%" + cual + "%'|| autor.nombreAutor LIKE '%" + cual + "%' || idioma.Idioma LIKE '%" + cual + "%' || categoria.Categoria LIKE '%" + cual + "%' || editorial.Editorial LIKE '%" + cual + "%';";
          
            else
                orden = "select idLibros as ID,titulo as TITULO,nombreAutor as AUTOR,Editorial as EDITORIAL,fechaPublic as FECHA,edicion as EDICION,Categoria as CATEGORIA,Idioma as IDIOMA,pagina as PAGINA,Estado as ESTADO,notas as NOTA,stock as STOCK,condicionLibro as CONDICIÓN from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado";
            MySqlCommand cmd = new MySqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar profesionales", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

    }
}
