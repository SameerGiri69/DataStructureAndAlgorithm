using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECT101.Lambda_expression
{
    public class Lambda
    {
        public int Age { get; set ; }
        public string Name { get; set; }

       

        public static List<Lambda> People = new List<Lambda>()
        {
            new Lambda { Age = 24, Name = "Sameer" },
            new Lambda { Age = 19, Name = "Milan"},
            new Lambda { Age = 69, Name = "HogRidaa"}
        };
        public static void AddPeople(int age, string name)
        {
            People.Add(new Lambda { Age = age, Name = name });
        }

        public static void DisplayPeople()
        {
            var sortByAge = People.OrderBy(p => p.Age);
            foreach (var p in sortByAge)
            {
              //  Console.WriteLine();

                Console.WriteLine(p.Age.ToString() + p.Name.ToString()) ;
            }
        }
        
    }
}
