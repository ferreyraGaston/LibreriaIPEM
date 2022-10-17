using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    // el modificador de acceso por defecto es internal.
    // necesito cambiar el modificador de acceso
    // por publico para que se pueda visualizar

    public class Producto
    {
        #region Atributos
        /***************DEFINO LOS ATRIBUTOS*******************/

        //agrego el modificador de acceso private para resetar el 
        //encapsulamiento de los objetos
        private int codigo;
        private string descripcion;
        private int stock;
        private int precio;
        #endregion

        #region Propiedades
        /***************DEFINO LAS PROPIEDADES*******************/

        // para poder acceder desde otra clase, necesito crear propiedades
        // para extraer las variables de tipo private
        // esta propiedad sirve para manupular el codigo
        public int p_codigo
        {
            set { this.codigo = value;}
            get { return this.codigo; }
        }
        public String p_descripcion
        {
            set { this.descripcion = value; }
            get { return this.descripcion; }
        }

        // El stock no se va  a modificar desde afuera, lo va a hacer
        // desde los metodos que estan dentro de la clase
        public int p_stock
        {
         // set { this.stock = value;}
            get { return this.stock; }
        }
        public int p_precio
        {
            set { this.precio = value;} 
            get { return this.precio; }
        }
    

        #endregion

        #region Constructor
        /**********DEFINO EL CONSTRUCTOR POR DEFECTO**********/
        // por lo general son publicos y llevan el nombre de la clase

        public Producto()
        {
        }

        /**********DEFINO EL CONSTRUCTOR**********/
        // los contructor sirve para inicializar los objetos

        public Producto(int codigo, string descripcion, int precio)
        {
            this.codigo = codigo;          
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = 0;
        }

     
        #endregion
        #region Metodos
        /**********CREO UN METODO INGRESO**********/
        // Para ingresar datos al stock

        public void Ingreso(int cantidad)
        {
            this.stock = this.stock + cantidad;
        }

        /**********CREO UN METODO INGRESO**********/
        // Para egresar datos al stock

        public void Engreso(int cantidad)
        {
            this.stock = this.stock - cantidad;
        }
        #endregion
    }
}
