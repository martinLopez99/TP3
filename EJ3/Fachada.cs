using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Fachada
    {


        public Paciente DevolverPaciente(Hospital_Contexto pContexto, List<Paciente> pLista)
        {
            return pContexto.HospitalInterfaz(pLista);
        }

        public void EliminarPaciente(Paciente pPaciente, List<Paciente> pLista)
        {
            pLista.Remove(pPaciente);
        }
        
    }
}
