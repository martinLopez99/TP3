using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public interface IEstrategiaHotel 
    {
        public abstract Paciente Paciente_a_Atender(List<Paciente> pLista);

    }
}
