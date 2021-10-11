using System;

namespace VorsinArraysHomework3
{
    class Program
    {


        static int FindIndex(int number)
        {
            int[] array = { 0,1,2, 3, 4, 5, 6 };
            int numberIndex = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] != number)
                {
                    numberIndex++;
                }
                else
                {
                    break;
                }
                
            }

            return numberIndex;



        }
        static void Main(string[] args)
        {
            /* int[] array = { 1, 2, 3, 4, 5, 6 };

             int number = 6;
             int numberIndex = 0;
             foreach (char c in array)
             {
                 if (c != number)
                 {
                     numberIndex++;
                 }
             };

             Console.WriteLine(numberIndex);

            */
            Console.WriteLine("Which number index do you need?");
            Console.WriteLine(FindIndex(int.Parse(Console.ReadLine())));

            
           


        }
    }
}
