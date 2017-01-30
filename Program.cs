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
            Console.WriteLine("Nombre de personnes : {0}", DernierVivant.counter);
            enfant.Prenom = "jean";
            Console.WriteLine("naissance de Jean");
            enfant.JourNaissance = Jour.lundi;
            enfant.manger();


            //Appelle à la classe statique (sans instanciation) 
            Lettre.ver();
        }
    }
}
