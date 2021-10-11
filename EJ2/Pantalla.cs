using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Pantallas
    {
        GestorElementos iGestion = new GestorElementos();
        public void S_Circulo()
        {
            Console.Clear();
            Console.Write($"    - Menu Circulo -    \n" +
                $" Ingrese el punto central del circulo: \n" +
                $" Eje X: ");
            double px = Convert.ToDouble(Console.ReadLine());
            Console.Write($" Eje Y: ");
            double py = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n Ingrese el radio del circulo: ");
            double radio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n    - Resultados -    \n" +
                $" El área es de: {iGestion.AreaCirculo(px, py, radio)}");
            Console.Write($" Y su perímetro de: {iGestion.PerimCirculo(px, py, radio)}");
            Console.ReadKey();
        }

        public void S_Puntos()
        {
            Console.Clear();
            Console.Write($"    - Menu Puntos -    \n" +
            $" Ingrese las componentes del primer punto: \n");
            Console.Write(" P1(x)= ");
            double px1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" P1(y)= ");
            double py1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n Ingrese las componentes del segundo punto: ");
            Console.Write(" P2(x)= ");
            double px2 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" P2(y)= ");
            double py2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\n    - Resultados -    \n");
            Console.Write($" La distancia entre los puntos es de: {iGestion.ManejoPuntos(px1, py1, px2, py2)}");
            Console.ReadKey();
        }

        public void S_Triangulo()
        {
            Console.Clear();
            Console.Write($"    - Menu Triángulo -    \n" +
                $" Ingrese el primer punto: \n");
            Console.Write($" P1(x): ");
            double px1 = Convert.ToDouble(Console.ReadLine());
            Console.Write($" P1(y): ");
            double py1 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"\n Segundo punto: \n");
            Console.Write($" P2(x): ");
            double px2 = Convert.ToDouble(Console.ReadLine());
            Console.Write($" P2(y): ");
            double py2 = Convert.ToDouble(Console.ReadLine());

            Console.Write($"\n Tercer punto: \n");
            Console.Write($" P3(x): ");
            double px3 = Convert.ToDouble(Console.ReadLine());
            Console.Write($" P3(y): ");
            double py3 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"\n    - Resultados -    ");
            Console.Write($" El área del triángulo es de: {iGestion.AreaTriangulo(px1, py1, px2, py2, px3, py3)}\n");
            Console.Write($" Y el perímetro es de: {iGestion.PerimTriangulo(px1, py1, px2, py2, px3, py3)}");
            Console.ReadKey();
        }
    }
}
