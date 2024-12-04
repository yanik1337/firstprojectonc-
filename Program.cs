using PlayerClass;

namespace Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в шедевроказино!");
            Console.WriteLine("Выберите команду:");
            Console.WriteLine("1. Ввести ник");
            Console.WriteLine("0. Выйти.");

            string input = "";
            input = Console.ReadLine();

            Player player = new Player();

            while (input != "0") 
            {
                if (input == "1")
                {
                    player.PlayerNameInsert();
                    Console.WriteLine();
                    player.PlayerMoneyInsert();
                    break;
                }
                
            }
        }
    }
}