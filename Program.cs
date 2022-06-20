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
            int inRow = 3;
            int filledRow = total / inRow;
            total -= filledRow * inRow;
            
            Console.WriteLine($"Заолняно рядов : {filledRow}");
            Console.WriteLine($"Осталось картинок : {total}");
        }
    }
}
