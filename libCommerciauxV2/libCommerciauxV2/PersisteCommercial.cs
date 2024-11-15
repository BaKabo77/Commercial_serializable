using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace libCommerciauxV2
{
    public static class PersisteCommercial
    {
            
        public static void sauve(ServiceCommercial sc,string fichier)
        {

            string json = JsonSerializer.Serialize(sc);
            File.WriteAllText(fichier,json);

        }

        public static void charge(string fichier) 
        {
            string lecture = File.ReadAllText(fichier);
            ServiceCommercial resultat = JsonSerializer.Deserialize<ServiceCommercial>(lecture);


        }

    }
}
