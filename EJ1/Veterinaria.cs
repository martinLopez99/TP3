using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    public class Veterinaria
    {
        public void AceptarAnimales( Animal[] pAnimales)
        {
            foreach (Animal i in pAnimales)
            {
                i.HacerRuido();
            }
        }

    }
}
