using MesOutils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitaires
{
    public abstract class UtilitaireConsole // elle doit servir de class de base pour d'autre classe & ne peut instancier toute seule
    {
        /// <summary>
        /// Demande la saisie d'un nombre entier jusqu'a la saisie d'un nombre 
        /// quelque qu'il soit puis renvoie sa valeur.
        /// </summary>
        /// <returns></returns>
        public static int SaisirNb() // un static ne peut pas être référencé par le biais d'une instance
        {
            int nb;
            Console.Write("Veuillez saisir un nombre entier : ");
            string resultat = Console.ReadLine();
            while (!Int32.TryParse(resultat, out nb)) // Converti le string resultat en int nb, retourne un true si la conversion est réussie
            {
                try
                {
                    Console.Write("Veuillez saisir un nombre entier : ");
                    resultat = Console.ReadLine();
                }
                catch (Exception) { }
            }

            return nb;
        }
        /// <summary>
        /// Demande la saisie d'un nombre entier jusqu'a la saisie d'un nombre supérieur à pMin 
        /// puis renvoie sa valeur.
        /// </summary>
        /// <param name="pMin"> valeur minimum possible</param>
        /// <returns></returns>
        public static int SaisirNb(int pMin)
        {
            int nb = 0;

            do
            {
                try
                {
                    Console.Write("Veuillez saisir un nombre entier supérieur à " + pMin + " : ");
                    nb = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException) { }
            } while (nb < pMin);
            return nb;
        }
        /// <summary>
        /// Demande la saisie d'un nombre entier jusqu'a la saisie d'un nombre entre pMin et pMax
        /// puis renvoie sa valeur.
        /// </summary>
        /// <param name="pMin"> valeur minimum possible </param>
        /// <param name="pMax"> valeur maximum possible </param>
        /// <returns></returns>
        public static int SaisirNb(int pMin, int pMax)
        {
            int nb = 0;
            do
            {
                try
                {
                    Console.Write("Veuillez saisir un nombre entier entre " + pMin + " et " + pMax + " : ");
                    nb = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException) { }
            } while (nb < pMin || nb > pMax);
            return nb;
        }

        public static string Conversion(int pNbAConvertir, int pNewBase)
        {
            if(pNbAConvertir <= 0)
            {
                throw new Exception("le nombre à convertir doit être strictement positif");
            }
            if(pNewBase < 2 || pNewBase > 16)
            {
                throw new Exception("La nouvelle base doit être comprise entre 2 et 16");
            }
            Pile<int> deuxPile = new Pile<int>();
            int reste;
            int quotient = pNbAConvertir;
            int test;
            string valeur = "";

            while (quotient != 0)
            {
                reste = (quotient % pNewBase);
                quotient = (quotient / pNewBase);
                deuxPile.Empiler(reste);
            }
            while (!deuxPile.PileVide())
            {
                test = deuxPile.Depiler();
                if (test < 10)
                {
                    valeur += Convert.ToString(test);
                }
                else
                {
                    valeur += Convert.ToChar(test + 55);
                }
            }
            return valeur;
        }
    }
}
