using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWorks
{
    public class Rectangle
    {

        public int Width { get; set; }
        public int Height { get; set; }
        public char tav { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"The rectangle inner properties are:");
            Console.WriteLine($"Width:{Width}, Height:{Height}");

        }

        public void Draw(bool isFull)
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (isFull)
                    {
                        Console.Write(tav);
                    }
                    else if (!isFull)
                    {
                        if (i == 0 || i == Height - 1 || j == 0 || j == Width - 1)
                        {
                            Console.Write(tav);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public int GetArea()
        {
            int area = Width * Height;
            return area;
        }

        public int GetPerimeter()
        {
            int Perimeter = (2 * Width) + (2 * Height);
            return Perimeter;
        }


    }
}
