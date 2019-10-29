using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int a = 0, b = 100;
            int count = 1;
            while (b > a + 1)
            {
                int c = (a + b) / 2;
                Console.Write("Q{0}: Is you number less than {1}? ", count, c);
                answer = Console.ReadLine();
                if (answer == "Y")
                    b = c - 1;
                if (answer == "N")
                    a = c;
                count++;
            }
            Console.Write("Is your number {0}", a);
            answer = Console.ReadLine();
            if (answer == "Y")
                Console.WriteLine("Your number is {0}?", a);
            if (answer == "N")
                Console.WriteLine("Your number is {0}", b);
        }
    }
}
