using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyRobot.Library.Interfaces
{
    public interface ICommandProcessor
    {

        /// <summary>
        /// Executes a command and respective parameters
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        bool Execute(string command);

        

    }
}
