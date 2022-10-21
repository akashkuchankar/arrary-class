using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrary_class
{
    internal class Class1
    {
        static void Main(string[] args)
        {
                                                             // FIFO (first in first out)

            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);

            q.Dequeue();                                    // remove the first element  10

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("first element in queue " + q.Peek());   // return the first element
        }

    }
}

