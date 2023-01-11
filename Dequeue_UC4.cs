using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssig
{
    public class Dequeue_UC4
    {
        public void Dequeue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);


            foreach (int ele in queue)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("Peek" + queue.Peek());
            Console.WriteLine("---------------------");

            queue.Dequeue();
            Console.WriteLine("Peek" + queue.Peek());
            foreach (int ele in queue)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
