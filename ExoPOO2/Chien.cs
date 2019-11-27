using System;
using System.Collections.Generic;
using System.Text;

namespace ExoPOO2
{
    class Chien : Animal
    {

        public Chien(string _nom)
        {
            this.nom = _nom;
        }

        public void Aboyer()
        {
            System.Console.WriteLine("Ouaf");
        }

        new public void Jouer(string _compagnon)
        {
            System.Console.WriteLine("Ouaf! Joue avec " + _compagnon);
        }
    }
}
