using System;
using System.Collections.Generic;

namespace FourthTask
{
    // Code a program that works with a sequence of numbers and prints them in a reverse order
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers count : ");
            int numbersCount = int.Parse(Console.ReadLine());

            Stack<int> numbersStack = new Stack<int>();

            while(numbersCount > 0)
            {
                Console.Write("Enter number : ");
                int number = int.Parse(Console.ReadLine());
                numbersStack.Push(number);
                numbersCount--;
            }

            Console.WriteLine("Printing numbers");

            foreach (var number in numbersStack)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }
    }
}
