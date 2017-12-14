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

            if (content.Length == 0)
            {
                Console.WriteLine("No todos for today! :)");
            }

            else
            {
                for (int i = 0; i < content.Length; i++)
                {
                    Console.WriteLine(i + 1 + " - " + content[i]);
                }
            }
            
        }

        public static void Writer(string[] arr)
        {
            string path = @"C:\Users\user\greenfox\Endirell-todo-app\Todo-app\todo.txt";

            
            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    for (int j = 1; j < arr.Length; j++)
                    { 
                        sw.WriteLine(arr[j]);
                    }

                }

            }
            catch (Exception e)
            {
                Console.Clear();
            }

        }

        public static void Remover(string[] arr)
        {
            try
            {
                int whichline = Convert.ToInt32(arr[1]) - 1;

                string path = @"C:\Users\user\greenfox\Endirell-todo-app\Todo-app\todo.txt";

                string[] content = File.ReadAllLines(path);

                using (StreamWriter wr = new StreamWriter(path))
                {
                    for (int k = 0; k < whichline; k++)
                    {
                       
                        wr.WriteLine(content[k]);
                        
                        
                    }

                    for (int k = 0; k < arr.Length; k++)
                    {

                        wr.WriteLine(content[k]);


                    }

                }
            }
            catch (Exception e)
            {
            }
        }




    }
}
