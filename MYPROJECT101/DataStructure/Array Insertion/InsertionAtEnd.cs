using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECT101.DataStructure.Array_Insertion
{
    public class InsertionAtEnd
    {
        public void DummyData()
        {
            int length = 0;
            int[] numbers = new int[6];
            for (int i = 0; i < 3; i++)
            {
                numbers[length] = i;
                length++;
            }
            numbers[length] = 10;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
       
    }
}
