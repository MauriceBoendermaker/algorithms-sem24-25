using System;
using System.ComponentModel;

namespace Lesson3
{
    public class Program
    {
        public static void Main(string[] args)
        {

        }

        class Node
        {
            public int Data;
            public Node? Next = null;

            public Node(int d, Node? Next = null)
            {
                Data = d;
                this.Next = Next;
            }
        }

        class LinkedList
        {
            Node? First = null;
            // Node? Last = null;

            void AddFirst(int value)
            {
                First = new Node(value, First);
            }

            // Linked List implementation of Queue
            void AddLast(int value)
            {
                var newNode = new Node(value);
                if (First == null)
                {
                    First = newNode;
                    return;
                }

                var current = First;

                while (current.Next != null)
                    current = current.Next;

                current.Next = newNode;
            }

            Node? Display(int key)
            {
                var current = First;
                while (current != null)
                {
                    if (key == current.Data) return current;

                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
                return null;
            }

            void addSorted(int value)
            {
                if (First == null || value < First.Data)
                {
                    First = new Node(value, First);
                }

                var current = First;
                while (current.Next != null && value < current.Next.Data)
                {
                    current = current.Next;
                }
                
                current.Next = new Node(value, current.Next);
            }

            void Remove(int value)
            {
                if (First == null) return;
                if (First.Data == value)
                {
                    First = First.Next;
                    return;
                }

                var current = First;
                while (current.Next != null)
                {
                    if (current.Data == value)
                    {
                        
                    }
                    current = current.Next;
                }
            }

            int RemoveNode()
            {
                if (First == null) return default;

                var temp = First.Data;
                First = First.Next;

                return temp;
            }
            // -----
        }

        /*

        First = x
        5 ->
        First = (5, x)
        4 ->
        First = (4, (5, x))
        3 ->
        First = (3, (4, (5, x)))
        2 ->
        First = (2, (3, (4, (5, x))))

        */

        interface Stack
        {
            bool push(int value);
            int pop();
            int peek(); // Top
        }

        class ArrayStack : Stack
        {
            int[] arr;
            int index;

            public ArrayStack(int size = 5)
            {
                arr = new int[size];
                index = -1; // Next empty location (0 = current empty location)
            }

            public int peek()
            {
                throw new NotImplementedException();
            }

            public int pop()
            {
                return arr[index--];
            }

            public bool push(int value)
            {
                if (index >= arr.Length) return false;

                arr[++index] = value;
                return true;
            }
        }

        class LLStack : Stack
        {
            public int peek()
            {
                throw new NotImplementedException();
            }

            public int pop()
            {
                throw new NotImplementedException();
            }

            public bool push(int value)
            {
                throw new NotImplementedException();
            }
        }

        interface Queue
        {
            void Enq(int value);
            int Deq();
        }

    }
}

// First = Null
// First = (5, Null)
// First = (6, (5, Null))