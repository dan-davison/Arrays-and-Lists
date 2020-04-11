using System;
using System.Collections.Generic;

namespace List3_DanDavison
{
    class Program
    {
        static void Main(string[] args)
        {
            string stop = "STOP";
            int size = 200;
            List<string> list = new List<string>();

            System.Console.WriteLine("Please write single words. When you are finished input 'STOP'");

            int counter = 0;

            while (counter <size){
                string input = Console.ReadLine();
                
                if (input == stop){
                    System.Console.WriteLine("____________________________________");
                    System.Console.WriteLine();
                    list.Reverse();
                    foreach (string word in list){
                        System.Console.WriteLine(word);
                    }
                    break;

                }
                counter++;

                list.Add(input);

            }

            Console.ReadKey();

        }
    }
}
