using System;

namespace ExoPOO2
{
    class Program
    {
        static void Main(string[] args)
        {
            Chien cn = new Chien("Médor");
            Chat ct = new Chat("Grosminet");
            cn.Jouer("Idefix");
            ct.Jouer("Minou");

            Animal a = (Animal) cn;
            a.Jouer("azerty");
            
        }
    }
}
