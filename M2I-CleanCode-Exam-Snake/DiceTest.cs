using System.Xml.Linq;

namespace M2I_CleanCode_Exam_Snake
{
    public class DiceTest
    {
        
        private Dice _dice;

        public DiceTest()
        {
            _dice = new Dice();
        }

        [TestCase()]
        [Test]
        public void RollDiceReturnNumberBetweenOneAndSix()
        {
            var result = _dice.RollDice();
            Assert.IsTrue(result >= 1 && result <= 6);
        }
    }
}