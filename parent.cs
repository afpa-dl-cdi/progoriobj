using System;
namespace ProgOrieObj
{
    /// <summary>
    /// Classe de type parent pouvant être héritée
    /// </summary>
    class Parent
    {
        /* *************************************************
        *************        CONSTANTES        *************
       ************************************************** */
       /// <summary>
       /// Modèle du type d'homme
       /// </summary>
        const string MODELE = "HOMO SAPIENS SAPIENS";


        /* **************************************************
        *************        VARIABLES        ***************
       ************************************************** */
        protected string _nom;
        /// <summary>
        /// Age du parent
        /// </summary>
        public int Age;

        public static int counter = 0;

        /* **************************************************
         *************        ACCESSEURS        *************
        ************************************************** */
        /// <summary>
        /// nom du parent
        /// </summary>
        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        /// <summary>
        /// prénom du parent
        /// </summary>
        public string Prenom { get; set; }             //cette écritre est un raccourci et produit le même effet que pour Nom

        /// <summary>
        /// Jour de la naissance de la personne
        /// </summary>
        public Jour JourNaissance { get; set; }


        /* ***************************************************
         *********  CONSTRUCTOR / DESTRUCTOR *************** 
        ************************************************** */
        /// <summary>
        /// Constructeur
        /// </summary>
        public Parent()
       {
           Console.WriteLine("constructeur Parent");
            counter++;
       }

       /// <summary>
       /// Destructeur
       /// </summary>
       ~Parent()
       {
           Console.WriteLine("Destructeur de Parent");
            counter--;
       }

        /* **************************************************
         * ********************** METHODES *******************
         * ************************************************* */
         
        /* ****************** PRINCIPE DE L ENCAPSULATION : partie accessible depuis l'extérieur **************** */

         /// <summary>
         /// Methode affichant une pratique courante d'affichage des paramètres sous forme de liste
         /// </summary>
         /// <param name="parametreTypeString"></param>
         /// <param name="parametreTypeInt"></param>
         /// <param name="parametreTypeDouble"></param>
         /// <param name="parametreTypeFloat"></param>
         /// <param name="autreParametreTypeInt"></param>
        public void maMethode(string parametreTypeString, 
                                int parametreTypeInt, 
                                double parametreTypeDouble, 
                                float parametreTypeFloat,
                                int autreParametreTypeInt)
        {
            // ajouter du code 
            Console.WriteLine("Execution de maMethode");
            // faire appel à une méthode privée pour le principe de l'encapsulation
            int resultatDeCalcul = unCalcul(2, 3);                          //ne renseigne que 2 paramètres
            int resultatDunAutreCalcul = unCalcul(1, 2, 5);                 // renseigne 3 paramètres
            int resultatCalculCible = unCalcul(unTroisiemeChiffre: 9, unPremierChiffre: 1, unDeuxiemeChiffre: 4);

            int resultatIntDOut;
            string resultatStringDOut;
            parametreEnSortie(3, out resultatIntDOut, out resultatStringDOut);  // l'appelle à ce type de méthode permet des retours multiples par une même fonction
            
      
        }

        /* ****************** PRINCIPE DE L ENCAPSULATION : partie cachée **************** */

        /// <summary>
        /// Méthode opérant une addition et prenant 3 paramètres dont 2 obligatoires. Cette méthode sera accessible aux héritiers
        /// </summary>
        /// <param name="unPremierChiffre"></param>
        /// <param name="unDeuxiemeChiffre"></param>
        /// <param name="unTroisiemeChiffre"></param>
        /// <returns>L'addition des variables</returns>
        protected int unCalcul(int unPremierChiffre, 
                               int unDeuxiemeChiffre,
                               int unTroisiemeChiffre = 3)
        {
            return unPremierChiffre + unDeuxiemeChiffre + unTroisiemeChiffre;
        }

        /// <summary>
        /// Méthode concatenant une chaine de caractère. Cette méthode ne sera pas accessible aux héritiers mais uniquement à la classe même
        /// </summary>
        /// <param name="unPremierString"></param>
        /// <param name="unAutreString"></param>
        /// <returns></returns>
        private string uneConcatenation( string unPremierString, 
                                         string unAutreString)
        {
            return unPremierString + unAutreString;
        }

        /// <summary>
        /// Cette méthode un peu particulière renvoie des paramètres en sortie
        /// </summary>
        /// <example>
        /// Utilisation : 
        /// <code>
        /// parametreEnSortie(out maVariable1, out maVariable2)
        /// </code>
        /// </example>
        /// 
        ///         
        ///<param name="multiplicateur"></param>
        /// <param name="premierParametre"></param>
        /// <param name="deuxiemeParametre"></param>
        private void parametreEnSortie (int multiplicateur ,
                                        out int  premierParametre, 
                                        out string deuxiemeParametre)
        {
            premierParametre = 1 * multiplicateur;
            deuxiemeParametre = "une chaine de char";
        }

        /* ****************** PRINCIPE DU POLYMORPHISME **************** */

        public virtual void manger()
        {
            Console.WriteLine("Façon de manger des parents (typiquement avec des couverts");
        }



    }
}
 