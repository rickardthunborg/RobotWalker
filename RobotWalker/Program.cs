using RobotWalker;
using RobotWalker.Commands;
using RobotWalker.Controllers;
using RobotWalker.Core;


Console.WriteLine("Room width: ");
int roomWidth = Int32.Parse(Console.ReadLine());
Console.WriteLine("Room height: ");
int roomHeight = Int32.Parse(Console.ReadLine());
Room room = new Room(roomWidth, roomHeight);

var commandMap = new Dictionary<char, IRobotCommand>
{
    { 'F', new MoveForwardCommand() },
    { 'L', new TurnLeftCommand() },
    { 'R', new TurnRightCommand() }
};

var robot = new Robot(room);
var robotController = new RobotController(robot, commandMap);

while (true)
{
    Console.WriteLine("Enter commands (L, R, F) or 'exit' to quit:");
    robotController.ExecuteCommands(Console.ReadLine());
    Console.WriteLine("Report: " + robot.ToString());
}

