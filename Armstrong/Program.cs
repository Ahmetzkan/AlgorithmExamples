using System.Security.Cryptography;

namespace Armstrong
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program to check if the entered number is Armstrong number?
            // 1+125+27 = 157 = 1'3 + 5'3 + 3'3

            bool restartAgain = true;
            while (restartAgain)
            {
                Console.WriteLine("Enter the number");
                string number = Console.ReadLine();
                Armstrong(number);

                Console.WriteLine("Do you want to restart the program? (Y/N)");
                string restart = Console.ReadLine();
                restartAgain = (restart == "Y" || restart == "y");
            }
        }

        static void Armstrong(string number)
        {
            double total = 0;


            for (int i = 0; i < number.Length; i++)
            {
                int getNumber = int.Parse(number[i].ToString());
                total += Math.Pow(getNumber, number.Length);
            }

            if (int.Parse(number) == total )
            {
                Console.WriteLine("{0} is a Armstrong Number", total);
            }
            else
            {
                Console.WriteLine("{0} isn't a Armstrong Number", total);
            }
        }
    }
}

