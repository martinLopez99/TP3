using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class CreadorLista
    {      
        List<Paciente> iListaPacientes = new List<Paciente>();
        
        public List<Paciente> ConstructorDB10()
        {
            {
                if (iListaPacientes == null)
                    iListaPacientes.Add(ObtenerPaciente(0));
                else
                {
                    for (int i = 0; i < 30; i++)
                    {
                        iListaPacientes.Insert(i, ObtenerPaciente(i));
                    }
                }
                return iListaPacientes;
            }



        }

        public Paciente ObtenerPaciente(int pPos)
        {
            string nombre = Repositorio.DevuelveNombre(pPos);
            string dni  = Repositorio.DevuelveDni(pPos);
            string apellido = Repositorio.DevuelveApellido(pPos);
            string fechaIngreso = Repositorio.DevuelveFechaIngreso(pPos);
            TipoMotivo motivo = Repositorio.DevuelveMotivo(pPos);

            Paciente paciente = new Paciente(nombre, apellido, dni, motivo);
            return paciente;    


        }


    }
}
