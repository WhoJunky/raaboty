using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test11
{
    class Program
    {
        class Figure // класс родитель
        {
            int n; // кол-во сторон фигуры, для окружности n = 1
            double[] sz; // динамический массив длин сторон, для окружности - радиус
            Figure() // конструктор
            {
                Console.WriteLine("---- Абстрактная геометрическая фигура ----");
            }
            ~Figure() { } // деструктор
            public virtual double Perimetr() // вычисление периметр
            {
                double Per = 0;
                for (int i = 0; i < n; i++)
                {
                    Per += sz[i];
                }
                return Per;
            }
            public virtual double Square() // вычисление площади фигуры
            {
                return 0; // метод пустой, т.к. у абст. фиугры площадь не вычислить
            }
            public virtual void GetInfo() // вывод информации о фигуре
            {
                Console.WriteLine("Фигура абстрактная. Сведений нет.");
            }
            class FRectangle : Figure // класс-наследник (прямоугольник)
            {
                public FRectangle() // конструктор класса
                {
                    Console.WriteLine("1. Параметры фигуры: \n");
                    n = 4;
                    sz = new double[n]; // массив для 4 сторон прямоугольника
                    Console.Write("Введите длины сторон: \n");
                    Console.Write("\ta = ");
                    sz[0] = sz[2] = Double.Parse(Console.ReadLine());
                    Console.Write("\tb = ");
                    sz[1] = sz[3] = Double.Parse(Console.ReadLine());
                }
                ~FRectangle() // деструктор класса, уничтожение объекта
                {
                    Console.WriteLine("Уничтожена геометрическая фигура: прямоугольник.");
                }
                public override double Square() // переопределение метода, новая реализация метода
                {
                    return Math.Round(sz[0] * sz[1], 3);
                }
                public override void GetInfo()
                {
                    Console.WriteLine($"Фигура: прямоугольник.\nПри заданных длинах сторон a = {sz[0]} и b = {sz[1]} периметр фигуры = {Perimetr()}, площадь = {Square()}.");
                }
            }

            static void Main(string[] args)
            {
                Console.ReadKey();
            }
        }
    }
}
        
