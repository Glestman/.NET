using System;
using Aplicacao_RPG.src.Entitites;

namespace Aplicacao_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Herois heroi = new Herois("Arus",23,"Knight");
            
            Console.WriteLine(heroi);
        }
    }
}
