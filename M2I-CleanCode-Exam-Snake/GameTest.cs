using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2I_CleanCode_Exam_Snake
{
    internal class GameTest
    {

        private Game _game;
        private Dice _dice;

        public GameTest()
        {
            _game = new Game();
            _dice = new Dice();
        }

        [TestCase("Bastien", "Bastien a gagné la partie")]
        [TestCase("Louis", "Louis a gagné la partie")]
        [Test]
        public void DisplayWinnerDisplayGreatMessage(string Name, string ExpectedResult)
        {
            var result = Game.DisplayWinner(Name);
            Assert.That(result, Is.EqualTo(ExpectedResult));
        }

        [TestCase(30,37)]
        [Test]
        public void RollDiceAndAddReturnGoodNumber(int PlayerScore, int ExpectedResult)
        {
            var result = Game.RollDiceAndAddToUserScore(PlayerScore, _dice);
            Assert.IsTrue(result > PlayerScore && result <= ExpectedResult);
        }

        [TestCase(10)]
        [Test]
        public void PLayTurnAndReturnIfStillPlay(int PlayerScore)
        {
            Player Player = new Player("TEST");
            Player.Score = PlayerScore;
            var result = Game.PLayTurnAndReturnIfStillPlay(Player, _dice,50);
            Assert.IsTrue(result);
        }

        [Test]
        public void PLayFirstTurnReturnStillPlayEqualTrue()
        {
            List<Player> PlayerList = new List<Player>();
            PlayerList.Add(new Player("Bastien"));
            PlayerList.Add(new Player("Louis"));

            var result = Game.PlayAllPlayerTurnAndReturnIfStillPlay(PlayerList, _dice,50) ;
            Assert.IsTrue((bool?)result);
        }

        [TestCase(5,15)]
        [TestCase(18,8)]
        [TestCase(7,7)]
        [Test]
        public void TrappedReturnWellScore(int playerScore, int expectedResult)
        {
            var result = Game.TrappedCells(playerScore);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
