using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class BaseDeDatos
    {
        private Random aleatorio = new Random();


        public static string[] vectorNombres = new string[] { "Bastian", "Giani", "Elliot", "Kermitt", "Gianfranco", "Hans", "Yannick", "Uziel", "Dylan", "Jermaine",
                                                                                      "Axel", "Jasper", "Kilian", "Dennís", "Ian", "Mirt", "Ryan", "Gary", "Sammy", "Noah",
                                                                                       "Sadami", "Teddy", "Darnell", "Laurence", "Caleb", "Josh", "Jake", "Elm", "Logan", "Luka", };

        public static string[] vectorApellidos = new string[] {"Gonzáles","Muñoz","Díaz","Pérez","Soto","Contreras","Silva","Martínez","Morales","Lopez",
                                                                                      "Hernández","Setién","Curiel","Varela","Rosas","Aranda","Espinosa","Herrera","Andraca","García",
                                                                                      "Díaz","Fauser","Campos","Aburto","Padilla","Blanchet","Brito","Meneses","Negrete","Cortés"  };

        public static string[] vectorDNI = new string[] { "62384494","91135318","66979065","25610997","96793890","86658922","47777289","33466665","75825036","89091100",
                                                                             "47310493","83731086","44302486","67174008","89431381","41281948","37492217","37288313","60429177","28776304",
                                                                             "46254643","88443989","14334214","29245542","84614778","81339924","77794100","19459990","73907476","10334985"};
        //public static DateTime[] vectorFechaDeIngreso = new DateTime[] { };
        public static List<DateTime> vectorFechaDeIngreso = new List<DateTime>();
       
        //public static TipoMotivo[] vectorMotivos = new TipoMotivo[] { };
        public static List<TipoMotivo> vectorMotivos = new List<TipoMotivo>();

        public static void FillTipoMotivo() // ver de cabiar de lugar sin que genere problemas 
        {
            Random numero = new Random();

            if (vectorMotivos == null)
            {
                SeleccionRandom(numero);
            }
            else
            {
                int i = 0;
                while (i < 30)
                {
                    SeleccionRandom(numero);
                    i++;
                }
            }


            static void SeleccionRandom(Random numero)
            {
                int algo2 = numero.Next(0, 2);
                if ((algo2 % 2) == 0)
                {
                    TipoMotivo motivo = new TipoMotivo(true,6);
                   
                    vectorMotivos.Add(motivo);
                }
                else
                {
                    int nivel = numero.Next(1, 6);
                    TipoMotivo motivo = new TipoMotivo(false, nivel);
                    vectorMotivos.Add(motivo);
                }
            }
            /*for (int i = 0; i < 15; i++)
            {
                TipoMotivo motivo = new TipoMotivo();
                motivo.Consulta = true;
                vectorMotivos[i]  =  motivo;
            }

            for (int i = 15; i < 30; i++)
            {
                TipoMotivo motivoUrg = new TipoMotivo();
                motivoUrg.Urgencia = numero.Next(1,  5);
            }*/
        }

        DateTime FechaAleatorio()
        {
            DateTime comienzo = new DateTime(2019, 5, 12,15,5,26);
            int rango = (DateTime.Today - comienzo).Days;
            return comienzo.AddDays(aleatorio.Next(rango));
        }

        public  void FillFechasIngreso()
        {
            for (int i = 0; i < 30; i++)
            {
                 DateTime fechaIngreso = new DateTime();
                 fechaIngreso = FechaAleatorio();
                //vectorFechaDeIngreso[i] = fechaIngreso;
                if (vectorFechaDeIngreso == null)
                {
                    vectorFechaDeIngreso.Add(fechaIngreso);
                }
                else
                {
                    vectorFechaDeIngreso.Insert(i,fechaIngreso);
                }


            }
        }



    }
}
