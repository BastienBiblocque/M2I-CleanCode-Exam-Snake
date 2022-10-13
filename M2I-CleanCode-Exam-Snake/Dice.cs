using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2I_CleanCode_Exam_Snake
{
    internal class Dice
    {
        public Dice()
        {
            Max = 6;
        }

        public int Max { get; set; }

        public int RollDice()
        {
            Random Rnd = new Random();
            return Rnd.Next(Max);
        }
    }
}
