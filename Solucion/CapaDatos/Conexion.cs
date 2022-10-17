using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;



namespace CapaDatos
{
    public class Conexion
    {
        public void conectar()
        {
            string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\\BD Toldito\\Prueba\\BD\\BD_Bibloteca_V1.mdb";
            OleDbConnection con = new OleDbConnection(cadena);
            con.Open();
        }
    }

   
}