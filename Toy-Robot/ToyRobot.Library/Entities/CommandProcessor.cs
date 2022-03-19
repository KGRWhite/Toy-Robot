using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot.Library.Interfaces;

namespace ToyRobot.Library.Entities
{
    public class CommandProcessor : ICommandProcessor
    {

        private IRobot _robot;
        private Table _table;

        public CommandProcessor(Table table)
        {
            _table = table;
            _robot = new Robot(table);
        }

        /// <inheritdoc/>
        public bool Execute(string command)
        {
            
            //The place command requires breaking down additional parameters which is why its excluded from the switch statement.
            if (command.Contains("PLACE"))
            {
                
                    string[] parameterArray = command.Substring(5).Split(',');

                    if(int.Parse(parameterArray[0]) > _table.Height)
                    {
                        Console.WriteLine("Cannot place robot here as its off the table.");
                        return false;
                    }
                    else if (int.Parse(parameterArray[1]) > _table.Width)
                    {
                        Console.WriteLine("Cannot place robot here as its off the table.");
                        return false;
                    }

                    if (_robot.IsPlaced())
                    {
                        _robot.Place(
                            int.Parse(parameterArray[0]),
                            int.Parse(parameterArray[1])
                            );
                    }
                    else
                    {
                        _robot.Place(
                            int.Parse(parameterArray[0]),
                            int.Parse(parameterArray[1]),
                            parameterArray[2]
                            );
                    }
              
                return true;

            }
            else
            {
                if(!_robot.IsPlaced())
                {
                    Console.WriteLine("Unable to process command, The robot needs to be placed first...");
                    return false;
                }

                switch (command)
                {
                    case "MOVE":
                        _robot.Move();
                        return true;

                    case "REPORT":
                        _robot.Report();
                        return true;

                    case "LEFT":
                        _robot.Rotate(command);
                        return true;

                    case "RIGHT":
                        _robot.Rotate(command);
                        return true; 

                    default:
                        return false;
                }
            }    

            

           
        }
    }
}
