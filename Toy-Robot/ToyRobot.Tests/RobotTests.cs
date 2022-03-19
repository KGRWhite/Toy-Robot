using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToyRobot.Library.Entities;
using ToyRobot.Library.Interfaces;

namespace ToyRobot.Tests
{
    [TestClass]
    public class RobotTests
    {
        [TestMethod]
        public void Place_ValidLocation_ReturnsTrue()
        {
            //Arrange
            Table table = new Table(5, 5);
            IRobot robot = new Robot(table);
            //Act
           bool result = robot.Place(3, 3, "NORTH");
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Place_InvalidLocation_ReturnsFalse()
        {
            //Arrange
            Table table = new Table(5, 5);
            IRobot robot = new Robot(table);
            //Act
            bool result = robot.Place(3, 9, "WEST");
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Place_HasPreviouslyBeenPlaced_ReturnsTrue()
        {
            //Arrange
            Table table = new Table(5, 5);
            IRobot robot = new Robot(table);
            robot.Place(2, 2, "EAST");
            //Act
            bool result = robot.IsPlaced();
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Place_HasNotBeenPlaced_NoDirection_ReturnsFalse()
        {
            //Arrange
            Table table = new Table(5, 5);
            IRobot robot = new Robot(table);
            //Act
            bool result = robot.Place(3, 3);
            //Assert
            Assert.IsFalse(result); 

        }

        [TestMethod]
        public void Move_NewPositionOnTable_ReturnsTrue()
        {
            //Arrange
            Table table = new Table(5, 5);
            IRobot robot = new Robot(table);
            robot.Place(2, 2, "NORTH");
            //Act
            bool result = robot.Move();
            //Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void Move_NewPositionNotOnTable_ReturnsFalse()
        {
            //Arrange
            Table table = new Table(5, 5);
            IRobot robot = new Robot(table);
            robot.Place(5, 5, "NORTH");
            //Act
            bool result = robot.Move();
            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Rotate_ValidRotationString_ReturnsTrue()
        {
            //Arrange
            Table table = new Table(5, 5);
            IRobot robot = new Robot(table);
            robot.Place(2, 2, "EAST");
            //Act
            bool result = robot.Rotate("LEFT");
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Rotate_InvalidRotationString_ReturnsFalse()
        {
            //Arrange
            Table table = new Table(5, 5);
            IRobot robot = new Robot(table);
            robot.Place(2, 2, "WEST");
            //Act
            bool result = robot.Rotate("LEFTISH");
            //Assert
            Assert.IsFalse(result);
        }

        
    }
}