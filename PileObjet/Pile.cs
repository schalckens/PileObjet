using System;
using System.Collections.Generic;

namespace MesOutils
{
    /// <summary>
    /// Pile pouvant contenir des entiers.
    /// On ajoute après le dernier éléments ajouté.
    /// On retire le dernier élément ajouté
    /// </summary>
    class Pile
    {

        /// <summary>
        /// Nombre maximum d'éléments de la Pile
        /// </summary>
        private int nbMaxElt;
        /// <summary>
        /// Liste contenant les éléments de la pile
        /// </summary>
        private List<int> elements;

        /// <summary>
        /// Constructeur de l'objet pile
        /// </summary>
        /// <param name="nbMaxElt"> nombre maximum d'éléments de la pile</param>
        public Pile(int nbMaxElt)
        {
            this.nbMaxElt = nbMaxElt;
            this.elements = new List<int>();
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
        /// Permet de savoir si la pile est pleine.
        /// </summary>
        /// <returns> retourne un booléen </returns>
        public bool PilePleine()
        {
            return (this.elements.Count == this.nbMaxElt);
        }
        /// <summary>
        /// Permet d'empiler après le dernier élément empiler dans notre objet Pile.
        /// </summary>
        /// <param name="pNb"> Nombre à empiler </param>
        public void Empiler( int pNb)
        {
            if (!PilePleine())
            {
                this.elements.Add(pNb);
            }
            else
            {
                throw new Exception("Pile pleine, impossible d'empiler un élément");
            }
        }
        /// <summary>
        /// Permet de dépiler le dernier éléments de notre objet Pile.
        /// </summary>
        /// <returns> Denier nombre empiler </returns>
        public int Depiler()
        {
            if (!PileVide())
            {
                int nb = this.elements[this.elements.Count - 1];
                this.elements.RemoveAt(this.elements.Count - 1);
                return nb;
            }
            else
            {
                throw new Exception("Impossible de dépiler, pile vide");
            }
        }

    }
}
