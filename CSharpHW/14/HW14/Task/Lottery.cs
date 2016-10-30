using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Lottery
    {
        public int[] MagicNumbers { get; private set; }

        public void GenNewNubers()
        {
            MagicNumbers = new int[6];
            Random rand = new Random();
            for (int i = 0; i < MagicNumbers.Length; i++)
                MagicNumbers[i] = rand.Next(1, 10);
        }

        public override string ToString()
        {
            var res = string.Empty;
            foreach (var item in MagicNumbers)
            {
                res += item + " ";
            }
            return res;
        }

        public void CheckForWin(int[] usersNumbers)
        {

            int correctNumbers = 0;
            for (int i = 0; i < MagicNumbers.Length; i++)
            {
                for (int j = 0; j < MagicNumbers.Length; j++)
                {
                    if(MagicNumbers[j]==0)
                        continue;
                    if (usersNumbers[i] == MagicNumbers[j])
                    {
                        correctNumbers++;
                        MagicNumbers[j] = 0;
                        i++;

                        if(i==6)
                            break;
                        j = -1;
                    }       
                }
            }
            Console.WriteLine("Number of Correct numbers is {0}", correctNumbers);
            if(correctNumbers == MagicNumbers.Length)
                Console.WriteLine("CONGRATULATION! IT'S JACKPOT!");
        }
        public int this[int index]
        {
            get { return MagicNumbers[index]; }
        }
    }
}
