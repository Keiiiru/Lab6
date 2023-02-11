namespace Lab6
{
    public interface IMoney
    {
        int Balance { get; set; }
        void IncBalance(int amount);
        void DecBalance(int amount);
    }

    public interface IHealth
    {
        int Health { get; set; }
        void IncHealth(int amount);
        void DecHealth(int amount);
    }

    public class Bank : IMoney
    {
        public Bank()
        {
            Balance = 10000;
        }

        public int Balance { get; set; }
        public void IncBalance(int amount) { Balance += amount; }
        public void DecBalance(int amount) { Balance -= amount; }
    }

    public class Player : IMoney, IHealth
    {
        public Player(string pUsername)
        {
            Username = pUsername;
            Health = 100;
            Balance = 1000;
        }

        public string Username;

        public int Health { get; set; }
        public void IncHealth(int amount) { Health += amount; }
        public void DecHealth(int amount) { Health -= amount; }

        public int Balance { get; set; }
        public void IncBalance(int amount) { Balance += amount; }
        public void DecBalance(int amount) { Balance -= amount; }
    }
    public class Lab6
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Title = "Лабараторная работа #6";

            Bank bank = new();
            Player player = new("admin");

            player.DecBalance(100);
            bank.IncBalance(100);
            player.IncHealth(10);

            Console.WriteLine(
                "Состояние банка: {0}", bank.Balance
            );
            Console.WriteLine();
            Console.WriteLine(
                "Имя игрока: {0}\n" +
                "Текущий баланс: {1}\n" +
                "Здоровье: {2}",
                player.Username, player.Balance, player.Health
            );
        }
    }
}