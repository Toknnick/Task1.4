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
            int PicturesInRow = 3;
            int filledRow = totalPictures / PicturesInRow;
            totalPictures -= filledRow * PicturesInRow;
            
            Console.WriteLine($"Заолняно рядов : {filledRow}");
            Console.WriteLine($"Осталось картинок : {totalPictures}");
        }
    }
}
