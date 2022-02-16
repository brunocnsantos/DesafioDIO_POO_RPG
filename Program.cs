using System;
using DesafioPOO.src.Entities;

namespace DesafioPoo
{

    class program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss("Boss!", "Boss Mesmo!", 999, 999999, 10);   
            Knight arus = new Knight("Arus", "Knight", 25, 100, 10);            
            Wizard jennica = new Wizard("Jennica", "White Wizard", 26, 80, 200);
            Ninja wedge = new Ninja("Wedge", "Ninnnnja muuuuito furrrrtivo!", 25, 90, 30);
            BlackWizard topapa = new BlackWizard("Topapa", "Black Wizard!", 26, 80, 200);

            Console.WriteLine();
            Console.WriteLine("Olá aventureiros, quem são vocês e o que querem na minha masmorra?");
            Console.WriteLine(boss);
            Console.WriteLine();
            Console.WriteLine(arus);
            Console.WriteLine("Vou derrotá-lo com minha espada! Vilão malvado!");
            Console.WriteLine();
            Console.WriteLine(jennica);
            Console.WriteLine("Sou uma Bruxa Branca muito poderosa e vou subjugar tal criatura vil!");
            Console.WriteLine();
            Console.WriteLine(wedge);
            Console.WriteLine(@"Aquele que você nem viu chegar e poderia matá-lo pelas costas, 
            mas sou muito honrado para fazer esta covardia.");
            Console.WriteLine();
            Console.WriteLine(topapa);
            Console.WriteLine(@"E por fim, eu saio das sombras para evocar os mortos e acabar com você! 
            Pois sou... O MAGO NEGRO MAIS PODEROSO JÀ CONHECIDO!!!");
            Console.WriteLine();
            Console.WriteLine(topapa.Attack());
            Console.WriteLine();
            Console.WriteLine(jennica.Attack(2));
            Console.WriteLine("Jennica tentou novamente e ...");
            Console.WriteLine(jennica.Attack(10));
            Console.WriteLine();
            Console.WriteLine(wedge.Attack());
            Console.WriteLine();
            Console.WriteLine(arus.Attack());
            Console.WriteLine();
            Console.WriteLine(@"Depois de uma terrível batalha, Boss vai ao chão! 
            Vitória! O bem vence o mal
            MÙSICA - São cinco cavaleiros combatendo sempre as forças do mal
            Valentes, destemidos, nessa luta eles só pensam em vencer
            São magos das estrelas, eles são os cavaleiros do astral...");

        }
    }
}

