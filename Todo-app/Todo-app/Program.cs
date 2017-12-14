using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Todo_app
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Filehandler.Reader();

            Console.ReadLine();

            if (args.Length == 0)
            {

                Console.WriteLine("Command Line Todo application\n=============================\n\nCommand line arguments:" +
                "\n -l  Lists all the tasks\n -a  Adds a new task\n -r  Removes an task\n -c  Completes an task\n");

            }
           
           

            Console.ReadLine();



        }
        
    }
}
