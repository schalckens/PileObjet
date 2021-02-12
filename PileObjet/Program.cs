using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MesOutils;

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
            TesteEmpilerDepiler(5);

            Console.WriteLine("Fin de programme");
            Console.ReadKey();

        }
        static  void TestePileVidePleine(int nbElements)
        {
            try
            {
                Pile unePile = new Pile(nbElements);
                if (unePile.PileVide())
                {
                    Console.WriteLine("La pile est vide");
                }
                else
                {
                    Console.WriteLine("La pile n'est pas vide");
                }
                if (unePile.PilePleine())
                {
                    Console.WriteLine("Le pile est pleine");
                }
                else
                {
                    Console.WriteLine("La pile n'est pas pleine");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
        static void TesteEmpiler(int pNb)
        {
            try
            {
                Pile unePile = new Pile(pNb);
                unePile.Empiler(2);
                unePile.Empiler(14);
                unePile.Empiler(6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void TesteEmpilerDepiler(int nbElements)
        {
            try
            {
                Pile unePile = new Pile(nbElements);
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
    }
}
