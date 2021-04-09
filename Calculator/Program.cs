using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tinh = true;
            do
            {
                double a, b;
                Console.WriteLine("--------------------");
                Console.WriteLine("1: +");
                Console.WriteLine("2: -");
                Console.WriteLine("3: *");
                Console.WriteLine("4: /");
                Console.WriteLine("5: Can");
                Console.WriteLine("6: Luy thua");
                Console.Write("Nhap thao tac = ");
                int thaotac = int.Parse(Console.ReadLine());
                switch (thaotac)
                {
                    case 1:
                        InputAvaB(out a, out b);
                        Console.WriteLine(Math.Round(a + b, 2));
                        break;
                    case 2:
                        InputAvaB(out a, out b);
                        Console.WriteLine(Math.Round(a - b, 2));
                        break;
                    case 3:
                        InputAvaB(out a, out b);
                        Console.WriteLine(Math.Round(a * b, 2));
                        break;
                    case 4:
                        InputAvaB(out a, out b);
                        Console.WriteLine(Math.Round(a / b, 2));
                        break;
                    case 5:
                        Console.WriteLine("Nhap so: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine(Math.Round(Math.Sqrt(a), 2));
                        break;
                    case 6:
                        InputAvaB(out a, out b);
                        Console.WriteLine(Math.Round(Math.Pow(a, b), 2));
                        break;
                    default:
                        Console.WriteLine("Sai thao tac");
                        break;
                }
                Console.WriteLine("Nhap Enter de tiep tuc hoac phim bat ki de thoat");
                if (Console.ReadKey(true).Key != ConsoleKey.Enter)
                {
                    tinh = false;
                }
                Console.Clear();
            } while (tinh);
        }

        private static void InputAvaB(out double a, out double b)
        {
            Console.WriteLine("Nhap 2 so: ");
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
        }
    }
}
