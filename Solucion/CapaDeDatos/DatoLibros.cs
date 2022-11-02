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
using System.Data.SqlClient;

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
                orden = "INSERT INTO libros(titulo,id_autor,id_editor,fechaPublic,edicion,id_categoria,id_idioma,pagina,id_estado,notas,stock,condicionLibro) VALUES('" + libroObj.Titulo + "','" + libroObj.Autor + "','" + libroObj.Editor + "','" + (libroObj.FechaPublic1).ToString("yyyy,MM,dd") + "','" + libroObj.Edicion + "','" + libroObj.Categoria + "','" + libroObj.Idioma + "','" + libroObj.Pagina + "','" + libroObj.Estado + "','" + libroObj.Notas + "','" + libroObj.Stock + "','" + libroObj.CondicionLib + "');";
            }
                
            if (accion == "Modificar")
            {
                orden = "update libros set titulo='" + libroObj.Titulo + "',id_autor='" + libroObj.Autor + "',id_editor='" + libroObj.Editor + "',fechaPublic='" + (libroObj.FechaPublic1).ToString("yyyy,MM,dd") + "' ,edicion='" + libroObj.Edicion + "',id_categoria='" + libroObj.Categoria + "',id_idioma='" + libroObj.Idioma + "',pagina='" + libroObj.Pagina + "',id_estado='" + libroObj.Estado + "',notas='" + libroObj.Notas + "',stock='" + libroObj.Stock + "',condicionLibro='" + libroObj.CondicionLib + "' where idLibros='" + libroObj.Id + "';";
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
           
                if (cual == "Todos")
                {
                    orden = "select idLibros,titulo,nombreAutor,Editorial,fechaPublic,edicion,Categoria,Idioma,pagina,Estado,notas,stock,condicionLibro from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado";
                }
                else if (cual == "disponible")
                {
                    orden = "select idLibros,titulo,nombreAutor,Editorial,fechaPublic,edicion,Categoria,Idioma,pagina,Estado,notas,stock,condicionLibro from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado where  estado.idEstado ='1' ;";
                }
                else if (cual == "nodisponible")
                {
                    orden = "select idLibros,titulo,nombreAutor,Editorial,fechaPublic,edicion,Categoria,Idioma,pagina,Estado,notas,stock,condicionLibro from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado where  estado.idEstado ='2' ;";
                }
            
                else if (cual == "reserva")
                {
                    orden = "select idLibros,titulo,nombreAutor,Editorial,fechaPublic,edicion,Categoria,Idioma,pagina,Estado,notas,stock,condicionLibro from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado where  estado.idEstado ='3' ;";
                }
                else if(cual == "la")
                {
                
                    orden = "select idLibros,titulo,nombreAutor,Editorial,fechaPublic,edicion,Categoria,Idioma,pagina,Estado,notas,stock,condicionLibro from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado where libros.idLibros ='" + int.Parse(cual) + "' || libros.titulo LIKE '%" +  cual + "%'|| autor.nombreAutor LIKE '%" + cual + "%' || idioma.Idioma LIKE '%" + cual + "%' || categoria.Categoria LIKE '%" + cual + "%' || editorial.Editorial LIKE '%" + cual + "%';";
                }
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
        public List<CategoriaClass> llenarcomboCategoria()
        {       
            string orden = string.Empty;
            CategoriaClass categoria = new CategoriaClass();
            orden = "select * from categoria order by idCategoria asc";
            List<CategoriaClass> lista = new List<CategoriaClass>();
            MySqlCommand da = new MySqlCommand(orden, conexion);
                try
                { 
                Abrirconexion();
                MySqlDataReader dr = da.ExecuteReader();
                while (dr.Read())
                    {
                        categoria.IdCategoria = dr.GetInt32(0);
                        categoria.NombCategoria = dr.GetString(1);
                        lista.Add(categoria);
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error al listar categoria", e);
                }
                finally
                {
                    Cerrarconexion();
                    da.Dispose();
                }
            return lista;
        }

        public List<AutorClass> llenarcomboAutor()
        {
            string orden = string.Empty;
            AutorClass autor = new AutorClass();
            orden = "select * from autor order by idAutor asc";
            List<AutorClass> lista = new List<AutorClass>();
            MySqlCommand da = new MySqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                MySqlDataReader dr = da.ExecuteReader();
                while (dr.Read())
                {
                    autor.IdAutor = dr.GetInt32(0);
                    autor.NombAutor = dr.GetString(1);
                    lista.Add(autor);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar autor", e);
            }
            finally
            {
                Cerrarconexion();
                da.Dispose();
            }
            return lista;
        }

        public List<EstadoClass> llenarcomboEstado()
        {
            string orden = string.Empty;
            EstadoClass estado = new EstadoClass();
            orden = "select * from estado order by idEstado asc";
            List<EstadoClass> lista = new List<EstadoClass>();
            MySqlCommand da = new MySqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                MySqlDataReader dr = da.ExecuteReader();
                while (dr.Read())
                {
                    estado.IdEstado = dr.GetInt32(0);
                    estado.NombEstado = dr.GetString(1);
                    lista.Add(estado);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar estado", e);
            }
            finally
            {
                Cerrarconexion();
                da.Dispose();
            }
            return lista;
        }

        public List<IdiomaClass> llenarcomboIdioma()
        {
            string orden = string.Empty;
            IdiomaClass idioma = new IdiomaClass();
            orden = "select * from idioma order by idIdioma asc";
            List<IdiomaClass> lista = new List<IdiomaClass>();
            MySqlCommand da = new MySqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                MySqlDataReader dr = da.ExecuteReader();
                while (dr.Read())
                {
                    idioma.IdIdioma = dr.GetInt32(0);
                    idioma.NombIdioma = dr.GetString(1);
                    lista.Add(idioma);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar idioma", e);
            }
            finally
            {
                Cerrarconexion();
                da.Dispose();
            }
            return lista;
        }

        public List<EditorialClass> llenarcomboEditorial()
        {
            EditorialClass editorial = new EditorialClass();
            string orden = string.Empty;
            orden = "select idEditorial,Editorial from editorial order by idEditorial asc";    
            MySqlCommand da = new MySqlCommand(orden, conexion);
            List<EditorialClass> lista = new List<EditorialClass>();
            try
            {
                Abrirconexion();
                MySqlDataReader dr = da.ExecuteReader();
                while (dr.Read())
                {
                    editorial.IdEditorial = dr.GetInt32(0);
                    editorial.NombEditorial = (dr.GetString(1)).ToUpper();
                    lista.Add(editorial);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar editorial", e);
            }
            finally
            {
                Cerrarconexion();
                da.Dispose();
            }
            return lista;
        }
    }
}
