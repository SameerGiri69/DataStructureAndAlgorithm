using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECT101.DataStructure.Stacks
{
    public class Stackkk
    {
        Stack<String> stack = new Stack<String>();
        public void AddData(string data)
        {
            stack.Push(data);
        }
        public void DeleteTop()
        {
            stack.Pop();
        }
        public void DisplayData()
        {
            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }
        }
    }
}
