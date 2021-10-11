using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Consulta : EstrategiaHotel
    {
        public override void Paciente_a_Atender()
        {
            // Aca deasrrollo la estrategia de consulta 
            // FIFO
            Console.WriteLine("Estrategia Consulta");

        }
    }
}
