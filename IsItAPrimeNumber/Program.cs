bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Enter a number:");
    int number = int.Parse(Console.ReadLine());
    bool isPrime = true;

    if (number <= 1)
    {
        isPrime = false;
    }
    else
    {
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
    }

    if (isPrime)
    {
        Console.WriteLine("Your number is a prime number");
    }
    else
    {
        Console.WriteLine("Your number is not a prime number");
    }

    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}
