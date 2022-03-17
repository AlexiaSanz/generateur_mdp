using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
   static class outils
    {
        public static int DemanderNombrePositifNonNul(string question, int MIN, int MAX)
        {
            return DemanderNombreEntre(question, MIN, MAX);
        }
        public static int DemanderNombreEntre(string question, int MIN, int MAX)
        {
            while (true)
            {
                int nombre = DemanderNombre(question);

                if ((nombre < MIN) || (nombre > MAX))
                {
                    Console.WriteLine($"ERREUR : Entrez un nombre entre {MIN} et {MAX}");

                }
                else
                    return nombre;
            }
        }
        public static int DemanderNombre(string question)
        {
            int reponseInt;

            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("Veuillez entrer un nombre");
                }
            }
        }
    }
}
