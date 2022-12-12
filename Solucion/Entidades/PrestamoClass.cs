using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PrestamoClass
    {
        static private int idPrestamo;
        static private int idUsuario;
        static private int idLibro;
        static private int stock;
        static private int idEstadoLibro;
        static private DateTime fechaSalida = new DateTime();
        static private DateTime fechaEntrega = new DateTime();

        static private DateTime fechaDevolucion = new DateTime();
        static private bool condicion;
        static private double mora;

        public  DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public  DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public double Mora { get => mora; set => mora = value; }

        public int IdPrestamo { get => idPrestamo; set => idPrestamo = value; }
        public int Stock { get => stock; set => stock = value; }
        public int IdEstadoLibro { get => idEstadoLibro; set => idEstadoLibro = value; }
        public bool Condicion { get => condicion; set => condicion = value; }
        public  int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public  int IdLibro { get => idLibro; set => idLibro = value; }
    }
}
