using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
            /* int x
            int y
            int z
            
            x = Width; 
            y = Length;
            z = Width * Length 
            */
        {
            Console.WriteLine("How to find the area of a Rectanle.");



            Console.WriteLine("What is the Lenth of the Rectangle?");
            Console.Write("Type Lenth here:");
            string Length;
            Length = Console.ReadLine();

            Console.WriteLine("What is the Width of the Rectangle?");
            Console.Write("Type Width here:");
            string Width;
            Width = Console.ReadLine();

            int lengthnumber = int.Parse(Length);
            int widthnumber = int.Parse(Width);


            int area = lengthnumber * widthnumber;

            Console.WriteLine("The area of the rectangle is" +     area);
            Console.ReadLine();
        }
    }
}
