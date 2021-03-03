using PilObjet.Test;
using System;

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

            TestPile.TesteConvertir();

            Console.WriteLine("Fin de programme");
            Console.ReadKey();

        }
    }
}
