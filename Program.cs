using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 52;
            int row = 0;
            
            for (;total > 3; row++)
            {
                total -= 3;
            }
            Console.WriteLine($"Заполняно рядов : {row}");
            Console.WriteLine($"Осталось картинок : {total}");
        }
    }
}
