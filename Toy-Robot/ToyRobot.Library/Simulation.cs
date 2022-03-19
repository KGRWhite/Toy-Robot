using ToyRobot.Library.Entities;

namespace ToyRobot.Library
{


    /// <summary>
    /// Simulation to handle the console looping and inputs into the CommandProcessor.
    /// </summary>
  
    public class Simulation
    {
        private Table Table;
        private CommandProcessor CommandProcessor;
        private bool isRunning = false;


        public Simulation(Table table)
        {
            Table = table;
            CommandProcessor = new CommandProcessor(table);
        }

        public void Start()
        {
            isRunning = true;
            Console.WriteLine("Simulation Starting..."); 
            while(isRunning)
            {
                Console.Write(">");
                string input = Console.ReadLine();
                if(input != "EXIT")
                {
                    
                    CommandProcessor.Execute(input);
                }
                else
                {

                    Console.WriteLine("Exiting Simulation..");
                    isRunning = false;
                }
                
            }
        }
    }
}