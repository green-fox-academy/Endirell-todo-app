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
            Console.WriteLine(" ");
            

            if (args.Contains("-l"))
            {
                Filehandler.Reader();     
                
            }

            if (args.Contains("-a"))
            {
                Filehandler.Writer(args);
            }

            if (args.Contains("-r"))
            {
                
            }

            if (args.Contains("-c"))
            {
                
            }

            if (args.Length == 0)
            {
                Console.WriteLine("Command Line Todo application\n=============================\n\nCommand line arguments:" +
                "\n -l  Lists all the tasks\n -a  Adds a new task\n -r  Removes an task\n -c  Completes an task\n");
            }
           
            Console.ReadLine();



        }
        
    }
}
