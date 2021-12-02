using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingAlley;

namespace BowlingAlleyTest
{
    [TestClass]
    public class CalculateGameTotalTests
    {
        [TestMethod]
        public void TestControlBowlingGameTotalScore()
        {
            // Arrange
            BowlingGame game = new BowlingGame();

            game.frame1.roll1 = 4;
            game.frame1.roll2 = 3;

            game.frame2.roll1 = 7;
            game.frame2.roll2 = 3;

            game.frame3.roll1 = 5;
            game.frame3.roll2 = 2;

            game.frame4.roll1 = 8;
            game.frame4.roll2 = 1;

            game.frame5.roll1 = 4;
            game.frame5.roll2 = 6;

            game.frame6.roll1 = 2;
            game.frame6.roll2 = 4;

            game.frame7.roll1 = 8;
            game.frame7.roll2 = 0;

            game.frame8.roll1 = 8;
            game.frame8.roll2 = 0;

            game.frame9.roll1 = 8;
            game.frame9.roll2 = 2;

            game.frame10.roll1 = 10;
            game.frame10.roll2 = 1;
            game.frame10.roll3 = 7;

            int expectedGameTotal = 110;

            // Act
            game.CalculateScore();

            // Assert
            int actualGameTotal = game.gameTotalScore;
            Assert.AreEqual(expectedGameTotal, actualGameTotal, .0000, "The game total is not correct.");


        }

        [TestMethod]
        public void TestPerfectBowlingGameTotalScore()
        {
            // Arrange
            BowlingGame game = new BowlingGame();

            game.frame1.roll1 = 10;
            game.frame1.roll2 = 0;

            game.frame2.roll1 = 10;
            game.frame2.roll2 = 0;

            game.frame3.roll1 = 10;
            game.frame3.roll2 = 0;

            game.frame4.roll1 = 10;
            game.frame4.roll2 = 0;

            game.frame5.roll1 = 10;
            game.frame5.roll2 = 0;

            game.frame6.roll1 = 10;
            game.frame6.roll2 = 0;

            game.frame7.roll1 = 10;
            game.frame7.roll2 = 0;

            game.frame8.roll1 = 10;
            game.frame8.roll2 = 0;

            game.frame9.roll1 = 10;
            game.frame9.roll2 = 0;

            game.frame10.roll1 = 10;
            game.frame10.roll2 = 10;
            game.frame10.roll3 = 10;

            int expectedGameTotal = 300;

            // Act
            game.CalculateScore();

            // Assert
            int actualGameTotal = game.gameTotalScore;
            Assert.AreEqual(expectedGameTotal, actualGameTotal, .0000, "The game total is not correct.");


        }

        [TestMethod]
        public void TestNonScoringBowlingGameTotalScore()
        {
            // Arrange
            BowlingGame game = new BowlingGame();

            game.frame1.roll1 = 0;
            game.frame1.roll2 = 0;

            game.frame2.roll1 = 0;
            game.frame2.roll2 = 0;

            game.frame3.roll1 = 0;
            game.frame3.roll2 = 0;

            game.frame4.roll1 = 0;
            game.frame4.roll2 = 0;

            game.frame5.roll1 = 0;
            game.frame5.roll2 = 0;

            game.frame6.roll1 = 0;
            game.frame6.roll2 = 0;

            game.frame7.roll1 = 0;
            game.frame7.roll2 = 0;

            game.frame8.roll1 = 0;
            game.frame8.roll2 = 0;

            game.frame9.roll1 = 0;
            game.frame9.roll2 = 0;

            game.frame10.roll1 = 0;
            game.frame10.roll2 = 0;
            game.frame10.roll3 = 0;

            int expectedGameTotal = 0;

            // Act
            game.CalculateScore();

            // Assert
            int actualGameTotal = game.gameTotalScore;
            Assert.AreEqual(expectedGameTotal, actualGameTotal, .0000, "The game total is not correct.");


        }
    }
}
