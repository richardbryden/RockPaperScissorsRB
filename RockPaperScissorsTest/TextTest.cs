using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsRB.Model;

namespace RockPaperScissorsTest
{
    [TestClass]
    public class TextTest
    {
        [TestMethod]
        public void TestText(){
            IChoice testChoice = TextToChoice.GetTextChoice("Rock");
            IChoice test = new Rock();

            Assert.AreEqual(testChoice.Choice, test.Choice);
        }
        [TestMethod]
        public void TestTextInvalid()
        {
            IChoice testChoice = TextToChoice.GetTextChoice("");
            IChoice test = new Invalid();

            Assert.AreEqual(testChoice.Choice, test.Choice);
        }
        [TestMethod]
        public void TestTextNotEqual()
        {
            IChoice testChoice = TextToChoice.GetTextChoice("Paper");
            IChoice test = new Scissors();

            Assert.AreNotEqual(testChoice, test);
        }
    }
}
