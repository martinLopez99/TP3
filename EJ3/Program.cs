using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EJ3
{
    class Program
    {
        static void Main(string[] args)
        {

            Fachada facade = new Fachada();
            Paciente paciente;
            CreadorLista creador= new CreadorLista();
            //List<Paciente> listapacientes = new List<Paciente>();
            var listapacientes = creador.ConstructorDB10();

            /*  Hospital_Contexto hospitalContexto;

              hospitalContexto = new Hospital_Contexto(new Consulta());
              hospitalContexto.HospitalInterfaz();

              hospitalContexto = new Hospital_Contexto(new Urgencia());
              hospitalContexto.HospitalInterfaz();*/
            int op = -1;
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine($"GESTOR HOSPITAL");
                Console.WriteLine($"Ingrese una opcion: " +
                                                $"\n1 - Consulta" +
                                                $"\n2 - Urgencias" +
                                                $"\n0 - Salir");
                Console.Write("Opcion: ");
                op = Int32.Parse(Console.ReadLine());
                switch (op)
                {
                    case 0: break;
                    case 1: paciente = facade.DevolverPaciente(op, listapacientes);
                                 MostrarInfoPaciente(paciente); break;

                    case 2: paciente = facade.DevolverPaciente(op, listapacientes);
                                 MostrarInfoPaciente(paciente); break;

                    default: Console.Clear();
                                  Console.WriteLine("Ingrese una opcion valida"); break;
                }

                

            }

            void MostrarInfoPaciente(Paciente pPaciente)
            {
                Console.Clear();
                Console.WriteLine($"Paciente: {pPaciente.Nombre}" +
                                               $"Apellido: {pPaciente.Apellido}" +
                                               $"DNI: {pPaciente.DNI}" +
                                               $"Fecha de Ingreso: {pPaciente.FechaDeIngreso}");
                if (pPaciente.Motivo.Consulta)
                {
                    Console.WriteLine($"Motivo: Consulta");
                }
                else
                {
                    Console.WriteLine($"Motivo: Urgencia");
                    Console.WriteLine($"Nivel: {pPaciente.Motivo.Urgencia}");
                }

                facade.EliminarPaciente(pPaciente,listapacientes);
            }



        }
    }
}
