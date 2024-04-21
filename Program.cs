using System;

class Program
{
    static void Main(string[] args) {
        int maxRandomValue = 100;
        Random random = new Random();
        string text = "just text";
        string command;
        bool IsWork = true;

        Console.WriteLine("Список доступных команд:");
        Console.WriteLine("input");
        Console.WriteLine("print");
        Console.WriteLine("random");
        Console.WriteLine("clear");
        Console.WriteLine("exit");

        while (IsWork)
        {
            Console.Write("Ваша команда: ");
            command = Console.ReadLine();

            if (command == "input")
                text = Console.ReadLine();
            else if (command == "print")
                Console.WriteLine(text);
            else if (command == "random")
                Console.WriteLine($"Рандомное число: {random.Next(0, maxRandomValue)}");
            else if (command == "clear")
                Console.Clear();
            else if (command == "exit")
                IsWork = false;
        }
    }
}
