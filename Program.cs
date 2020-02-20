using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo k = new Vehiculo();
            k.DatosVehiculo();
            Console.WriteLine();
            k.off();

        }
    }
}
