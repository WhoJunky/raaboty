//**********************************************************************************************
//*Практическая работа 8                                                                       *
//*Выполнил: Хамзин Р.М.                                                                       *
//*Задание: написать программу, которая подсчитает сумму всех нечетных чисел в диапазоне [a,b]  *
//**********************************************************************************************
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Практическая работа номер 7. \nЗдравствуйте");
        try
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nВведите целое нечетное число:");
            Console.ForegroundColor = ConsoleColor.White;
            int a = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nВведите второе целое нечетное число:");
            Console.ForegroundColor = ConsoleColor.White;
            int b = Convert.ToInt32(Console.ReadLine());

            while (a > b)
            {
                if (a == b)
                    Console.WriteLine("");
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка. Левая граница должна быть больше правой");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
            int sum = 0;
            int currentNum = a;

            while (currentNum <= b)
            {
                // Проверяем, является ли текущее число нечетным
                if (currentNum % 2 != 0)
                {
                    sum += currentNum; // Если число нечетное, добавляем его к сумме
                }
                currentNum++;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Сумма всех нечетных чисел в диапазоне [{0}, {1}] равна: {2}", a, b, sum);
        }
        catch (FormatException fe)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы ввели некорректное значение. Пожалуйста, введите целое число." + fe.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Произошла ошибка: " + ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.ReadLine();
    }
}
















//Вводим числа 3 и 7 (Нечетные)
//Сумма в диапазоне этих чисел будет равна 15
//4 + 5 + 6 = 15