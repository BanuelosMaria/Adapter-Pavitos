using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Adapter_Pavitos
{
    //Bañuelos Hernandez María Guadalupe   No.Control: 19211600

    //Clase para adaptar un pavo como un pato
    public class PavoAdapter : IPato
    {
        private Pavo pavo;

        //Constructor
        public PavoAdapter(Pavo pavo)
        {
            this.pavo = pavo;
        }

        //Implementacion del metodo graznar
        public void Graznar()
        {

            //Llama al metodo de gorgoteo del pavo
            pavo.Gogotea();
        }
        public void Volar()
        {
            pavo.Vuela();
        }
    }
}
