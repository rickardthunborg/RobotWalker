using System;

public class Position
{
	public int X { get; set; }
	public int Y { get; set; }

    public Position(int x, int y)
	{
		X = x;
		Y = y;
	}

	public void Move(int dx, int dy)
    {
        X += dx;
        Y += dy;
    }

	public bool IsOutOfBounds(int width, int height)
	{
		return X < 0 || X >= width || Y < 0 || Y >= height;
    }

	public override string ToString() => $"({X}, {Y})";
}
