using System;

namespace ProgOrieObj
{
    /// <summary>
    /// Classe abstraite définissant l'humain et ses sous classes
    /// </summary>
    abstract class Humain
    {
        /// <summary>
        /// Définition du genre
        /// </summary>
        const string GENRE = "Humain";

        /// <summary>
        /// Définition du lieu de naissance de l'humain
        /// </summary>
        public string LieuNaissance { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Humain ()
        {
            Console.WriteLine("Constructeur de l'objet Humain");
        }

        /// <summary>
        /// Acte permettant d'absorber l'air autour de soit 
        /// pour permettre une absorption de l'oxgène
        /// </summary>
        public void respirer()
        {
            Console.WriteLine("Respirer");
        }

        /// <summary>
        /// Chaque humain marche, mais d'une façon différente
        /// </summary>
        public abstract void marcher();
    }
}