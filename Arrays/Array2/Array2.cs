using System;

namespace Array2_DanDavison
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            numbers [0] = 34;
            numbers [1] = 5;
            numbers [2] = 67;
            numbers [3] = 1;
            numbers [4] = 99;
            numbers [5] = 34;
            numbers [6] = 44;
            numbers [7] = 78;
            numbers [8] = 34;
            numbers [9] = 0;

            int index = 0;
            
            System.Console.WriteLine("The values entered into the array are:");

            while (index<10){
                System.Console.Write(numbers[index] + ", ");
                index++;
            }

            System.Console.WriteLine();
            int sum = 0;

            for (int i =0; i <numbers.Length; i++){
                sum +=numbers[i];
            }

            System.Console.WriteLine("The total of all the values entered is:");
            System.Console.WriteLine(sum);

            Console.ReadKey();


        }
    }
}
