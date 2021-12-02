using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingAlley
{
    public class Frame
    {
        public int roll1;
        public int roll2;


        public Frame()
        {
            roll1 = 0;
            roll2 = 0;
        }




        public bool IsSpare()
        {
            return true;
        }

        public bool IsStrike()
        {
            return true;
        }
    }
}
