using Xunit;
using RobotWalker;

namespace RobotWalkerTests
{
    public class RobotTests
    {
        [Fact]
        public void Robot_InitialPositionAndDirection_IsSetCorrectly()
        {
            var robot = new Robot(1, 2, Direction.N, 5, 5);

            Assert.Equal(1, robot.Position.X);
            Assert.Equal(2, robot.Position.Y);
            Assert.Equal("1 2 N", robot.ToString());
        }
        [Fact]
        public void Robot_TurnLeft_UpdatesDirectionCorrectly()
        {
            var robot = new Robot(0, 0, Direction.N, 5, 5);
            robot.TurnLeft();

            Assert.Equal("0 0 W", robot.ToString());
        }

        [Fact]
        public void Robot_TurnRight_UpdatesDirectionCorrectly()
        {
            var robot = new Robot(0, 0, Direction.N, 5, 5);
            robot.TurnRight();

            Assert.Equal("0 0 E", robot.ToString());
        }

        [Fact]
        public void Robot_MoveForward_UpdatesPositionCorrectly()
        {
            var robot = new Robot(1, 1, Direction.S, 5, 5);
            robot.MoveForward();

            Assert.Equal("1 2 S", robot.ToString());
        }

        [Fact]
        public void Robot_MoveForward_OutOfBounds_ThrowsException()
        {
            var robot = new Robot(0, 0, Direction.N, 5, 5);

            var ex = Assert.Throws<InvalidOperationException>(() => robot.MoveForward());

            Assert.Equal("Robot moved out of bounds.", ex.Message);
        }

        [Fact]
        public void Robot_ProcessCommands_Sequence_WorksCorrectly()
        {
            var robot = new Robot(1, 2, Direction.N, 5, 5);
            robot.ProcessCommands("RFRFFRFRF");

            Assert.Equal("1 3 N", robot.ToString());
        }
    }
}