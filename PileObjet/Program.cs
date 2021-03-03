using System;
using MesOutils;
using Utilitaires;

namespace PileObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestePileVidePleine(5);
            //TestePileVidePleine(0);
            //TesteEmpiler(5);
            //TesteEmpiler(2);
            //TesteEmpilerDepiler(5);

            //int nbSaisi = UtilitaireConsole.SaisirNb();
            //Console.WriteLine("Nombre saisi : " + nbSaisi);
            //nbSaisi = UtilitaireConsole.SaisirNb(10);
            //Console.WriteLine("Nombre saisi : " + nbSaisi);
            //nbSaisi = UtilitaireConsole.SaisirNb(10,30);
            //Console.WriteLine("Nombre saisi : " + nbSaisi);

            TesteConvertir();

            Console.WriteLine("Fin de programme");
            Console.ReadKey();

        }
        /// <summary>
        /// Test des méthodes PileVide et PilePleine de la classe Pile.
        /// </summary>
        /// <param name="nbElements"> Nombre maximum d'élément dans l'objet Pile </param>
        static  void TestePileVidePleine(int nbElements)
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
        static void TesteEmpiler(int pNb)
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
        static void TesteEmpilerDepiler(int nbElements)
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
        /// <summary>
        /// Test de la méthode Convertir de la classe Pile.
        /// </summary>
        static void TesteConvertir()
        {
            try
            {
                Pile<int> gentillePile = new Pile<int>();
                Console.Write("Saisie du nombre à convertir.");
                int pNbAConvertir = UtilitaireConsole.SaisirNb(0);
                Console.Write("Saisie de la nouvelle base.");
                int pNewBase = UtilitaireConsole.SaisirNb(2, 16);
                Console.WriteLine("Valeur Convertie : " +  gentillePile.Convertir(pNbAConvertir,pNewBase));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
        }

    }
}
