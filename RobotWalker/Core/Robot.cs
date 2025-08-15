using RobotWalker.Core;
using System;

namespace RobotWalker
{
    public class Robot
    {
        public Position Position { get; private set; }
        private readonly Room _room;

        public Robot(Room room, Position start = null)
        {
            _room = room;
            Position = start ?? new Position(0, 0, Direction.N);
        }

        public void TurnLeft() => Position.Direction = Position.Direction switch
        {
            Direction.N => Direction.W,
            Direction.W => Direction.S,
            Direction.S => Direction.E,
            Direction.E => Direction.N,
            _ => throw new InvalidOperationException()
        };

        public void TurnRight() => Position.Direction = Position.Direction switch
        {
            Direction.N => Direction.E,
            Direction.E => Direction.S,
            Direction.S => Direction.W,
            Direction.W => Direction.N,
            _ => throw new InvalidOperationException()
        };

        public void MoveForward()
        {
            var newPos = Position.NextPosition();
            if (!_room.IsInside(newPos))
                throw new InvalidOperationException("Robot tried to move out of bounds!");
            Position = newPos;
        }

        public override string ToString()
        {
            return $"{Position.X} {Position.Y} {Position.Direction}";

        }
    }
}
