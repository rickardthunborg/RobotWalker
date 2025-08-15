using RobotWalker.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWalker.Controllers
{
    public class RobotController
    {
        private readonly Robot _robot;
        private readonly Dictionary<char, IRobotCommand> _commandMap;

        public RobotController(Robot robot, Dictionary<char, IRobotCommand> commandMap)
        {
            _robot = robot ?? throw new ArgumentNullException(nameof(robot));
            _commandMap = commandMap ?? throw new ArgumentNullException(nameof(commandMap));
        }
        public void ExecuteCommands(string commands)
        {
            foreach (var c in commands)
            {
                if (!_commandMap.TryGetValue(c, out var command))
                    throw new ArgumentException($"Invalid command '{c}'");
                command.Execute(_robot);
            }
        }
    }
}
