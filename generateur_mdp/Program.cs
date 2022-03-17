using System;
using FormationCS;

namespace generateur_mdp
{
    class Program
    {
       

        
        static string MotDePasseGene (int longueurMDP, int longueuralphabet, string alphabet)
        {
            
            string motDePasse = "";

            for (int i = 0; i < longueurMDP; i++)
            {
                Random rand = new Random();
                int index = rand.Next(0, longueuralphabet);
                motDePasse += alphabet[index];

            }
            return motDePasse;           
        }
       
        static void Main(string[] args)
        {
            const int MIN = 4;
            const int MAX = 13;
            const int NB_MDP = 20;

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "123456789";
            string caracteresSpeciaux = "+=@:!$></&}{()#*%";
            string alphabet;

            int longueurMDP = FormationCS.outils.DemanderNombrePositifNonNul($"Longueur du mot de passe, de {MIN} à {MAX} caractères : ", MIN, MAX);
            Console.WriteLine();
            int choixAlphabet = outils.DemanderNombreEntre("Choisissez le type de mot de passe souhaité : \n" +
              "1. Mot de passe avec des lettres minuscules \n" +
              "2. Mot de passe avec des lettres minuscules et majuscules \n" +
              "3. Mot de passe avec des lettres et des chiffres \n" +
              "4. Mot de passe avec des letttres, des chiffres et des caractères spéciaux \n" +
              "Entrez votre choix ici : ", 1, 4);

           
            if (choixAlphabet == 1)
                alphabet = minuscules;
            else if (choixAlphabet == 2)
                alphabet = minuscules + majuscules;
            else if (choixAlphabet == 3)
                alphabet = minuscules + majuscules + chiffres;
            else
                alphabet = minuscules + majuscules + chiffres + caracteresSpeciaux;

            int longueuralphabet = alphabet.Length;
            string mdp = "";

            Console.WriteLine();
            Console.WriteLine("Vos mots de passe : ");

            for (int i = 0; i < NB_MDP; i++)
            {
                mdp = MotDePasseGene(longueurMDP, longueuralphabet, alphabet);
                Console.WriteLine(mdp);
               
            }
            
            


        }

    }
}
