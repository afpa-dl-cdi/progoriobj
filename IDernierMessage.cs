using System;
namespace ProgOrieObj
{
    /// <summary>
    /// Par définition toutes les classes de cette interface sont abstraites
    /// </summary>
    interface IDernierMessage : IMonInterface, IMonAutreInterface
    {
        /// <summary>
        /// Dernier message à afficher
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        string DernierMessage(string message);


        /// <summary>
        /// Dernier repas de la personne
        /// </summary>
        void DernierRepas();
    }
}