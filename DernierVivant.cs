using System;

namespace ProgOrieObj
{
    /// <summary>
    /// Cette classe ne pourra pas être héritée
    /// </summary>
    sealed class DernierVivant : Enfant, IDernierMessage
    {
        
        /// <summary>
        /// constructeur 
        /// </summary>
        public DernierVivant() 
        {
            Console.WriteLine("Constructeur du dernier vivant");
        }

        /// <summary>
        /// destructeur
        /// </summary>
        ~DernierVivant()
        {
            Console.WriteLine("Destructeur du dernier vivant");
        }


        /// <summary>
        /// Définition de la méthode "héritée" de l'interface
        /// </summary>
        /// <remarks>Cette redéfinition est obligatoire</remarks>
        /// <param name="message"></param>
        /// <returns></returns>
        public string DernierMessage(string message)
        {
            string monDernierMessage = "message";
            Console.WriteLine("Ceci est mon dernier {0}", monDernierMessage);
            return monDernierMessage;
        }

        /// <summary>
        /// Définition (obligatoire) de la méthode "héritée" de l'interface
        /// </summary>
        /// <remarks>Cette redéfinition est obligatoire</remarks>
        public void DernierRepas()
        {
            Console.WriteLine("Ceci est mon dernier repas");
        }

        /// <summary>
        /// ma méthode
        /// </summary>
        public void maMethode()
        {
            throw new NotImplementedException();
        }
    }
}