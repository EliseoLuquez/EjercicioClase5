using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEntidades
{
    public class Estanteria
    {
        private int estanteriaUbicacion;
        private Producto[] productos;


        private Estanteria(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estanteria(int capacidad, int ubicacion): this(capacidad)
        {   
            this.estanteriaUbicacion = ubicacion;
        }

        public Producto[] GetProducto()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estanteria e)
        {
            string salida = e.estanteriaUbicacion.ToString();

            foreach (Producto producto in e.productos)
            {
                if(!(producto is null))
                    salida += (" " +  Producto.MostrarProducto(producto));
            }
            return salida;
        }

        public  static  bool operator ==(Estanteria e, Producto p)
        {
            foreach (Producto producto in e.productos)
            {
                if (producto == p)
                    return true;
            }
            return false;
        }


        public static bool operator !=(Estanteria e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estanteria e, Producto p)
        {
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }                
            }

            return false;
        }

        public static Estanteria operator -(Estanteria e, Producto p)
        {
            
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        i = e.productos.Length;
                    }
                }            
            return e;
        }
    }
}
