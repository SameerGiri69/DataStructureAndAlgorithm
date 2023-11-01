using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYPROJECT101.DataStructure.JaggedArrays
{
    public class JArrays
    {
        string[][] Troops = new string[2][];
        
        public void ElixirTroops()
        {
            Troops[0] = new string[] {"barb", "archer", "giant", "wallbreaker"};
        }

        public void DarkElixirTroops()
        {
            Troops[1] = new string[] {"minnion", "hogrider", "valk"};
        }
        public void DisplayTroops()
        {
            var cntu = Troops;

            ElixirTroops();
            DarkElixirTroops();
            var cnt = Troops;
       //     var it = Troops[1].Length;
            for (int i = 0; i < Troops.Length; i++)
            {
                for(int j = 0; j <= Troops[i].Length -1; j++)
                {
                    Console.WriteLine(Troops[i].GetValue(j));
                }
            }
        }

    }
}
