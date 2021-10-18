using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Fachada
    {
        IEstrategiaHotel estrategia;


        public Paciente DevolverPaciente(Hospital_Contexto pContexto, List<Paciente> pLista)
        {
            //estrategia =GetStrategy(pSala);
            return pContexto.HospitalInterfaz(pLista);
            //return estrategia.Paciente_a_Atender(pLista);
        }

        public void EliminarPaciente(Paciente pPaciente, List<Paciente> pLista)
        {
            pLista.Remove(pPaciente);
        }
        
    }
}
