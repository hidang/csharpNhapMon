using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 2 so: ");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine("1: +");
            Console.WriteLine("2: -");
            Console.WriteLine("3: *");
            Console.WriteLine("4: /");
            Console.Write("Nhap thao tac = ");
            int thaotac = int.Parse(Console.ReadLine());
            switch (thaotac)
            {
                case 1:
                    Console.WriteLine(Math.Round(a + b, 2));
                    break;
                case 2:
                    Console.WriteLine(Math.Round(a - b, 2));
                    break;
                case 3:
                    Console.WriteLine(Math.Round(a * b, 2));
                    break;
                case 4:
                    Console.WriteLine(Math.Round(a / b, 2));
                    break;
                default:
                    Console.WriteLine("Sai thao tac");
                    break;
            }
        }
    }
}
