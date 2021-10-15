using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Urgencia : EstrategiaHotel
    {
        public override Paciente Paciente_a_Atender()
        {
            CreadorLista ctorLista = new();
            var listaPacientes = ctorLista.ConstructorDB10();
            int i = 0;
            Paciente actual = listaPacientes[i];
            while (listaPacientes.Count > i)
            {
                if (actual.Motivo.Estado() > listaPacientes[i].Motivo.Estado())
                {
                    actual = listaPacientes[i];
                }
                i++;
            }

            return actual;
        }
    }
}
