using System;
using System.Drawing;


namespace Snake
{
    public class Food
    {
        public Point Position { get; private set; }

        public Food(int width, int height)
        {
            Generate(width, height); 
        }

        public void Generate(int width, int height)
        {
            Random rand = new Random();
            Position = new Point(rand.Next(0, width), rand.Next(0, height));
        }
    }
}
