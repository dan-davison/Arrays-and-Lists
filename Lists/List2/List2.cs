using System;
using System.Collections.Generic;

namespace List2_DanDavison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numblist = new List<int>();
            Console.WriteLine("Please enter 5 numbers:");
            int counter1 = 0;
            
            while (counter1 <5){   
                int input = int.Parse(Console.ReadLine());
                numblist.Add(input);
                counter1++;
            }

            System.Console.WriteLine("Please enter a number to see how many times it was entered:");
            int x = int.Parse(Console.ReadLine());
            bool check = false;
            int counter2=0;

            for (int i = 0; i < numblist.Count; i++){
                if (x == numblist[i]){
                    check = true;
                    counter2++;
                }
            }

            if (check == true){
                System.Console.WriteLine("This number was entered " + counter2 + " times");
            }

            else{
                System.Console.WriteLine("This number has not been entered");
            }

            Console.ReadKey();
        }
    }
}
