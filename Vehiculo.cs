using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class Vehiculo
    {
        string marca = "Honda";
        string modelo = "Civic";
        string year = "2015";
        string color = "rosado";

        public void On()
        {
            Console.WriteLine("El vehiculo esta encendido");
            Console.ReadLine();
        }
        public void off()
        { 
            Console.WriteLine("El vehiculo esta apagado");
            Console.ReadLine();


        }
        public void DatosVehiculo()
        {
            Console.WriteLine("Los datos del vehiculo: " + marca + " " + modelo + " " + year + " " + color);
            Console.ReadLine();

        }



    }
}
