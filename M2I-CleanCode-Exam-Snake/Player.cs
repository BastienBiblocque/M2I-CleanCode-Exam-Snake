using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2I_CleanCode_Exam_Snake
{
    internal class Player
    {
        public Player(String name)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentException(string.Format("Player name is not valid."));
            Name = name;
            Score = 0;
        }

        public int Score { get; set; }
        public String Name { get; set; }
    }
}
