using System;
using System.Collections.Generic;

namespace SixthTask
{
    // Code a program that detects a loop in a linked list
    // Note : the loop is an element that points to a previous element in the linked list
    public class LinkedList
    {
        public Node head;

        public class Node
        {
            public int data;
            public Node next;
            
            public Node(int data)
            {
                this.data = data;
            }
        }

        public void Push(int newData)
        {
            // Allocate the node and put in the data
            Node newNode = new Node(newData);

            // make next of newNode as head
            newNode.next = head;

            // move the head to point to the next node
            head = newNode;
        }

        public static bool DetectLoop(Node head)
        {
            HashSet<Node> nodesHashSet = new HashSet<Node>();

            while (head != null)
            {
                if (nodesHashSet.Contains(head))
                {
                    return true;
                }

                nodesHashSet.Add(head);

                head = head.next;
            }

            return false;
        }

        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.Push(15);
            linkedList.Push(6);
            linkedList.Push(18);
            linkedList.Push(9);

            linkedList.head.next.next.next.next = linkedList.head;

            if (DetectLoop(linkedList.head))
            {
                Console.WriteLine("Loop found");
            }
            else
            {
                Console.WriteLine("No Loop");
            }
        }
    }
}
