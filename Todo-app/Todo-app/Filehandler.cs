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
        
        public static void Lister()
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
                    Console.WriteLine((i + 1) + " - " + content[i]);
                }
            }
            
        }

        public static void Adder(string[] arr)
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
            if (arr.Length == 1)
            {
                Console.WriteLine("Unable to remove: no index provided");
            }

            else
            {
                try
                {
                    int whichline = Convert.ToInt32(arr[1]);

                    string path = @"C:\Users\user\greenfox\Endirell-todo-app\Todo-app\todo.txt";

                    string[] content = File.ReadAllLines(path);

                    if (whichline <= content.Length)
                    {
                        using (StreamWriter wr = new StreamWriter(path))
                        {
                            for (int k = 0; k < content.Length; k++)
                            {
                                if (k < whichline - 1)
                                {
                                    wr.WriteLine(content[k]);
                                }

                                else
                                {
                                    wr.WriteLine(content[k + 1]);
                                }

                            }

                        }
                    }

                    else
                    {
                        Console.WriteLine("Unable to remove: index is out of bound\nYou have " + content.Length + " tasks for today.");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to remove: index is not a number");
                }
            }                        
        }




    }
}
