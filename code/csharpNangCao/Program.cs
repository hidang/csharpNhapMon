using System;
using System.Collections.Generic;

namespace csharpNangCao
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap n: ");
            n = int.Parse(Console.ReadLine());

            //DungDeQuy(n);
            DungCT(n);
            //DungVongLapVoiList(n);
        }
        private static void DungCT(int n)//Fn = {[(√5 + 1)/2] ^ n} / √5 
        {
            static int fib(int n)
            {
                double phi = (1 + Math.Sqrt(5)) / 2;
                return (int)Math.Round(Math.Pow(phi, n)
                                        / Math.Sqrt(5));
            }
            for (int i = 0; i < n; i++) Console.WriteLine(fib(i));       
        }
        private static void DungVongLapVoiList(int n)
        {
            var finbonacciList = new List<int> { 0, 1 };//khoi tao 2 phan tu ban dau de khong dung if ở loop

            while (finbonacciList.Count < n) //đến khi nào độ dài List kq bằng n thì ngưng loop
            {
                var number1 = finbonacciList[finbonacciList.Count - 1];
                var number2 = finbonacciList[finbonacciList.Count - 2];
                finbonacciList.Add(number1 + number2);
            }
            //duyet List vao in ra tung phan tu kq
            foreach (var item in finbonacciList) Console.WriteLine(item);
        }
        public static void DungDeQuy(int n)
        {
            static int Fibonacci(int n)
            {
                if (n == 0 || n == 1)
                {
                    return n;
                }
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            return;
        }
    }
}
