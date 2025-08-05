using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWalker
{
    public class Room
    {
        public int Width { get; }
        public int Height { get; }

        public Room(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool IsInside(Position pos)
        {
            return pos.X >= 0 && pos.X < Width &&
                   pos.Y >= 0 && pos.Y < Height;
        }
    }
}
