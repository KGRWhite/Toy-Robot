using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot.Library.Interfaces;

namespace ToyRobot.Library.Entities
{
    public class Robot : IRobot
    {
        private int _xPosition;
        private int _yPosition;
        private string _direction = "";
        private Table _table;
        private bool isPlaced = false;

        public Robot(Table table)
        {
            _table = table;
        }

        /// <inheritdoc/>
        public bool Move()
        {
            switch (_direction)
            {
                case "NORTH":
                    if(CanMove(_direction))
                    {
                        _xPosition++;
                        return true;
                    }
                    else return false;
                case "EAST":
                    if (CanMove(_direction))
                    {
                        _yPosition++;
                        return true;
                    }
                    else return false;

                case "SOUTH":
                    if (CanMove(_direction))
                    {
                        _xPosition--;
                        return true;
                    }
                    else return false;
                    

                case "WEST":
                    if (CanMove(_direction))
                    {
                        _yPosition--;
                        return true;
                    }
                    else return false;



                default:
                    return false;
            }
            
        }

        /// <inheritdoc/>
        public bool Place(int x, int y, string direction)
        {
            if(x <= _table.Height && y <= _table.Width)
            {
                _xPosition = x;
                _yPosition = y;
                _direction = direction;
                isPlaced = true;
                Console.WriteLine("Robot has been placed");
                return true;
            }
            else
            {
                Console.WriteLine("Cannot Place, Position is off the table");
                return false;
            }
           
        }

        /// <inheritdoc/>
        public bool Place(int x, int y)
        {
            if(isPlaced)
            {
                if (x <= _table.Height && y <= _table.Width)
                {
                    _xPosition = x;
                    _yPosition = y;


                    Console.WriteLine("Robot has been placed to new position");
                    return true;
                }
                else
                {
                    Console.WriteLine("Cannot Place, Position is off the table");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Cannot place robot without a direction on first placing...");
                return false;
            }
           
        }

        /// <inheritdoc/>
        public void Report()
        {
            Console.WriteLine( $"Output: {_xPosition}, {_yPosition}, {_direction}");
        }

        /// <inheritdoc/>
        public bool Rotate(string rotation)
        {
            if (rotation == "LEFT" || rotation == "RIGHT")
            {
                ChangeDirection(rotation);
                return true;
            }
            else return false;
        }

        private void ChangeDirection(string rotation)
        {
            switch (_direction)
            {
                case "NORTH":
                    _direction = rotation == "LEFT" ? "WEST" : "EAST";
                    break;

                case "EAST":
                    _direction = rotation == "LEFT" ? "NORTH" : "SOUTH";
                    break;

                case "SOUTH":
                    _direction = rotation == "LEFT" ? "EAST" : "WEST";
                    break;
                case "WEST":
                    _direction = rotation == "LEFT" ? "SOUTH" : "NORTH";
                    break;

                default:
                    break;
            }
        }

        /// <inheritdoc/>
        public bool IsPlaced()
        {
            return isPlaced;
        }

        private bool CanMove(string direction)
        {
            int x = _xPosition;
            int y = _yPosition;

            if (direction == "NORTH")
            {
                x++;
                if (x > _table.Height)
                {
                    Console.WriteLine("Robot says: I Cannot Self Terminate.... (This would cause the robot to fall off the table)");
                    return false;
                }
                else return true;
            }
            else if (direction == "EAST")
            {
                y++;
                if (y > _table.Width)
                {
                    Console.WriteLine("Robot says: I Cannot Self Terminate.... (This would cause the robot to fall off the table)");
                    return false;
                }
                else return true;
            }
            else if (direction == "SOUTH")
            {
                x--;
                if (x < _table.Height)
                {
                    Console.WriteLine("Robot says: I Cannot Self Terminate.... (This would cause the robot to fall off the table)");
                    return false;
                }
                else return true;
            }
            else if (direction == "WEST")
            {
                y--;
                if (y < _table.Width)
                {
                    Console.WriteLine("Robot says: I Cannot Self Terminate.... (This would cause the robot to fall off the table)");
                    return false;
                }
                else return true;
            }
            else return false;
        }
    }
}
