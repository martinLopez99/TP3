using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Triangulo : FiguraGeometrica
    {
        Punto iPunto1, iPunto2, iPunto3;
        double iLado1, iLado2, iLado3;

        public Triangulo(Punto pP1, Punto pP2, Punto pP3)
        {
            iPunto1 = pP1;
            iPunto2 = pP2;
            iPunto3 = pP3;
        }

        public Punto Punto1
        {
            get { return this.iPunto1; }
        }

        public Punto Punto2
        {
            get { return this.iPunto2; }
        }

        public Punto Punto3
        {
            get { return this.iPunto3; }
        }

        public override double CalcularArea()
        {
            double semiPer = (CalcularPerimetro() / 2);
            return Math.Sqrt(semiPer * (semiPer - this.iLado1) * (semiPer - this.iLado2) * (semiPer - this.iLado3));
        }

        public override double CalcularPerimetro()
        {
            iLado1 = this.iPunto1.CalcularDistanciaDesde(this.iPunto2);
            iLado2 = this.iPunto2.CalcularDistanciaDesde(this.iPunto3);
            iLado3 = this.iPunto3.CalcularDistanciaDesde(this.iPunto1);
            return (iLado1 + iLado2 + iLado3);
        }
    }
}
