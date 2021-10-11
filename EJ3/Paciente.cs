using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class Paciente
    {
        private string inombre, iappellido, iDNI;
        private TipoMotivo imotivo;
        private DateTime iFechaIngreso;

        public Paciente(string pNombe, string pApellido, string pDNI, TipoMotivo pMotivo)
        {
            this.inombre = pNombe;
            this.iappellido = pApellido;
            this.iDNI = pDNI;
            this.imotivo = pMotivo;
            this.iFechaIngreso = DateTime.Now;
        }

        public string Nombre
        {
            get { return this.inombre; }
            set { this.inombre = value; }
        }

        public string Apellido
        {
            get { return this.iappellido; }
            set { this.iappellido = value; }
        }
        public string DNI
        {
            get { return this.iDNI; }
            set { this.iDNI = value; }
        }
        public TipoMotivo Motivo
        {
            get { return this.imotivo; }
            set { this.imotivo = value; }
        }
        public string FechaDeIngreso
        {
            get { return this.iFechaIngreso.ToString(); }
        }




    }
}
