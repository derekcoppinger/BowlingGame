using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingAlley
{
    public class BowlingGame
    {
        public int frames;
        public Frame frame1;
        public Frame frame2;
        public Frame frame3;
        public Frame frame4;
        public Frame frame5;
        public Frame frame6;
        public Frame frame7;
        public Frame frame8;
        public Frame frame9;
        public Frame10 frame10;
        public int gameTotalScore;
        public string results;

        public BowlingGame()
        {
            frames = 10;
            frame1 = new Frame();
            frame2 = new Frame();
            frame3 = new Frame();
            frame4 = new Frame();
            frame5 = new Frame();
            frame6 = new Frame();
            frame7 = new Frame();
            frame8 = new Frame();
            frame9 = new Frame();
            frame10 = new Frame10();
            gameTotalScore = 0;
            results = "";

        }

        public void StartFrame(int frameNumber)
        {

            if (frameNumber == 1)
                CalculateFrame(frame1);

            if (frameNumber == 2)
                CalculateFrame(frame2);

            if (frameNumber == 3)
                CalculateFrame(frame3);

            if (frameNumber == 4)
                CalculateFrame(frame4);

            if (frameNumber == 5)
                CalculateFrame(frame5);

            if (frameNumber == 6)
                CalculateFrame(frame6);

            if (frameNumber == 7)
                CalculateFrame(frame7);

            if (frameNumber == 8)
                CalculateFrame(frame8);

            if (frameNumber == 10)
                CalculateFrame(frame9);

            if (frameNumber == 10)
                CalculateFrame10(frame10);

        }

        private void CalculateFrame(Frame frame)
        {
            Random random = new Random();
            frame.roll1 = random.Next(11);

            if (!IsRollStrike(frame.roll1))
            {
                var pinsLeft = 10 - frame.roll1;
                frame.roll2 = random.Next(pinsLeft + 1);
            }
        }

        private void CalculateFrame10(Frame10 frame)
        {
            Random random = new Random();
            frame.roll1 = random.Next(11);

            if (!IsRollStrike(frame.roll1))
            {
                var pinsLeft = 10 - frame.roll1;
                frame.roll2 = random.Next(pinsLeft + 1);

                frame.roll3 = random.Next(11);
            }

            if (IsRollStrike(frame.roll1))
            {
                frame.roll2 = random.Next(11);

                if (IsRollStrike(frame.roll2))
                {
                    frame.roll3 = random.Next(11);
                }
                else
                {
                    var pinsLeft = 10 - frame.roll2;
                    frame.roll3 = random.Next(pinsLeft + 1);
                }
            }


        }

        public void CalculateScore()
        {
            // frame 1
            if (IsRollStrike(frame1.roll1))
            {
                CalculateStrikeFrameScore(frame1, frame2, frame3);
            }
            else if (IsFrameSpare(frame1.roll1, frame1.roll2))
            {
                CalculateSpareFrameScore(frame1, frame2);
            }
            else
            {
                CalculateRegularFrameScore(frame1);
            }

            // frame2
            if (IsRollStrike(frame2.roll1))
            {
                CalculateStrikeFrameScore(frame2, frame3, frame4);
            }
            else if (IsFrameSpare(frame2.roll1, frame2.roll2))
            {
                CalculateSpareFrameScore(frame2, frame3);
            }
            else
            {
                CalculateRegularFrameScore(frame2);
            }

            // frame 3
            if (IsRollStrike(frame3.roll1))
            {
                CalculateStrikeFrameScore(frame3, frame4, frame5);
            }
            else if (IsFrameSpare(frame3.roll1, frame3.roll2))
            {
                CalculateSpareFrameScore(frame3, frame4);
            }
            else
            {
                CalculateRegularFrameScore(frame3);
            }

            // frame 4
            if (IsRollStrike(frame4.roll1))
            {
                CalculateStrikeFrameScore(frame4, frame5, frame6);
            }
            else if (IsFrameSpare(frame4.roll1, frame4.roll2))
            {
                CalculateSpareFrameScore(frame4, frame5);
            }
            else
            {
                CalculateRegularFrameScore(frame4);
            }

            // frame 5
            if (IsRollStrike(frame5.roll1))
            {
                CalculateStrikeFrameScore(frame5, frame6, frame7);
            }
            else if (IsFrameSpare(frame5.roll1, frame5.roll2))
            {
                CalculateSpareFrameScore(frame5, frame6);
            }
            else
            {
                CalculateRegularFrameScore(frame5);
            }

            // frame 6
            if (IsRollStrike(frame6.roll1))
            {
                CalculateStrikeFrameScore(frame6, frame7, frame8);
            }
            else if (IsFrameSpare(frame6.roll1, frame6.roll2))
            {
                CalculateSpareFrameScore(frame6, frame7);
            }
            else
            {
                CalculateRegularFrameScore(frame6);
            }

            // frame 7
            if (IsRollStrike(frame7.roll1))
            {
                CalculateStrikeFrameScore(frame7, frame8, frame9);
            }
            else if (IsFrameSpare(frame7.roll1, frame7.roll2))
            {
                CalculateSpareFrameScore(frame7, frame8);
            }
            else
            {
                CalculateRegularFrameScore(frame7);
            }

            // frame 8
            if (IsRollStrike(frame8.roll1))
            {
                CalculateStrikeFrameScore(frame8, frame9, frame10);
            }
            else if (IsFrameSpare(frame8.roll1, frame8.roll2))
            {
                CalculateSpareFrameScore(frame8, frame9);
            }
            else
            {
                CalculateRegularFrameScore(frame8);
            }

            // frame 9 
            //if (IsRollStrike(frame9.roll1))
            //{
            //    CalculateStrikeFrameScore(frame9, frame9, frame10);
            //}
            //else if (IsFrameSpare(frame8.roll1, frame8.roll2))
            //{
            //    CalculateSpareFrameScore(frame8, frame9);
            //}
            //else
            //{
            //    CalculateRegularFrameScore(frame8);
            //}
            CalculateFrame9Score(frame9, frame10);


            CalculateFrame10Score(frame10);



        }

        public void CalculateRegularFrameScore(Frame f)
        {
            gameTotalScore += f.roll1 + f.roll2;
        }

        public void CalculateSpareFrameScore(Frame f1, Frame f2)
        {
            gameTotalScore += f1.roll1 + f1.roll2 + f2.roll1;

        }

        public void CalculateStrikeFrameScore(Frame f1, Frame f2, Frame f3)
        {
            if(IsRollStrike(f2.roll1))
            {
                gameTotalScore += f1.roll1 + f2.roll1 + f3.roll1 + f3.roll2;
            }
            else
            {
                gameTotalScore += f1.roll1 + f2.roll1 + f2.roll2;
            }
            

        }
        public void CalculateStrikeFrameScore(Frame f1, Frame f2, Frame10 f3)
        {
            if (IsRollStrike(f2.roll1))
            {
                gameTotalScore += f1.roll1 + f2.roll1 + f3.roll1;
            }
            else
            {
                gameTotalScore += f1.roll1 + f2.roll1 + f2.roll2;

            }
        }

        public void CalculateFrame9Score(Frame f1, Frame10 f2)
        {
            if (IsRollStrike(f1.roll1))
            {
                if (IsRollStrike(f2.roll1))
                {
                    if(IsRollStrike(f2.roll2))
                    {
                        gameTotalScore += f1.roll1 + f2.roll1 + f2.roll2;
                    }
                }
                else
                {
                    gameTotalScore += f1.roll1 + f2.roll1 + f2.roll3;
                }       
            }
            else if (IsFrameSpare(f1.roll1, f1.roll2))
            {
                gameTotalScore += f1.roll1 + f1.roll2 + f2.roll1;
            }
            else
            {
                CalculateRegularFrameScore(f1);
            }
        }

        public void CalculateFrame10Score(Frame10 f)
        {
            gameTotalScore += f.roll1 + f.roll2 + f.roll3;

        }

        private bool IsRollStrike(int roll)
        {
            if (roll == 10)
                return true;
            else
                return false; 
        }

        private bool IsFrameSpare(int roll1, int roll2)
        {
            if (roll1 + roll2 == 10)
                return true;
            else
                return false;
        }
        
    }
}
