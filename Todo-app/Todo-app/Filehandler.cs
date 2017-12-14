using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Todo_app
{
    public class Filehandler
    {
        
        public static void Reader()
        {
            string path = @"C:\Users\user\greenfox\Endirell-todo-app\Todo-app\todo.txt";

            string[] content = File.ReadAllLines(path);

            foreach (string line in content)
            {
                Console.WriteLine(line);
            }
            
        }        
        

       

    }
}
