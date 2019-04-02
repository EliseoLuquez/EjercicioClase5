using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntidades
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.marca = marca;
            this.precio = precio;
            this.codigoDeBarra = codigoDeBarra;
        }

        public string GetMarca()
        {

            return this.marca;

        }
        public float GetPrecio()
        {
            return this.precio;

        }

        public static string MostrarProducto(Producto p)
        {   
            return  "Codigo de barra :"  + (string)p +  "  Marca:" + p.GetMarca() + " Precio:" + p.GetPrecio();
        }

        public override bool Equals(object obj)
        {
            if (obj is Producto)
                return this == (Producto)obj;
            else if (obj is string )
                return this == (string)obj;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto a, Producto b)
        {
            if ((a is null) || (b is null))
                   return false;
            return ((string)a == (string)b && a.GetMarca() == b.GetMarca());
                
        }

        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

        public static bool operator ==(Producto a, string marca)
        {
            return a.GetMarca() == marca;// ? true : false;
        }

        public static bool operator !=(Producto a, string marca)
        {
            return !(a == marca);
        }


    }
}
