using PlayerClass;

namespace Casino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в шедевроказино!");
            
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
                        Console.WriteLine("bb");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
                if (player.IsAccountDeleted)
                {
                    Console.WriteLine("Вы проиграли, т.к. ваш баланс равен нулю!" +
                    "\nВАША УЧЕТНАЯ ЗАПИСЬ УДАЛЕНА");
                }
            }
        }
    }
}
