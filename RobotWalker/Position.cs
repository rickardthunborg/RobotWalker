using RobotWalker;
using System;


public enum Direction { N, E, S, W }
public class Position
{
	public int X { get; set; }
	public int Y { get; set; }
    public Direction Direction { get; set; }


    public Position(int x = 1, int y = 1, Direction facing = Direction.N)
    {
        X = x;
        Y = y;
        Direction = facing;
    }
    public Position NextPosition()
    {
        return Direction switch
        {
            Direction.N => new Position(X, Y + 1, Direction),
            Direction.S => new Position(X, Y - 1, Direction),
            Direction.E => new Position(X + 1, Y, Direction),
            Direction.W => new Position(X - 1, Y, Direction),
            _ => throw new InvalidOperationException("Invalid direction")
        };
    }
}
