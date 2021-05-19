using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstTask
{
    // Task: Code a method that removes every nth element in a give data structure
    // Note : the nth element is a console inputed integer 

    class Program
    {
        static void ClearLinkedList<T>(LinkedList<T> linkedList)
        {
            linkedList.Clear();
        }

        static void RemoveNthNodesInLinkedList<T>(LinkedList<T> linkedList, int n)
        {
            var nodesToRemove = linkedList.Where((node, index) => index % n == 0);

            foreach (var node in nodesToRemove.ToList())
            {
                if (linkedList.Contains(node))
                {
                    linkedList.Remove(node);
                }
            }

            foreach (var number in linkedList)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            LinkedList<int> integersList = new LinkedList<int>();
            integersList.AddLast(10); // 0
            integersList.AddLast(15); // 1
            integersList.AddLast(4); // 2
            integersList.AddLast(23); // 3
            integersList.AddLast(9); // 4
            integersList.AddLast(34); // 5 

            LinkedList<string> stringList = new LinkedList<string>();
            stringList.AddLast("John"); // 0
            stringList.AddLast("William"); // 1
            stringList.AddLast("Anne"); // 2
            stringList.AddLast("Jack"); // 3
            stringList.AddLast("Blythe"); // 4
            stringList.AddLast("Jane"); // 5
            stringList.AddLast("Jacob"); // 6

            if (n == 1)
            {
                ClearLinkedList(integersList);
                Console.WriteLine();
                ClearLinkedList(stringList);
            } 
            else if (n == 0)
            {
                Console.WriteLine("Sorry, cannot divide by zero");
            }
            else
            {
                Console.WriteLine("Printing the elements, left in the integers list");
                RemoveNthNodesInLinkedList(integersList, n);
                Console.WriteLine("Printing the elements, left in the string list");
                RemoveNthNodesInLinkedList(stringList, n);
            }
 
        }
    }
}
