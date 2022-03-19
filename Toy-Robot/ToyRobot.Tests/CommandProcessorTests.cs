using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot.Library.Entities;
using ToyRobot.Library.Interfaces;

namespace ToyRobot.Tests
{
    [TestClass]
    public class CommandProcessorTests
    {
        [TestMethod]
        public void Execute_ValidCommand_ReturnsTrue()
        {
            //Arrange
            Table table = new Table(5, 5);
            ICommandProcessor processor = new CommandProcessor(table);

            //Act
            bool result = processor.Execute("PLACE 0,0,NORTH");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Execute_InvalidCommand_ReturnsFalse()
        {
            //Arrange
            Table table = new Table(5, 5);
            ICommandProcessor processor = new CommandProcessor(table);

            //Act
            bool result = processor.Execute("JUMP");

            //Assert
            Assert.IsFalse(result);
        }

        
    }
}
