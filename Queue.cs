using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class Item
        {
           public int value;
            public Item next;

            public Item(int value)
            {
                this.value = value;
                this.next = null;
            }

        }
        public class Queue
        {
            Item head;
            Item tail;

            // constructor
            public Queue() { }

            public void Enqueue(int value)
            {
                Item it = new Item(value);
                if (head == null)
                {
                    head = it;
                    tail = it;
                }
                else
                {
                    tail.next = it;
                    tail = it;
                }
            }
             public int Dequeue () {
                if (head == null)
                {
                    Exception e = new Exception();
                    throw e;
                }
                else {
                    int value = head.value;
                    head = head.next;
                    return value;
                }

            }
            public int Peek() {
                if (head == null)
                {
                    Exception a = new Exception();
                    throw a;
                }
                else {
                    return head.value;
                }

            }
        }

        static void Main(string[] args)
        {
            Queue q = new Queue();

            for (int i = 0; i <= 10; i++) {
                q.Enqueue(i);
            }
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Peek());

        }
    }
}
