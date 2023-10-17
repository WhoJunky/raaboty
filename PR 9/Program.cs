using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Здравстуйте!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Введите массив целых чисел через пробел: ");
                Console.ForegroundColor = ConsoleColor.White;
                string input = Console.ReadLine();
                string[] stringNumbers = input.Split(' ');

                Console.Write("Введите натуральное число A: ");
                int A = int.Parse(Console.ReadLine());

                int count = 0;

                foreach (string Numbers in stringNumbers)
                {
                    int number = int.Parse(Numbers);

                    if (number > 0 && number <= A)
                    {
                        count++;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Количество положительных элементов, не превосходящих {A}: {count}");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Пожалуйста, введите корректные значения." + fe.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception e) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Введено слишком большое число. Введите меньшее значение для A." + e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Хотите выполнить программу снова? (да/нет): ");
            Console.ForegroundColor = ConsoleColor.White;
            string repeat = Console.ReadLine().ToLower().Trim();
            if (repeat != "да")
            {
                break;
            }
        }
    }
}