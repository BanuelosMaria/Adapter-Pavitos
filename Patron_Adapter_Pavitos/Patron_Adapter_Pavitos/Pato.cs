using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Adapter_Pavitos
{
    //Bañuelos Hernandez María Guadalupe   No.Control: 19211600

    public class Pato : IPato
    {

        //Implementacion delmetodo graznar de la interfaz de IPato
        public void Graznar()
        {
            Console.WriteLine("El pato hace Quack-Quack");
        }
        public void Volar()
        {
            Console.WriteLine("El pato puede volar");
        }
    }
}
