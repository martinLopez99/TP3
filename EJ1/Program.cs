using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            Gato gato = new Gato();
            Animal[] vector = { perro, gato };
            Veterinaria veterinaria = new Veterinaria();
            veterinaria.AceptarAnimales(vector);
            Console.ReadKey();
        }
    }
}
