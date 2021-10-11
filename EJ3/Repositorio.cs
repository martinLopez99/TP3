using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public static class Repositorio
    {


        public static string DevuelveNombre(int pPos)
        {
            return BaseDeDatos.vectorNombres[pPos];
        }

        public static string DevuelveApellido(int pPos)
        {
            return BaseDeDatos.vectorApellidos[pPos];
        }

        public static string DevuelveDni(int pPos)
        {
            return BaseDeDatos.vectorDNI[pPos];
        }

        public static string DevuelveFechaIngreso(int pPos)
        {
            return BaseDeDatos.vectorDNI[pPos];
        }
        public static TipoMotivo DevuelveMotivo(int pPos)
        {
            return BaseDeDatos.vectorMotivos[pPos];
        }


    }

}
