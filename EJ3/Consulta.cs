using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Consulta : IEstrategiaHotel
    {
        public Paciente Paciente_a_Atender(List<Paciente> pLista) // Cuando puse interface en EstrategiaHotel,me tiro error, lo solucione sacando override
        {
           
            int i = 0;
            while (pLista[i].Motivo.Estado() != 0)
            {
                i++;
            }
            return pLista[i];
        }
    }
}
