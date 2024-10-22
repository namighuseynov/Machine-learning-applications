using System.Collections.Generic;
using System.Drawing;


namespace Snake
{
    public class SnakeObject
    {
        public List<Point> Body { get; private set; }
        public Direction CurrentDirection { get; set; }

        public SnakeObject()
        {
            Body = new List<Point>
            {
                new Point(10, 10),
                new Point(9, 10),
                new Point(8, 10)
            };
            CurrentDirection = Direction.Right;
        }

        public void Move()
        {
            for (int i = Body.Count - 1; i > 0; i--)
            {
                Body[i] = Body[i - 1];
            }

            switch (CurrentDirection)
            {
                case Direction.Up:
                    Body[0] = new Point(Body[0].X, Body[0].Y - 1);
                    break;
                case Direction.Down:
                    Body[0] = new Point(Body[0].X, Body[0].Y + 1);
                    break;
                case Direction.Left:
                    Body[0] = new Point(Body[0].X - 1, Body[0].Y);
                    break;
                case Direction.Right:
                    Body[0] = new Point(Body[0].X + 1, Body[0].Y);
                    break;
            }
        }

        public void Grow()
        {
            Body.Add(Body[Body.Count - 1]);
        }
    }
}
