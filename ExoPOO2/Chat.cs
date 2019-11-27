using System;
using System.Collections.Generic;
using System.Text;

namespace ExoPOO2
{
    class Chat:Animal
    {
        public Chat(string _nom)
        {
            this.nom = _nom;
        }

        new public void Jouer(string _compagnon)
        {
            System.Console.WriteLine("Miaou! Joue avec " + _compagnon);
        }
    }

}
