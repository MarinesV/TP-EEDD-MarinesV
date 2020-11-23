using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarinesV
{

    class Program
    {
        static void Main(string[] args)
        {
            especial trataSpecial = new especial();
            //Console.WriteLine("Ingrese la cantidad de dolares");
            //double dolares = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(trataSpecial.tintura(dolares));
            calculoCliente();

        }

        static public void calculoCliente()
        {
            Console.WriteLine("Ingrese el nombre del cliente ");
            string cliente = Console.ReadLine();
            Console.WriteLine("Desea calcular la cuenta del cliente?[si/no]");
            string cuenta = Console.ReadLine();
            double totalApagar = 0;
            while (cuenta != "no")
            {
                Console.WriteLine("Ingrese el nombre del empleado que lo atendio ");
                string empleado = Console.ReadLine();
                Console.WriteLine($"Ingrese el tipo de trtamiento que se realizo: [secado/ corte / manicura simple/ manicura especial / tintura / Hidratacion] ");
                string tratamiento = Console.ReadLine();
                if (tratamiento == "secado" | tratamiento == "corte" | tratamiento == "manicura simple" | tratamiento == "manicura especial" | tratamiento == "tintura" | tratamiento == "Hidratacion")
                {
                    Console.WriteLine("Ingrese el precio del tratamiento seleccionado");
                    double importe = int.Parse(Console.ReadLine());
                    totalApagar += importe;
                    Console.WriteLine("Desea continuar cargando tratamientos?");
                    cuenta = Console.ReadLine();
                }
                else Console.WriteLine("Ingresa una opcion correcta");
            }
            Console.WriteLine($"El total a pagar es de: {totalApagar}");
            Console.WriteLine("Desea cargar otro cliente?");
            string againC = Console.ReadLine();
            if (againC == "si")
            {
                calculoCliente();
            }
            else Console.WriteLine("Bye");
        }
    }
}