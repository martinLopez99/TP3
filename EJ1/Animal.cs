using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    public class Animal
    {
        public void Correr()
        {
            Console.WriteLine("Corriendo");
        }

        public void Saltar()
        {
            Console.WriteLine("Salta");
        }

        public virtual void HacerRuido()
        {

        }
    }
}
