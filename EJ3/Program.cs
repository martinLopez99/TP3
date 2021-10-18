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
            var listapacientes = creador.ConstructorDB10();

              Hospital_Contexto hospitalContexto;

              

              
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
                    case 1:
                                 hospitalContexto = new Hospital_Contexto(new Consulta());
                                 hospitalContexto.HospitalInterfaz(listapacientes);
                                 paciente = facade.DevolverPaciente(hospitalContexto, listapacientes);
                                 MostrarInfoPaciente(paciente); break;

                    case 2:
                                    hospitalContexto = new Hospital_Contexto(new Urgencia());
                                    hospitalContexto.HospitalInterfaz(listapacientes);
                                    paciente = facade.DevolverPaciente(hospitalContexto, listapacientes);
                                    MostrarInfoPaciente(paciente);
                        break;

                    default: Console.Clear();
                                  Console.WriteLine("Ingrese una opcion valida"); break;
                }

                

            }

            void MostrarInfoPaciente(Paciente pPaciente)
            {
                Console.Clear();
                Console.WriteLine($"Paciente: {pPaciente.Nombre}\n" +
                                               $"Apellido: {pPaciente.Apellido}\n" +
                                               $"DNI: {pPaciente.DNI}\n" +
                                               $"Fecha de Ingreso: {pPaciente.FechaDeIngreso}");
                if (pPaciente.Motivo.Consulta)
                {
                    Console.WriteLine("Motivo: consulta");
                }
                else
                {
                    Console.WriteLine("Motivo: Urgencia");
                    Console.WriteLine($"Nivel: {pPaciente.Motivo.Urgencia}");

                }

                Console.WriteLine($"- Presione cualquier tecla para salir\n");
                Console.ReadKey();
                facade.EliminarPaciente(pPaciente,listapacientes);
            }



        }
    }
}
