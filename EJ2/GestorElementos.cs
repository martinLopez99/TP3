using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class GestorElementos
    {
        public double ManejoPuntos(double px1, double py1, double px2, double py2)
        {
            Punto p1 = new Punto(px1, py1);

            Punto p2 = new Punto(px2, py2);

            return Math.Round(p1.CalcularDistanciaDesde(p2), 2);
        }

        public double AreaTriangulo(double px1, double py1, double px2, double py2, double px3, double py3)
        {
            Punto p1 = new Punto(px1, py2);
            Punto p2 = new Punto(px2, py2);
            Punto p3 = new Punto(px3, py3);
            Triangulo tri = new Triangulo(p1, p2, p3);

            return Math.Round(tri.CalcularArea(), 2);
        }

        public double PerimTriangulo(double px1, double py1, double px2, double py2, double px3, double py3)
        {
            Punto p1 = new Punto(px1, py2);
            Punto p2 = new Punto(px2, py2);
            Punto p3 = new Punto(px3, py3);
            Triangulo tri = new Triangulo(p1, p2, p3);

            return Math.Round(tri.CalcularPerimetro(), 2);
        }

        public double AreaCirculo(double px, double py, double radio)
        {
            Circulo circ = new Circulo(px, py, radio);

            return Math.Round(circ.CalcularArea(), 2);
        }

        public double PerimCirculo(double px, double py, double radio)
        {
            Circulo circ = new Circulo(px, py, radio);

            return Math.Round(circ.CalcularPerimetro(), 2);
        }
    }
}
