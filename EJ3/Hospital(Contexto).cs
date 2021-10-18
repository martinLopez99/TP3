using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Hospital_Contexto
    {
        IEstrategiaHotel iestrategiaH;
        public Hospital_Contexto(IEstrategiaHotel piestrategiaH)
        {
            this.iestrategiaH = piestrategiaH;
        }

        public Paciente HospitalInterfaz(List<Paciente> pLista)
        {
           
           return iestrategiaH.Paciente_a_Atender(pLista);
            
        }

    }
}
