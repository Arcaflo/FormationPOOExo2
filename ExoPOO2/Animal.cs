using System;
using System.Collections.Generic;
using System.Text;

namespace ExoPOO2
{
    class Animal
    {
        protected string nom;
        protected int age;

        public Animal() { }

        public Animal(string _nom)
        {
            this.nom = _nom;
        }

        public void Jouer(string _compagnon)
        {
            System.Console.WriteLine("Joue avec " + _compagnon);
        }
    }


}
