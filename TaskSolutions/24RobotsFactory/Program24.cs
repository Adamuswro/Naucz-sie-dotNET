using System;
using _24RobotsFactory.DataSource;
using _24RobotsFactory.Models;
using Helpers;

//All classes should be placed in seperated files, but beacouse code is very simple it was decided to keep it in one file.
namespace _24RobotsFactory
{
    class Program24
    {
        static void Main(string[] args)
        {
            var robotFactory = new RobotFactory(new JsonDataSource());

            var robot = robotFactory.CreateRobot();
            Console.WriteLine(robot);

            robotFactory.ResetId(robot);

            Console.WriteLine(robot);

            ConsoleTools.CloseProgram();
        }
    }




}
