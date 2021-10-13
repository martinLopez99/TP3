using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Consulta : EstrategiaHotel
    {
        public override Paciente Paciente_a_Atender()
        {
            CreadorLista ctorLista = new();
            // Aca deasrrollo la estrategia de consulta 
            // FIFO
            var listaPacientes = ctorLista.ConstructorDB10();
            int i = 0;
            while (listaPacientes[i].Motivo.Estado() != 0)
            {
                i++;
            }

            return listaPacientes[i];

        }
    }
}
