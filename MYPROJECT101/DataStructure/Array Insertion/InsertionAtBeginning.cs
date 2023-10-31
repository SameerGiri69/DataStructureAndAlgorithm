using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECT101.DataStructure.Array_Insertion
{
    public class InsertionAtBeginning
    {
        public void StartInsertion()
        {
            int[] numbers = new int[6];
            int length = 0;
            for (int i = 0; i < 3; i++)
            {
                numbers[length] = i;
                length++;    
            }
            //simply shifts the value of i to i+1;
            for (int i = 3; i>=0; i--)
            {
                //it simply just puts the value of index 3 to index 4 and index 2 to index 3 and so on 
                
                numbers[i +1] = numbers[i];
            }
            numbers[0] = 69;
        }
        
    }
}
