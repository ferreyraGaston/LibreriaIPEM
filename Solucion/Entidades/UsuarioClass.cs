using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //internal class Usuario
    public class UsuarioClass
    {
        static private string Nombre;
        static private int Id;
        static private string Apellido;
        static private int Dni;
        static private int TipoUsuario;
        static private string Email;
        static private string Direccion;
        static private string Telefono;
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Id1 { get => Id; set => Id = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public int Dni1 { get => Dni; set => Dni = value; }
        public int TipoUsuario1 { get => TipoUsuario; set => TipoUsuario = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
    }
}
