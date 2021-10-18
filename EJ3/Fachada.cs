using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Fachada
    {

        Hospital_Contexto Hospital;
        IEstrategiaHotel estrategia;

        public Paciente DevolverPaciente(int pSala, List<Paciente> pLista)
        {
            estrategia =Hospital.GetStrategy(pSala);
            return estrategia.Paciente_a_Atender(pLista);
        }

        public void EliminarPaciente(Paciente pPaciente, List<Paciente> pLista)
        {
            pLista.Remove(pPaciente);
        }
        
    }
}
