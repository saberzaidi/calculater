using System;

namespace calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my calculater");
            double a;
            double b;
            double c;
            string options;
            Console.WriteLine("Please Enter First no");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please select options:(+,-,*,/");
            options = Console.ReadLine();
            Console.WriteLine("Please Enter Second no");
            b = Convert.ToDouble(Console.ReadLine());

            if (options == "+")

            {
                c = a + b;
                Console.WriteLine(c);
            }

            if (options == "-")

            {
                c = a - b;
                Console.WriteLine(c);
            }
            if (options == "*")

            {
                c = a * b;
                Console.WriteLine(c);
            }
            if (options == "/")

            {
                c = a / b;
                Console.WriteLine(c);
            }

            Console.ReadLine();
        }
    }
}
