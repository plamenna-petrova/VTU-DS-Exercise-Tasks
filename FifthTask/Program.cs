using System;
using System.Collections.Generic;
using System.Linq;

namespace FifthTask
{ 
    // Code a program that works with two sorted linked lists and merges them into one sorted linked list
    public class Program
    { 
        static void PrintLinkedListNodes<T>(LinkedList<T> linkedList)
        {
            foreach (var node in linkedList)
            {
                Console.Write($"{node} ");
            }
            Console.WriteLine();
        }

        static void AddElementToSortedLinkedList<T>(IOrderedEnumerable<T> orderedEnumerable, LinkedList<T> linkedList)
        {
            foreach (var element in orderedEnumerable)
            {
                linkedList.AddLast(element);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first linked list element count : ");
            int firstLinkedListElementCount = int.Parse(Console.ReadLine());

            LinkedList<int> firstLinkedList = new LinkedList<int>();

            while (firstLinkedListElementCount > 0)
            {
                Console.Write("Add element : ");
                firstLinkedList.AddLast(int.Parse(Console.ReadLine()));
                firstLinkedListElementCount--;
            }

            // impossible casting form IOrderedEnumerable to LinkedList<T>

            var firstOrderedEnumerable = firstLinkedList.OrderBy(fll => fll);

            LinkedList<int> firstSortedLinkedList = new LinkedList<int>();

            Console.WriteLine("Printing the elements from the first sorted linked list : ");

            AddElementToSortedLinkedList(firstOrderedEnumerable, firstSortedLinkedList);

            PrintLinkedListNodes(firstSortedLinkedList);

            Console.Write("Enter second linked list element count : ");
            int secondLinkedListElementCount = int.Parse(Console.ReadLine());

            LinkedList<int> secondLinkedList = new LinkedList<int>();

            while (secondLinkedListElementCount > 0)
            {
                Console.Write("Add element : ");
                secondLinkedList.AddLast(int.Parse(Console.ReadLine()));
                secondLinkedListElementCount--;
            }

            var secondOrderedEnumerable = secondLinkedList.OrderBy(sll => sll);

            LinkedList<int> secondSortedLinkedList = new LinkedList<int>();

            Console.WriteLine("Printing the elements from the second sorted linked list :  ");

            AddElementToSortedLinkedList(secondOrderedEnumerable, secondSortedLinkedList);

            PrintLinkedListNodes(secondSortedLinkedList);

            // Merging the two sorted linked lists - the result is an unsorted linked list

            foreach (var node in secondSortedLinkedList)
            {
                firstSortedLinkedList.AddLast(node);
            }

            // sorting the merged linked list as ordered enumerable

            var mergedOrderedEnumerable = firstSortedLinkedList.OrderBy(fll => fll);

            LinkedList<int> mergedSortedLinkedList = new LinkedList<int>();

            AddElementToSortedLinkedList(mergedOrderedEnumerable, mergedSortedLinkedList);

            Console.WriteLine("Printing the elements from the merged sorted linked list : ");

            PrintLinkedListNodes(mergedSortedLinkedList);
        }
    }
}
