using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinesV
{
    class especial
    {
        public double tintura(double importe)
        {
            Console.Write("El pago por el trabajo realizado al empleado sera de: ");
            return importe * 0.35;
        }
        public double tratamientos(double importe)
        {
            Console.WriteLine("Ingrese el porcentaje de la tintura: ");
            double tratamPorcentaje = int.Parse(Console.ReadLine());
            return importe * tratamPorcentaje;
        }


    }
}
