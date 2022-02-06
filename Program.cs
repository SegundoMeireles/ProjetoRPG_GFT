using System;
using AbstraindoWarrior.entities;
using AbstraindoWizard.entities;
using AbstraindoKnight.entities;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
        warrior hero1 = new warrior("Arus", 23, "warrior"); 
        Wizard hero2 = new Wizard("Jennica", 23, "White Wizard");
        Knight hero3 = new Knight("Peter", 27, "Knight");
        
        Console.WriteLine(hero1.Attack(1));
        Console.WriteLine(hero2.Attack(2));
        Console.WriteLine(hero3.Attack(1));
        }
    }
}