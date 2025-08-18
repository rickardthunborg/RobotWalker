using Xunit;
using RobotWalker;
using RobotWalker.Core;

namespace RobotWalkerTests
{
    public class RobotTests
    {
        private Room CreateRoom(int width = 5, int height = 5) => new Room(width, height);

        [Fact]
        public void Robot_InitialPosition_DefaultsTo_0_0_N()
        {
            var room = CreateRoom();
            var robot = new Robot(room);

            Assert.Equal(0, robot.Position.X);
            Assert.Equal(0, robot.Position.Y);
            Assert.Equal(Direction.N, robot.Position.Direction);
            Assert.Equal("0 0 N", robot.ToString());
        }

        [Fact]
        public void Robot_InitialPosition_CustomStart_IsSetCorrectly()
        {
            var room = CreateRoom();
            var start = new Position(2, 3, Direction.E);
            var robot = new Robot(room, start);

            Assert.Equal(2, robot.Position.X);
            Assert.Equal(3, robot.Position.Y);
            Assert.Equal(Direction.E, robot.Position.Direction);
            Assert.Equal("2 3 E", robot.ToString());
        }

        [Fact]
        public void Robot_TurnLeft_UpdatesDirectionCorrectly()
        {
            var room = CreateRoom();
            var robot = new Robot(room, new Position(0, 0, Direction.N));
            robot.TurnLeft();

            Assert.Equal(Direction.W, robot.Position.Direction);
            Assert.Equal("0 0 W", robot.ToString());
        }

        [Fact]
        public void Robot_TurnRight_UpdatesDirectionCorrectly()
        {
            var room = CreateRoom();
            var robot = new Robot(room, new Position(0, 0, Direction.N));
            robot.TurnRight();

            Assert.Equal(Direction.E, robot.Position.Direction);
            Assert.Equal("0 0 E", robot.ToString());
        }

        [Fact]
        public void Robot_MoveForward_UpdatesPositionCorrectly()
        {
            var room = CreateRoom();
            var robot = new Robot(room, new Position(1, 1, Direction.S));
            robot.MoveForward();

            Assert.Equal(1, robot.Position.X);
            Assert.Equal(0, robot.Position.Y);
            Assert.Equal(Direction.S, robot.Position.Direction);
            Assert.Equal("1 0 S", robot.ToString());
        }

        [Fact]
        public void Robot_MoveForward_OutOfBounds_ThrowsException()
        {
            var room = CreateRoom();
            var robot = new Robot(room, new Position(0, 0, Direction.S));

            var ex = Assert.Throws<InvalidOperationException>(() => robot.MoveForward());
            Assert.Equal("Robot tried to move out of bounds!", ex.Message);
        }
    }
}