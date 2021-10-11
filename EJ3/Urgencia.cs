using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Urgencia: EstrategiaHotel
    {
        public override void Paciente_a_Atender()
        {
            //  Aca deasrrollo la estrategia de Urgencia
            // Tiraje
            Console.WriteLine("Estrategia Urgencia");
        }
    }
}
