using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgOrieObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nombre d'enfants : {0}", Enfant.counter);
            Enfant enfant = new Enfant();
            Console.WriteLine("Nombre d'enfants : {0}", Enfant.counter);
            DernierVivant dernierVivant = new DernierVivant();
            Console.WriteLine("Nombre de personnes : {0}", Parent.counter);
            Console.WriteLine("paf le dernier vivant est mort...");
            dernierVivant = null;                                             //ne détruit pas l'objet immédiatement
            Console.WriteLine("Nombre de personnes : {0}", Parent.counter);   // tant que le Garbage Collector n'est pas passé, le nombre de personne n'est pas décrémenté
            Parent parent = new Parent();
            enfant.Prenom = "jean";
            Console.WriteLine("naissance de Jean");
            enfant.JourNaissance = Jour.lundi;
            enfant.manger();

            //Que donne l'instantiation suivante ??
            Humain humain = new Parent();
            

            // et ceci est il possible?
            Humain[] tableauDHumain = { enfant, parent, dernierVivant };      

            

            //Appelle à la classe statique (sans instanciation) 
            Lettre.ver();
        }
    }
}
