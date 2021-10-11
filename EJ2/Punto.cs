using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Punto
    {
        double iX, iY;

        public Punto(double pX, double pY)
        {
            iX = pX;
            iY = pY;
        }

        public double X
        {
            get { return this.iX; }
        }

        public double Y
        {
            get { return this.iY; }
        }

        public double CalcularDistanciaDesde(Punto pPunto)
        {
            double difx = this.iX - pPunto.iX;
            double dify = this.iY - pPunto.iY;
            return Math.Sqrt(Math.Pow(difx, 2) + Math.Pow(dify, 2));
        }
    }

}
