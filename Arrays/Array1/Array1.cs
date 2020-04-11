using System;

namespace Array1_DanDavison
{
    class Program
    {
        static void Main(string[] args)
        {   
           int size = 5;
           string[] name = new string [size];

           Console.WriteLine("Please enter 5 names:");

           for(int i = 0; i < 5; i++){
                string names = Console.ReadLine();
                name[i] = names;
                name[i] = names;
                name[i] = names;
                name[i] = names;
                name[i] = names;
            }

    
           System.Console.WriteLine("-----------------------");
 
           int index =0;

           while(index <name.Length) {
                System.Console.WriteLine("Hello " + name[index] + "!");

                index++;

            }
            
            Console.ReadKey();

        }
    }
}
