using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class TipoMotivo
    {
        private bool iConsulta = false;
        private int iUrgencia;

        public bool Consulta
        {
            set { this.iConsulta = value; }
        }
        public int Urgencia
        {
            set { this.iUrgencia = value; }
        }

        public int Estado()
        {
            if (iConsulta)
            {
                return 6;
            }
            else
            {
                return this.iUrgencia;
            }
        }

    }
}
