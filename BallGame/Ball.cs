using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGame
{
    public class Ball : Color
    {
        public Ball(int s, byte r, byte g, byte b, byte a) : base(r, g, b, a)
        {
            ballSize = s;
            timesThrown = 0;
        }

        public void PopMethod()
        {
            ballSize = 0;
        }

        public void ThrowMethod()
        {
            if (ballSize > 0)
            {
                timesThrown++;
            }
        }

        public int ballSize;
        public int timesThrown { get; set; }
    }
}