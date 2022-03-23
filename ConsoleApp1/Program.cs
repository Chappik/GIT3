using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, vvod = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите А\nВведите Б\nСложение\nВычитание\nУмножение\nДеление");
                vvod = Convert.ToInt32(Console.ReadLine());

                if(vvod ==1) { a = int.Parse(Console.ReadLine()); }
                


                if (vvod == 2) { b = int.Parse(Console.ReadLine()); }

                if (vvod == 3) { Console.WriteLine(a+b); }


                if (vvod == 4) { Console.WriteLine(a-b); }



                if (vvod == 6) { Console.WriteLine(a / b); }
                Console.ReadKey();

               

                if (vvod == 5) { Console.WriteLine(a*b); }
            }
        }
    }
}
