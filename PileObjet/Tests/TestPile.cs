
using MesOutils;
using System;
using Utilitaires;

namespace PilObjet.Test
{
    internal abstract class TestPile
    {
        /// <summary>
        /// Test des méthodes PileVide et PilePleine de la classe Pile.
        /// </summary>
        /// <param name="nbElements"> Nombre maximum d'élément dans l'objet Pile </param>
        public static void TestePileVide()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();
                if (unePile.PileVide())
                {
                    Console.WriteLine("La pile est vide");
                }
                else
                {
                    Console.WriteLine("La pile n'est pas vide");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// Test de la méthode Empiler de la classe Pile.
        /// </summary>
        /// <param name="pNb"> Nombre maximum d'éléments dans l'objet Pile </param>
        public static void TesteEmpiler()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();
                unePile.Empiler(2);
                unePile.Empiler(14);
                unePile.Empiler(6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Test des méthodes Empiler et Depiler de la classe Pile.
        /// </summary>
        /// <param name="nbElements"> Nombre maximum d'éléments dans l'objet Pile </param>
        public static void TesteEmpilerDepiler()
        {
            try
            {
                Pile<int> unePile = new Pile<int>();
                unePile.Empiler(2);
                unePile.Empiler(22);
                int valeurDepilee = unePile.Depiler();
                Console.WriteLine("Valeur dépilée : " + valeurDepilee);
                unePile.Empiler(17);
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();
                valeurDepilee = unePile.Depiler();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        
        public static void TesteConversion()
        {
            Console.Write("Saisie du nombre à convertir : ");
            int nbAConvertir = UtilitaireConsole.SaisirNb(0);
            Console.Write("Saisie de la nouvelle base : ");
            int newBase = UtilitaireConsole.SaisirNb(2, 16);
            //Appel de la méthode surchargé Teste Conversion pour effectuer la conversion
            TesteConversion(nbAConvertir, newBase);
        }
        public static void TesteConversion(int nbAConvertir, int newBase)
        {
            try
            {
                string valeurConvertie = UtilitaireConsole.Conversion(nbAConvertir, newBase);
                Console.WriteLine(nbAConvertir + " est convertie en : " + valeurConvertie );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
