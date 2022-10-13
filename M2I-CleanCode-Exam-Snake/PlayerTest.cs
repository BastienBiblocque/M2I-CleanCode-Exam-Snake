using System.Xml.Linq;

namespace M2I_CleanCode_Exam_Snake
{
    public class PlayerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestCase("Bastien","Bastien")]
        [Test]
        public void AddPlayerReturnPlayerNameWhenPlayerNameIsValid(string Name, string ExpectedResult)
        {
            var result = new Player(Name);
            Assert.That(result.Name, Is.EqualTo(ExpectedResult));
        }

        [TestCase("")]
        [TestCase(null)]
        [Test]
        public void AddPlayerReturnErrorWhenPlayerNameNotValid(string Name)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Player(Name));
            Assert.That(exception.Message, Is.EqualTo(string.Format("Player name is not valid.")));
        }
    }
}