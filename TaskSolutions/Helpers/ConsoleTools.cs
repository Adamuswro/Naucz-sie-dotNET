using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class ConsoleTools
    {
        public static void CloseProgram(string message = "")
        {
            if (String.IsNullOrEmpty(message) == false)
            {
                Console.WriteLine(message);
            }
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
