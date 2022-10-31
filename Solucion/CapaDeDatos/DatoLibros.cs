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

namespace CapaDeDatos
{
    public class DatoLibros
    {

        public DataTable Listar()
        {
            MySqlDataReader resultado;  //nos permite leer una secuencia de tabla de Mysql
            DataTable tabla= new DataTable();
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion= Conexion.crearInstancia().CrearConexion();
                //string sql = "select idLibros as ID,titulo as TITULO,nombreAutor as AUTOR,Editorial as EDITORIAL,fechaPublic as FECHA,edicion as EDICION,Categoria as CATEGORIA,Idioma as IDIOMA,pagina as PAGINA,Estado as ESTADO,notas as NOTA,stock as STOCK,condicionLibro as CONDICIÓN from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado";
                string sql = "select * from libros";
                MySqlCommand comando=new MySqlCommand(sql, conexion);
                comando.CommandType = CommandType.StoredProcedure; // nos conectamos con el procedimiento almacenado
                conexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;   
            }
            catch(Exception ex)
            {
                throw ex; //mostramos un mensaje con el error establecido
     
            }
            finally
            {
                if(conexion.State==ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public DataTable Buscar(String valor)
        {
            MySqlDataReader resultado;  //nos permite leer una secuencia de tabla de Mysql
            DataTable tabla = new DataTable();
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().CrearConexion();
                string sql = "select idLibros,titulo,nombreAutor,Editorial,fechaPublic,edicion,Categoria,Idioma,pagina,Estado,notas,stock,condicionLibro from libros INNER JOIN categoria On libros.id_categoria = categoria.idCategoria INNER JOIN autor On libros.id_autor = autor.idAutor INNER JOIN editorial On libros.id_editor = editorial.idEditorial INNER JOIN idioma On libros.id_idioma = idioma.idIdioma INNER JOIN estado On libros.id_estado = estado.idEstado where libros.idLibros ='" + valor + "' || libros.titulo LIKE '%" + valor + "%'|| autor.nombreAutor LIKE '%" + valor + "%' || idioma.Idioma LIKE '%" + valor + "%' || categoria.Categoria LIKE '%" + valor + "%' || editorial.Editorial LIKE '%" + valor + "%';";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.CommandType = CommandType.StoredProcedure; // nos conectamos con el procedimiento almacenado
                conexion.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex; //mostramos un mensaje con el error establecido
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public string Insertar(LibroClass obj)
        {
            string respuesta = "";
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().CrearConexion();
                string sql = "INSERT INTO libros(titulo,id_autor,id_editor,fechaPublic,edicion,id_categoria,id_idioma,pagina,id_estado,notas,stock,condicionLibro) VALUES('" + obj.Titulo + "','" + obj.Autor + "','" + obj.Editor + "','" + obj.FechaPublic + "','" + obj.Edicion + "','" + obj.Categoria + "','" + obj.Idioma + "','" + obj.Pagina + "','" + obj.Estado + "','" + obj.Notas + "','" + obj.Stock + "','" + obj.CondicionLib + "')";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.CommandType = CommandType.StoredProcedure; // nos conectamos con el procedimiento almacenado
                conexion.Open();
                if(comando.ExecuteNonQuery() == 1)
                    {
                        respuesta = "Ok";
                    }
                    else
                    {
                        respuesta = "No Ok";
                    }
             }
            catch (Exception ex)
            {
                respuesta= ex.Message; //mostramos un mensaje con el error establecido
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }


        public string Actualizar(LibroClass obj)
        {
            string respuesta = "";
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().CrearConexion();
                string sql = "update libros set titulo='" + obj.Titulo + "',id_autor='" + obj.Autor + "',id_editor='" + obj.Editor + "',fechaPublic='" + obj.FechaPublic + "' ,edicion='" + obj.Edicion + "',id_categoria='" + obj.Categoria + "',id_idioma='" + obj.Idioma + "',pagina='" + obj.Pagina + "',id_estado='" + obj.Estado + "',notas='" + obj.Notas + "',stock='" + obj.Stock + "',condicionLibro='" + obj.CondicionLib + "' where idLibros='" + obj.Id + "';";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.CommandType = CommandType.StoredProcedure; // nos conectamos con el procedimiento almacenado
                conexion.Open();
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "Ok";
                }
                else
                {
                    respuesta = "No Ok";
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message; //mostramos un mensaje con el error establecido
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }

        public string Eliminar(int id)
        {
            string respuesta = "";
            MySqlConnection conexion = new MySqlConnection();
            try
            {
                conexion = Conexion.crearInstancia().CrearConexion();
                string sql = "delete from libros where idLibros='" + id + "';";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.CommandType = CommandType.StoredProcedure; // nos conectamos con el procedimiento almacenado
                conexion.Open();
                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "Ok";
                }
                else
                {
                    respuesta = "No Ok";
                }
            }
            catch (Exception ex)
            {
                respuesta = ex.Message; //mostramos un mensaje con el error establecido
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return respuesta;
        }
    }
}
