using System;

class Program
{
    static void Main(string[] args) {
        int maxRandomValue = 100;
        Random random = new Random();
        string text = "just text";
        string command;
        bool isWork = true;
        string commandInput = "input";
        string commandPrint = "print";
        string commandRandom = "random";
        string commandClear = "clear";
        string commandExit = "exit";

        Console.WriteLine("Список доступных команд:");
        Console.WriteLine(commandInput);
        Console.WriteLine(commandPrint);
        Console.WriteLine(commandRandom);
        Console.WriteLine(commandClear);
        Console.WriteLine(commandExit);

        while (isWork)
        {
            Console.Write("Ваша команда: ");
            command = Console.ReadLine();

            if (command == commandInput)
                text = Console.ReadLine();
            else if (command == commandPrint)
                Console.WriteLine(text);
            else if (command == commandRandom)
                Console.WriteLine($"Рандомное число: {random.Next(0, maxRandomValue)}");
            else if (command == commandClear)
                Console.Clear();
            else if (command == commandExit)
                isWork = false;
        }
    }
}
