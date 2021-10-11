using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    public class BaseDeDatos
    {
        public static string[] vectorNombres = new string[] { "Bastian", "Giani", "Elliot", "Kermitt", "Gianfranco", "Hans", "Yannick", "Uziel", "Dylan", "Jermaine",
                                                                                      "Axel", "Jasper", "Kilian", "Dennís", "Ian", "Mirt", "Ryan", "Gary", "Sammy", "Noah",
                                                                                       "Sadami", "Teddy", "Darnell", "Laurence", "Caleb", "Josh", "Jake", "Elm", "Logan", "Luka", };

        public static string[] vectorApellidos = new string[] {"Gonzáles","Muñoz","Díaz","Pérez","Soto","Contreras","Silva","Martínez","Morales","Lopez",
                                                                                      "Hernández","Setién","Curiel","Varela","Rosas","Aranda","Espinosa","Herrera","Andraca","García",
                                                                                      "Díaz","Fauser","Campos","Aburto","Padilla","Blanchet","Brito","Meneses","Negrete","Cortés"  };

        public static string[] vectorDNI = new string[] { "62384494","91135318","66979065","25610997","96793890","86658922","47777289","33466665","75825036","89091100",
                                                                             "47310493","83731086","44302486","67174008","89431381","41281948","37492217","37288313","60429177","28776304",
                                                                             "46254643","88443989","14334214","29245542","84614778","81339924","77794100","19459990","73907476","10334985"};
        public static string[] vectorFechaDeIngreso = new string[] { "2020-04-28 01:37:01", "2020-01-09 00:27:27", "2020-02-20 17:24:54", "2021-09-05 09:44:01", "2021-07-08 18:22:41", "2019-11-17 05:50:11", "2020-01-14 06:18:45", "2019-11-01 09:15:31", "2021-02-18 19:06:52", "2020-02-29 15:15:23",
                                                                                                  "2020-06-09 01:41:20", "2020-06-13 19:46:25", "2019-10-09 14:45:46", "2020-03-09 05:28:29", "2019-12-11 20:00:48", "2019-11-19 04:51:49", "2020-07-21 00:35:04", "2020-09-30 20:39:56", "2020-07-31 22:36:12", "2019-12-06 13:46:35",
                                                                                                  "2020-05-31 02:17:45", "2020-08-16 04:29:49", "2019-12-19 06:18:17", "2021-01-16 08:29:15", "2020-10-11 13:29:44","2021-05-29 05:53:25", "2021-01-03 15:35:39", "2021-08-20 15:05:49", "2020-05-15 09:22:50", "2019-10-13 14:53:03"};
        public static TipoMotivo[] vectorMotivos = new TipoMotivo[] { };

        public void FillTipoMotivo() // ver de cabiar de lugar sin que genere problemas 
        {
            Random numero = new Random();
            for (int i = 0; i < 15; i++)
            {
                TipoMotivo motivo = new TipoMotivo();
                motivo.Consulta = true;
                vectorMotivos[i]  =  motivo;
            }

            for (int i = 15; i < 30; i++)
            {
                TipoMotivo motivoUrg = new TipoMotivo();
                motivoUrg.Urgencia = numero.Next(1,  5);
            }
        }

     

    }
}
