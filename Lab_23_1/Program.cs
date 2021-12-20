using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_23_1
{
    class Program
    {
        static int Factorial (int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            int r = Method2Async().Result;
            Console.ReadKey();
        }
        static async Task<int> Method2Async()
        {
            Console.WriteLine("Введите целое значение в пределах 0 < n < 12");
            int n = int.Parse(Console.ReadLine());
            int result = await Task.Run(() => Factorial(n));
            Console.WriteLine("{0}!={1}", n, result);
            return result;
        }
    }
}
