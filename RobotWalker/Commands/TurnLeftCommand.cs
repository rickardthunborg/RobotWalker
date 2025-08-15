using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWalker.Commands
{
    public class TurnLeftCommand : IRobotCommand
    {
        public void Execute(Robot robot) => robot.TurnLeft();
    }
}