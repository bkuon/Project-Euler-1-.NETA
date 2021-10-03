using System;
using System.Collections;
using System.Linq;

namespace Euler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 1000)
                .Where(n => n % 3 == 0 || n % 5 == 0);

            var sum = numbers.Sum();
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
