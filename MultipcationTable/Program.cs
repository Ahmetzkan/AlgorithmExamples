using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class MultiplicationTable
    {
        public static void PrintMultiplicationTable()
        {
            //Algorithm to find numbers up to 100 in the multiplication table
            bool restartAgain = true;
            while (restartAgain)
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.WriteLine();
                }


                Console.WriteLine("Do you want to restart the program? (Y/N)");
                string restart = Console.ReadLine();
                restartAgain = (restart == "Y" || restart == "y");
            }
        }
    }
}
