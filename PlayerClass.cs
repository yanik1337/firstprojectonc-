using System;

namespace PlayerClass
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int Money { get; set; }
        public bool IsAccountDeleted { get; private set; } = false;

        public void PlayerNameInsert()
        {
            Console.WriteLine("Введите ник:");
            PlayerName = Console.ReadLine();
            Console.WriteLine($"Ваш ник: {PlayerName}");
        }

        public void PlayerMoneyInsert()
        {
            Console.WriteLine("Введите кол-во вашего баланса:");
            Console.WriteLine("(баланс не должен быть меньше или равном нулю)");
            string InputMoney = Console.ReadLine();
            Money = int.Parse(InputMoney);
            if (Money < 1)
            {
                throw new Exception("БАЛАНС МЕНЬШЕ НУЛЯ, ИЛИ РАВЕН НУЛЮ");
            }
            Console.WriteLine($"Ваш баланс: {Money}$");
        }
        public void BalanceChecker()
        {
            if (Money <= 0 && !IsAccountDeleted)
            {
                Console.WriteLine("Вы проиграли, т.к. ваш баланс равен нулю!" +
                    "\nВАША УЧЕТНАЯ ЗАПИСЬ УДАЛЕНА");
            }
        }
    }
}
