    using System;

    namespace BallGame
    {
        public class Program
        {
            public static void Main()
            {
                Ball firstBall = new Ball(2, 35, 45, 55, 65);
                Console.WriteLine("Size ball1: " + firstBall.ballSize.ToString());
                Console.WriteLine("R: " + firstBall.Red.ToString());
                Console.WriteLine("G: " + firstBall.Green.ToString());
                Console.WriteLine("B: " + firstBall.Blue.ToString());
                Console.WriteLine("A: " + firstBall.Alpha.ToString());
                Console.WriteLine("Thrown " + firstBall.timesThrown.ToString() + " times");
                Ball secondBall = new Ball(1, 55, 68, 112, 255);
                Console.WriteLine("Size ball2: " + secondBall.ballSize.ToString());
                Console.WriteLine("R: " + secondBall.Red.ToString());
                Console.WriteLine("G: " + secondBall.Green.ToString());
                Console.WriteLine("B: " + secondBall.Blue.ToString());
                Console.WriteLine("A: " + secondBall.Alpha.ToString());
                Console.WriteLine("Thrown " + firstBall.timesThrown.ToString() + " times");
                Ball thirdBall = new Ball(3, 157, 223, 98, 0);
                Console.WriteLine("Size ball3: " + thirdBall.ballSize.ToString());
                Console.WriteLine("R: " + thirdBall.Red.ToString());
                Console.WriteLine("G: " + thirdBall.Green.ToString());
                Console.WriteLine("B: " + thirdBall.Blue.ToString());
                Console.WriteLine("A: " + thirdBall.Alpha.ToString());
                Console.WriteLine("Thrown " + firstBall.timesThrown.ToString() + " times");
                firstBall.ThrowMethod();
                secondBall.ThrowMethod();
                secondBall.ThrowMethod();
                secondBall.ThrowMethod();
                thirdBall.ThrowMethod();
                thirdBall.ThrowMethod();
                thirdBall.ThrowMethod();
                thirdBall.ThrowMethod();
                thirdBall.ThrowMethod();
                Console.WriteLine("ball1 thrown once, ball2 thrown 3 times, and ball 3 thrown 5 times, now to check the timesthrown");
                Console.WriteLine("Number of times the First Ball has been thrown: " + firstBall.timesThrown.ToString());
                Console.WriteLine("Number of times the Second Ball has been thrown: " + secondBall.timesThrown.ToString());
                Console.WriteLine("Number of times the Third Ball has been thrown: " + thirdBall.timesThrown.ToString());
                Console.WriteLine("ball1 popped,ball2 popped, balls thrown again");
                firstBall.PopMethod();
                secondBall.PopMethod();
                firstBall.ThrowMethod();
                Console.WriteLine("First ball thrown: " + firstBall.timesThrown.ToString() + " even after thrown when popped.");
            }
        }
    }