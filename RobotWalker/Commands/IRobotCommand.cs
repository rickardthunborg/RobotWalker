using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWalker.Commands
{
    public interface IRobotCommand
    {
        void Execute(Robot robot);
    }
}
