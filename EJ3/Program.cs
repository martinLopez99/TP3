using System;

namespace EJ3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital_Contexto hospitalContexto;

            hospitalContexto = new Hospital_Contexto(new Consulta());
            hospitalContexto.HospitalInterfaz();
            
            hospitalContexto = new Hospital_Contexto(new Urgencia());
            hospitalContexto.HospitalInterfaz();

            Console.ReadKey();



        }
    }
}
