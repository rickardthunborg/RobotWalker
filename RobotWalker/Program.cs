using RobotWalker;


Console.WriteLine("Room width: ");
int roomWidth = Int32.Parse(Console.ReadLine());
Console.WriteLine("Room height: ");
int roomHeight = Int32.Parse(Console.ReadLine());


var robot = new Robot(1, 2, Direction.N, roomWidth, roomHeight);

while (true)
{
    Console.WriteLine("Enter commands (L, R, F) or 'exit' to quit:");
    robot.ProcessCommands(Console.ReadLine());
    Console.WriteLine("Report: " + robot.ToString());
}

