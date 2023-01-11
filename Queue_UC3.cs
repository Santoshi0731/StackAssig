using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssig
{
    public class Queue_UC3
    {
        public void Display_Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            

            foreach (int ele in queue)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
