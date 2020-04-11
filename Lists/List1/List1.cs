using System;
using System.Collections.Generic;

namespace List1_DanDavison
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();

            System.Console.WriteLine("Please enter in 5 numbers:");
            int numb1 = int.Parse(System.Console.ReadLine());
            int numb2 = int.Parse(System.Console.ReadLine());
            int numb3 = int.Parse(System.Console.ReadLine());
            int numb4 = int.Parse(System.Console.ReadLine());
            int numb5 = int.Parse(System.Console.ReadLine());

            numberList.Add(numb1);
            numberList.Add(numb2);
            numberList.Add(numb3);
            numberList.Add(numb4);
            numberList.Add(numb5);

            for (int i =0; i< numberList.Count; i++) {
                System.Console.Write(numberList[i] + " ");

            }

            System.Console.WriteLine();

            System.Console.WriteLine("Please enter in a number to see if it has been entered before:");
            int numb6 = int.Parse(System.Console.ReadLine());

            if (numb6 == numb1) {

                System.Console.WriteLine("This number HAS been entered");
            }

            else if (numb6 == numb2) {

                System.Console.WriteLine("This number HAS been entered");
            }

            else if (numb6 == numb3) {

                System.Console.WriteLine("This number HAS been entered");
            }

            else if (numb6 == numb4) {

                System.Console.WriteLine("This number HAS been entered");
            }

            else if (numb6 == numb5) {

                System.Console.WriteLine("This number HAS been entered");
            }

            
            else {
                System.Console.WriteLine("This number HAS NOT been entered ");
            }

            Console.ReadKey();
        }
    }
}
