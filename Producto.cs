using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Producto
    {

        string nombre = "celular";
        string descripcion = "Iphone 8 plus, Gold, 128GB, $25000";

        public void AgregarNombre(string name)
        {
            name = nombre;

        }
        public void ProductoDisponible()
        {
            Console.WriteLine("Producto " + nombre + " " + descripcion);
            Console.ReadLine();
        }
    }
}
