using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot.Library.Interfaces;

namespace ToyRobot.Library.Entities
{
    public class Table 
    {
        public int Height;
        public int Width;

        public Table(int Height, int Width)
        {
            this.Height = Height;
            this.Width = Width;
        }

        
    }
}
