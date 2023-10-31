using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECT101.DataStructure
{
    public class Lists
    {
        List<String> name = new List<string>();
        
        public void Name()
        {
            name.Add("Sameer");
            name.Add("Milan");
            name.Add("Hog rider");
        }
        List<int> age = new List<int>();
        public void Age()
        {
            age.Add(19);
            age.Add(25);
            age.Add(69);
        }
        public void DisplayNameAndAge()
        {
            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine($"My name is {name[i]} and i am {age[i]} years old ");
            }
        }
    }
}
