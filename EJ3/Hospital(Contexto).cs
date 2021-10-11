using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Hospital_Contexto
    {
        EstrategiaHotel estrategiaH;

        public Hospital_Contexto(EstrategiaHotel estrategia)
        {
            this.estrategiaH = estrategia;
        }

        public void HospitalInterfaz()
        {
            estrategiaH.Paciente_a_Atender();
        }
    }
}
