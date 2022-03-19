using System;
using ToyRobot.Library;
using ToyRobot.Library.Entities;

namespace ToyRobot.Console 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table(5, 5);
            new Simulation(table).Start();
        }
    }
}