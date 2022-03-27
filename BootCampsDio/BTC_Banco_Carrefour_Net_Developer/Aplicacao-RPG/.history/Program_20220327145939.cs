using System;
using Aplicacao_RPG.src.Entitites;

namespace Aplicacao_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard(" Jennica", 23, "White Wizard");
            Ninja ninja = new Ninja(" Wedge", 26, "Ninja");
      
            
            Console.WriteLine(wizard.Attack(20));
            Console.WriteLine(wizard.Attack(20));
            Console.WriteLine(knight.Attack());
            Console.WriteLine(ninja.Attack(20));
        }
    }
}
