using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public interface IEstrategiaHotel //en vez de abstract class, le puse interface 
    {
        public abstract Paciente Paciente_a_Atender(List<Paciente> pLista);

    }
}
