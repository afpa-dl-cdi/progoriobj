using System;

namespace ProgOrieObj
{
    /// <summary>
    /// Classe définissant, par héritage, les enfants
    /// </summary>
    class Enfant : Parent
    {
        /// <summary>
        /// constructeur
        /// </summary>
        public Enfant()
        {
            Console.WriteLine("Constructeur de l'objet enfant");
        }

        /// <summary>
        /// Destructeur
        /// </summary>
        ~Enfant()
        {
            //A exécuter lors de la destruction de l'objet enfant
            Console.WriteLine("Destructeur de l'objet enfant");
        }


        /// <summary>
        /// Fonction primaire chez l'homme lui permettant de reprendre des forces, voir même d'en abuser...
        /// </summary>
        /// <remarks>
        /// La méthode parente n'est pas appelée
        /// </remarks>
        public override void manger()
        {
           // base.manger();
            Console.WriteLine("Façon de manger des enfants (typiquement avec les doigts...)");
        }
    }
}