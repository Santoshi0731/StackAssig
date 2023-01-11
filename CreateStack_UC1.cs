using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAssig
{
    public class CreateStack_UC1
    {
        public void DisplayStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            

            foreach (int ele in stack)
            {
                Console.WriteLine(ele);
            }

            
            
        }
    
    }
}
