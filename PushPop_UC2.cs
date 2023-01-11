using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssig
{
    public class PushPop_UC2
    {
        public void Pushpop()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);


            foreach (int ele in stack)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("Peek" + stack.Peek());
            Console.WriteLine("-------------------");

            stack.Pop();
            Console.WriteLine("Pop" + stack.Pop());

            foreach (int ele in stack)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
