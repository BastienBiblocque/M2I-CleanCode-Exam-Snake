using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace M2I_CleanCode_Exam_Snake
{
    internal class Game
    {
        List<Player> PlayerList = new List<Player>();
        Dice Dice = new Dice();
        Boolean StillPlay;

        public int Size;
        public Game()
        {
            PlayerList.Add(new Player("Bastien"));
            PlayerList.Add(new Player("JP"));

            StillPlay = true;

            Size = 50;

            while (StillPlay)
                StillPlay = (bool)PlayAllPlayerTurnAndReturnIfStillPlay(PlayerList, Dice, Size);
        }

        internal static object PlayAllPlayerTurnAndReturnIfStillPlay(List<Player> playerList, Dice Dice, int Size)
        {
            foreach (Player Player in playerList)
            {
                if (!PLayTurnAndReturnIfStillPlay(Player, Dice, Size))
                    return false;
            }
            return true;
        }

        public static Boolean PLayTurnAndReturnIfStillPlay(Player Player, Dice Dice, int Size)
        {
            Player.Score = RollDiceAndAddToUserScore(Player.Score, Dice);
            if (Player.Score > Size)
                Player.Score = 25;
            else if (Player.Score == Size)
                return CallDisplayWinnerAndReturnFalse(Player.Name);
            return true;
        }

        public static int TrappedCells(int PlayerScore)
        {
            if (PlayerScore == 5)
                return 15;
            else if (PlayerScore == 18)
                return 8;
            else
                return PlayerScore;
        }

        public static string DisplayWinner(string PlayerName)
        {
            Console.WriteLine("{0} a gagné la partie", PlayerName);
            return (PlayerName + " a gagné la partie");
        }
        
        public static int RollDiceAndAddToUserScore(int UserScore, Dice Dice)
        {
            return (UserScore + Dice.RollDice());
        }
        private static Boolean CallDisplayWinnerAndReturnFalse(string Name)
        {
            DisplayWinner(Name);
            return false;
        }
    }
}
