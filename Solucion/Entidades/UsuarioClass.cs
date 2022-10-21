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
        private string Nombre;
        private int Id;
        private string Apellido;
        private int Dni;
        private int TipoUsuario;
        private string Email;
        private string Direccion;
        private string Telefono;
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
