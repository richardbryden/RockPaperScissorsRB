using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsRB.Model;
using System;

namespace RockPaperScissorsTest
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestGame(){

            Game newGame = new Game();
            Score score = newGame.RunGame("false", "Rock", 1, 2, 3);

            IChoice expectedP1Input = new Rock();
            

            int expectedP1Score = new int();
            int expectedP2Score = new int();
            int expectedTieScore = new int();
            expectedP1Score = 1;
            expectedP2Score = 2;
            expectedTieScore = 3;


            if (score.p2Input == "Rock")
            {
                expectedTieScore = 4;
            }
            if (score.p2Input == "Paper")
            {
                expectedP2Score = 3;
            }
            if (score.p2Input == "Scissors")
            {
                expectedP1Score = 2;
            }


            Assert.AreEqual(score.p1Input, expectedP1Input.Choice);
            Assert.AreEqual(score.p1Score, expectedP1Score);
            Assert.AreEqual(score.p2Score, expectedP2Score);
            Assert.AreEqual(score.tieScore, expectedTieScore);
        }

        [TestMethod]
        public void TestGameInvalid()
        {
            Game newGame = new Game();
            Score score = newGame.RunGame("false", "", 1, 2, 3);

            Assert.AreEqual(score.p1Input,"ERROR");
            
        }        
    }
}
