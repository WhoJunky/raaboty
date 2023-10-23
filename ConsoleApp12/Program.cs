using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        class PrintedEdition
        {
            string AutorName;
            string NameOfBook;
            double Price;

            public string autorName
            {
                get { return AutorName; }
                set { AutorName = value; }
            }

            public string nameOfBook
            { 
              get { return NameOfBook; } 
              set { NameOfBook = value; } 
            }
            public double price
            {
                get { return Price; }
                set { Price = value; }
            }

            public object AverageCustomers { get; private set; }

            public PrintedEdition() 
            {
                AutorName = "";
                NameOfBook = "";
                Price = 0.0;
            }
            public void GetInfo()
            {
                Console.WriteLine("Введите название автора - ");
                AutorName = Console.ReadLine();
                Console.WriteLine("Введите название книги - ");
                NameOfBook = Console.ReadLine();
                Console.WriteLine("Введите цену книги");
                Price = Convert.ToDouble(Console.ReadLine());
            }
            public void SetInfo()
            {
                Console.WriteLine("Название автора ", AutorName);
                Console.WriteLine("Название книги ", NameOfBook);
                Console.WriteLine("Цена книги", Price);
                Console.ReadKey();

            }
            public double AverageNumberOfCustomersAtthestall()
            {
                double AverageNumberCustomers = 0.0;
                if (NumberAtTheStall != 0) 
                {
                    AverageCustomers
                }

            }
        }
        













        static void Main(string[] args)
        {

        }
    }

}
