using System;
using System.Collections.Generic;

namespace SecondTask
{
    // Code a program that merges two instances of a chosen data structure
    // The merging is carried out by adding elements from the beginning of each structure
    // until the elements there are no elements left in the one structure
    // then the rest of the elements should be added at the end
    // example structure 1 - (1, 2, 3), structure 2 (4, 5, 6, 7, 8)
    // expected result - (1, 4, 2, 5, 3, 6, 7, 8)

    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstQueue = new Queue<int>();
            firstQueue.Enqueue(1);
            firstQueue.Enqueue(2);
            firstQueue.Enqueue(3);

            Queue<int> secondQueue = new Queue<int>();
            secondQueue.Enqueue(4);
            secondQueue.Enqueue(5);
            secondQueue.Enqueue(6);
            secondQueue.Enqueue(7);
            secondQueue.Enqueue(8);

            Queue<int> mergedQueue = new Queue<int>();
            
            while (firstQueue.Count > 0 || secondQueue.Count > 0)
            {
                if (firstQueue.Count > 0)
                {
                    mergedQueue.Enqueue(firstQueue.Dequeue());
                }
                if (secondQueue.Count > 0)
                {
                    mergedQueue.Enqueue(secondQueue.Dequeue());
                }    
            }

            foreach (var queueItem in mergedQueue)
            {
                Console.Write($"{queueItem} ");
            }
        }
    }
}
