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

        public TipoMotivo(bool pConsulta, int pUrgencia)
        {
            this.iConsulta = pConsulta;
            this.iUrgencia = pUrgencia;
        }

        public bool Consulta
        {
            get { return this.iConsulta; }
            set { this.iConsulta = value; }
        }
        public int Urgencia
        {
            get { return this.iUrgencia; }
            set { this.iUrgencia = value; }
        }

        public int Estado()
        {
            if (Consulta)
            {
                return 6;
            }
            else
            {
                return Urgencia;
            }
        }

    }
}
