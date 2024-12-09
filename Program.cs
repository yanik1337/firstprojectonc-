using PlayerClass;
using System.Numerics;
using System;
using RandomGameNameGeneratorClass;
using System.Dynamic;

namespace Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomGameNameGenerator rndName = new RandomGameNameGenerator();
            rndName.RandomNameGenerator();
            Console.WriteLine("");
            string input = "";
            Player player = new Player();

            player.PlayerNameInsert();
            Console.WriteLine();
            player.PlayerMoneyInsert();

            while (input != "0" && !player.IsAccountDeleted)
            {
                Console.WriteLine("\nВыберите игру:");
                Console.WriteLine("1. Игра в кости");
                Console.WriteLine("0. Выход");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        DiceGame diceGame = new DiceGame();
                        diceGame.Play(player);
                        break;
                    case "0":
                        Console.WriteLine("До свиданья!");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
    }
}
