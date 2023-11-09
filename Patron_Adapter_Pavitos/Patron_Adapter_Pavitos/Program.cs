using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Adapter_Pavitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bañuelos Hernandez María Guadalupe   No.Control: 19211600

            Console.Title = "Patron Adapter, lo que pasa si unes un pato y un pavo...";
            //Se crea objeto pavo y pato
            Pavo pavo = new Pavo();
            Pato pato = new Pato();

            //Se crea objeto para camuflajear al pavo adaptando a un pato
            IPato pavocamuflajeado = new PavoAdapter(pavo);


            Console.WriteLine("\tDesarrollo Patrón Adapter\n");
            Console.WriteLine("Nombre: Bañuelos Hernandez María Guadalupe");
            Console.WriteLine("No. Control: 19211600");
            Console.WriteLine("\n [ ... ] \n");

            Console.WriteLine("Desarrollo Patrón Adapter\n");

            //Comportamiento del pavo
            Console.WriteLine("--- P A V O ---");
            Console.WriteLine("Comportamiento del pavo: ");
            pavo.Gogotea();
            pavo.Vuela();

            //Comportamiento del pato
            Console.WriteLine("\n--- P A T O ---");
            Console.WriteLine("Comportamiento del pato: ");
            pato.Graznar();
            pato.Volar();

            //Comportamiento del pavo  camuflajeado como pato
            Console.WriteLine("\n--- P A T O 2.0 ---");
            Console.WriteLine("Comportamiento del pavo que se cree pato: ");
            pavocamuflajeado.Graznar();
            pavocamuflajeado.Volar();
            Console.ReadLine();
        }
    }
}
