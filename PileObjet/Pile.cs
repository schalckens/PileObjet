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
    }
}
