using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGame
{
    public class Color
    {
        public Color(byte R, byte G, byte B, byte A)
        {
            Red = R;
            Green = G;
            Blue = B;
            Alpha = A;
        }
        public Color(byte R, byte G, byte B)
        {
            Red = R;
            Green = G;
            Blue = B;
            Alpha = 255;
        }

        public byte GetGrayScale(Color c)
        {
            return (byte)((c.Red + c.Blue + c.Green) / 3);
        }

        public byte Red { get; set; }
        public byte Blue { get; set; }
        public byte Green { get; set; }
        public byte Alpha { get; set; }
    }
}