using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECT101.DataStructure.Array_Insertion
{
    public class CustomInsertion
    {
        public void InsertAnywhere()
        {
            int length  = 0;
            int[] numbers = new int[10];
            for (int i = 0; i < 6; i++)
            {
                numbers[length] = i;
                length++;
            }
            //inserting at index 3
            for (int i = 6; i >= 3; i--)
            {
                numbers[i+1] = numbers[i];
            }
            numbers[3] = 69;
        }
    }
}
