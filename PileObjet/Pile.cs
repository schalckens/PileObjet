using System;
using System.Collections.Generic;
using Utilitaires;

namespace MesOutils
{
    /// <summary>
    /// Pile pouvant contenir des entiers.
    /// On ajoute après le dernier éléments ajouté.
    /// On retire le dernier élément ajouté
    /// </summary>
    class Pile<T>
    {
        /// <summary>
        /// Liste contenant les éléments de la pile
        /// </summary>
        private List<T> elements;

        public int Count { get => this.elements.Count; }

        /// <summary>
        /// Constructeur de l'objet pile
        /// </summary>
        /// <param name="nbMaxElt"> nombre maximum d'éléments de la pile</param>
        public Pile()
        {
            this.elements = new List<T>();
        }
        /// <summary>
        /// Permet de savoir si la pile est vide.
        /// </summary>
        /// <returns> retourne un booléen </returns>
        public bool PileVide()
        {
            return (this.elements.Count == 0);
        }
        /// <summary>
        /// Permet d'empiler après le dernier élément empiler dans notre objet Pile.
        /// </summary>
        /// <param name="pNb"> Nombre à empiler </param>
        public void Empiler(T valeur)
        {
                this.elements.Add(valeur);
        }
        /// <summary>
        /// Permet de dépiler le dernier éléments de notre objet Pile.
        /// </summary>
        /// <returns> Denier nombre empiler </returns>
        public int Depiler()
        {
            if (!PileVide())
            {
                var nb = this.elements[this.elements.Count - 1];
                this.elements.RemoveAt(this.elements.Count - 1);
                return (nb);
            }
            else
            {
                throw new Exception("Impossible de dépiler, pile vide");
            }
        }
        /// <summary>
        /// Permet la Convertion d'un nombre entier dans une nouvelle base;
        /// </summary>
        /// <param name="pNb"> nombre maximum d'éléments dans la pile</param>
        /// <param name="pNbAConvertir"> nombre entier à convertir</param>
        /// <param name="pNewBase"> nouvelle base </param>
        /// <returns></returns>
        public string Convertir(int pNb, int pNbAConvertir, int pNewBase)
        {
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
                if ( test < 10 )
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
