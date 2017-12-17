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
            
            try
            {
                if (args[0].Contains("-l"))
                {
                    Filehandler.Reader();

                }

                if (args[0].Contains("-a"))
                {
                    if (args.Length == 1)
                    {
                        Console.WriteLine("Unable to add: no task provided");
                    }

                    else
                    {
                        Filehandler.Writer(args);
                    }

                        
                }

                if (args[0].Contains("-r"))
                {
                    Filehandler.Remover(args);
                }

                if (args[0].Contains("-c"))
                {

                }
            }

            catch (Exception e)
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
