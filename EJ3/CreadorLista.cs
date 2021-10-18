using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class CreadorLista
    {
        BaseDeDatos iBaseDatos = new BaseDeDatos();
        List<Paciente> iListaPacientes = new List<Paciente>();
        
        public List<Paciente> ConstructorDB10()
        {
            {
                this.iBaseDatos.FillFechasIngreso();

                BaseDeDatos.FillTipoMotivo();

                if (iListaPacientes == null)
                    iListaPacientes.Add(ObtenerPaciente(0));
                else
                {
                    for (int i = 0; i < 30; i++)
                    {
                        var x = ObtenerPaciente(i);
                        while (iListaPacientes.Count > i && iListaPacientes[i].FechaDeIngreso < x.FechaDeIngreso)
                        {
                            i++;
                        }
                        iListaPacientes.Insert(i, x);
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
            DateTime fechaIngreso = Repositorio.DevuelveFechaIngreso(pPos);
            TipoMotivo motivo = Repositorio.DevuelveMotivo(pPos);

            Paciente paciente = new Paciente(nombre, apellido, dni, motivo,fechaIngreso);
            return paciente;    
        }
    }
}
