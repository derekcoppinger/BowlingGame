using System;

namespace BowlingAlley
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to \"The Alley\"!");

            // start game

            //BowlingGame game = new BowlingGame();

            //for (int i = 1; i < game.frames; i++)
            //{
            //    game.StartFrame(i);
            //}

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

            game.CalculateScore();
            Console.WriteLine(game.frame1.roll1 + " " + game.frame1.roll2);
            Console.WriteLine(game.frame2.roll1 + " " + game.frame2.roll2);
            Console.WriteLine(game.frame3.roll1 + " " + game.frame3.roll2);
            Console.WriteLine(game.frame4.roll1 + " " + game.frame4.roll2);
            Console.WriteLine(game.frame5.roll1 + " " + game.frame5.roll2);
            Console.WriteLine(game.frame6.roll1 + " " + game.frame6.roll2);
            Console.WriteLine(game.frame7.roll1 + " " + game.frame7.roll2);
            Console.WriteLine(game.frame8.roll1 + " " + game.frame8.roll2);
            Console.WriteLine(game.frame9.roll1 + " " + game.frame9.roll2);
            Console.WriteLine(game.frame10.roll1 + " " + game.frame10.roll2 + " " + game.frame10.roll3);
            Console.WriteLine("Total Score: " + game.gameTotalScore);




            // start frame 
            // roll 1 
            // roll 2 
            // go to next frame 
            // roll 1 
            // roll 2
            // 

        }

    }
}
