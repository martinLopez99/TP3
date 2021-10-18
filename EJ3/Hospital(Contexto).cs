using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Hospital_Contexto
    {
        IEstrategiaHotel iestrategiaH;
        //Paciente paciente; 

        public Hospital_Contexto(IEstrategiaHotel piestrategiaH)
        {
            //this.paciente = pPaciente;
            this.iestrategiaH = piestrategiaH;
        }

        /*public void HospitalInterfaz()
        {
           
            iestrategiaH.Paciente_a_Atender();
            
        }*/

        public IEstrategiaHotel GetStrategy(int pSala)
        {

            if (pSala == 1)
            {
                return iestrategiaH = new Consulta();
            }
            else
            {
                return iestrategiaH = new Urgencia();
            }
        }

    }
}
