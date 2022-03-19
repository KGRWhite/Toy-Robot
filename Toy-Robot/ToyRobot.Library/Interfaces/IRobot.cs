using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToyRobot.Library.Interfaces
{
    
    public interface IRobot //note: NOT the 2004 hit movie starring Will Smith!
    {

        /// <summary>
        /// Places the robot at the specified X Y Location and direction
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="direction"></param>
        /// <returns>boolean value confirming if the placement was successful</returns>
        bool Place(int x, int y, string direction);

        /// <summary>
        /// Places the robot at the specified X Y Location.
        /// Requires to be already placed
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>boolean value confirming if the placement was successful</returns>
        bool Place(int x, int y);

        /// <summary>
        /// Moves the robot 1 space depending on the direction it is facing.
        /// </summary>
        /// <returns>boolean value confirming if the robot can move or not</returns>
        bool Move();

        /// <summary>
        /// Checks the local _isPlaced boolean value to see if the robot has already been placed
        /// </summary>
        /// <returns>boolean value confirming placement</returns>
        bool IsPlaced();

        /// <summary>
        /// Rotates the robot either 'LEFT' or 'RIGHT'
        /// </summary>
        /// <param name="direction"></param>
        /// <returns>boolean value confirming rotation</returns>
        bool Rotate(string direction);

        /// <summary>
        /// Causes the robot to print out its current location and direction.
        /// </summary>
        /// <returns></returns>
        void Report();
    }
}
