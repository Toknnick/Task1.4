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
            int totalPictures = 52;
            int picturesInRow = 3;
            int filledRow = totalPictures / picturesInRow;
            totalPictures -= filledRow * picturesInRow;
            
            Console.WriteLine($"Заполняно рядов : {filledRow}");
            Console.WriteLine($"Осталось картинок : {totalPictures}");
        }
    }
}
