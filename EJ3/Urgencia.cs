using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Urgencia : IEstrategiaHotel
    {
        public Paciente Paciente_a_Atender(List<Paciente> pLista) // Cuando puse interface en EstrategiaHotel,me tiro error, lo solucione sacando override 
        {
            int i = 0;
            Paciente actual = pLista[i];
            while (pLista.Count > i)
            {
                if (actual.Motivo.Estado() > pLista[i].Motivo.Estado())
                {
                    actual = pLista[i];
                }
                i++;
            }

            return actual;
        }
    }
}
