using System;
using System.Collections.Generic;
using System.Linq;

namespace ThirdTask
{
    // Code a program that swaps the positions of two elements in a chosen data structure
    class Program
    {
        static void SwapNodes<T>(ref T firstNode, ref T secondNode)
        {
            var temp = firstNode;
            firstNode = secondNode;
            secondNode = temp;
        }

        static void PrintNodes<T>(LinkedList<T> linkedList)
        {
            foreach (var node in linkedList)
            {
                Console.Write($"{node} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            LinkedList<int> linkedListExample = new LinkedList<int>();

            Console.Write("Enter the number of nodes in the linked list: ");
            int numberOfNodes = int.Parse(Console.ReadLine());
            // with a while loop
            while (numberOfNodes > 0)
            {
                Console.Write("Enter node : ");
                linkedListExample.AddLast(int.Parse(Console.ReadLine()));
                numberOfNodes--;
            }

            try
            {
                Console.WriteLine("Enter indexes : ");

                var firstIndex = int.Parse(Console.ReadLine());
                var secondIndex = int.Parse(Console.ReadLine());

                var firstElementAtIndex = linkedListExample.ElementAt(firstIndex);
                Console.WriteLine(firstElementAtIndex);
                var secondElementAtIndex = linkedListExample.ElementAt(secondIndex);
                Console.WriteLine(secondElementAtIndex);

                Console.WriteLine("Elements before swap");

                PrintNodes(linkedListExample);

                SwapNodes(ref firstElementAtIndex, ref secondElementAtIndex);

                Console.WriteLine(firstElementAtIndex);
                Console.WriteLine(secondElementAtIndex);

                Console.WriteLine("Elements after swap");

                if (firstIndex < secondIndex)
                {
                    linkedListExample.Find(firstElementAtIndex).Value = secondElementAtIndex;
                    linkedListExample.Find(secondElementAtIndex).Value = firstElementAtIndex;
                } else
                {
                    linkedListExample.Find(secondElementAtIndex).Value = firstElementAtIndex;
                    linkedListExample.Find(firstElementAtIndex).Value = secondElementAtIndex;
                }

                PrintNodes(linkedListExample);

                Console.WriteLine("Enter values : ");
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());

                if (linkedListExample.Contains(firstValue) && linkedListExample.Contains(secondValue))
                {
                    var firstToSwap = linkedListExample.Find(firstValue).Value;
                    var secondToSwap = linkedListExample.Find(secondValue).Value;

                    SwapNodes(ref firstToSwap, ref secondToSwap);

                    Console.WriteLine("Swapping : ");
                    Console.WriteLine(firstToSwap);
                    Console.WriteLine(secondToSwap);

                    int counter = 0;
                    int positionFirstElement = 0;
                    int positionSecondElement = 0;

                    foreach (var element in linkedListExample)
                    {
                        if (element == firstToSwap)
                        {
                            positionFirstElement = counter;
                        }
                        else if (element == secondToSwap)
                        {
                            positionSecondElement = counter;
                        }
                        counter++;
                    }

                    Console.WriteLine($"Position of the first element {positionFirstElement}");
                    Console.WriteLine($"Position of the second element {positionSecondElement}");

                    if (positionSecondElement < positionFirstElement)
                    {
                        linkedListExample.Find(firstToSwap).Value = secondToSwap;
                        linkedListExample.Find(secondToSwap).Value = firstToSwap;
                    }
                    else
                    {
                        linkedListExample.Find(secondToSwap).Value = firstToSwap;
                        linkedListExample.Find(firstToSwap).Value = secondToSwap;
                    }                   
                }

                PrintNodes(linkedListExample);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }              
        }
    }
}
