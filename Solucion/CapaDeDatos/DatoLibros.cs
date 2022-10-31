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
                orden = "INSERT INTO libros(titulo,id_autor,id_editor,fechaPublic,edicion,id_categoria,id_idioma,pagina,id_estado,notas,stock,condicionLibro) VALUES('" + libroObj.Titulo + "','" + libroObj.Autor + "','" + libroObj.Editor + "','" + libroObj.FechaPublic + "','" + libroObj.Edicion + "','" + libroObj.Categoria + "','" + libroObj.Idioma + "','" + libroObj.Pagina + "','" + libroObj.Estado + "','" + libroObj.Notas + "','" + libroObj.Stock + "','" + libroObj.CondicionLib + "');";
            if (accion == "Modificar")
                orden = "update libros set titulo='" + libroObj.Titulo + "',id_autor='" + libroObj.Autor + "',id_editor='" + libroObj.Editor + "',fechaPublic='" + libroObj.FechaPublic + "' ,edicion='" + libroObj.Edicion + "',id_categoria='" + libroObj.Categoria + "',id_idioma='" + libroObj.Idioma + "',pagina='" + libroObj.Pagina + "',id_estado='" + libroObj.Estado + "',notas='" + libroObj.Notas + "',stock='" + libroObj.Stock + "',condicionLibro='" + libroObj.CondicionLib + "' where idLibros='" + libroObj.Id + "';";
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
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }


        public DataSet listadoProfesionales(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Profesionales where CodProf = " + int.Parse(cual) + ";";
            else
                orden = "select * from Profesionales;";
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
