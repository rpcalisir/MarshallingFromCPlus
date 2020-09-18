using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Wrapper.HelloWorld();

            Console.WriteLine();

            Console.WriteLine("Sum of two numbers 5+6: " + Wrapper.AddNumbers(5, 6));

            Console.WriteLine(Wrapper.IsLengthGreaterThanFive("thisis"));


            Console.ReadLine();
        }
    }
}
