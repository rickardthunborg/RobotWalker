using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWalker
{

    public enum Direction { N, E, S, W }
    public class Robot
    {
        private static readonly Direction[] directions = { Direction.N, Direction.E, Direction.S, Direction.W };
        private static readonly Dictionary<Direction, (int dx, int dy)> movementMap = new()
        {
            { Direction.N, (0, -1) },
            { Direction.E,  (1, 0) },
            { Direction.S, (0, 1) },
            { Direction.W,  (-1, 0) }
        };

        public Position Position { get; private set; }
        private int directionIndex;
        private readonly Room room;

        public Robot(int x, int y, Direction direction, int roomWidth, int roomHeight)
        {
            Position = new Position(x, y);
            directionIndex = (int)direction;
            this.room = new Room(roomWidth, roomHeight);
        }

        public void TurnLeft() => directionIndex = (directionIndex + 3) % 4;
        public void TurnRight() => directionIndex = (directionIndex + 1) % 4;

        public void MoveForward()
        {
            var (dx, dy) = movementMap[directions[directionIndex]];
            Position.Move(dx, dy);

            if (!room.IsInside(Position))
            {
                throw new InvalidOperationException("Robot moved out of bounds.");
            }
        }

        public void ProcessCommands(string commands)
        {
            if(commands == "exit".ToLower())
            foreach (char command in commands)
            {
                switch (command)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'F':
                        MoveForward();
                        break;
                    default:
                        throw new ArgumentException($"Invalid command: {command}");
                }
            }
        }

        public override string ToString()
        {
            return $"{Position.X} {Position.Y} {directions[directionIndex]}";

        }
    }
}
