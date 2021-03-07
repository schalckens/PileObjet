﻿using PilObjet.Test;
using System;
using Utilitaires;

namespace PileObjet
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestPile.TestePileVide();
            //TestPile.TesteEmpiler();
            //TestPile.TesteEmpilerDepiler();
            //// appels des méthodes de tests conversion
            //TestPile.TesteConversion();
            //TestPile.TesteConversion(154, 2);
            //TestPile.TesteConversion(11, 16);
            //TestPile.TesteConversion(2986, 16);
            //TestPile.TesteConversion(9999, 16);

            string phrase = UtilitaireAPI.RecupereLoremIpsum(3);
            Console.WriteLine("-----------------------");
            Console.WriteLine("phrase : ");
            Console.WriteLine(phrase);
            string phraseInversee = UtilitaireConsole.InversePhrase(phrase);
            Console.WriteLine("\nphrase inversée : ");
            Console.WriteLine(phraseInversee);
            Console.WriteLine("-----------------------");
            TestPile.TesteInversePhrase();

            Console.WriteLine("Fin de programme");
            Console.ReadKey();

        }
    }
}
