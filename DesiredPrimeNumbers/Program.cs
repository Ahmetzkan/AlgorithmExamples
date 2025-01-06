//Algorithm to find as many prime numbers as desired

bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("How many prime numbers do you want to find?");
    int wantedPrimeNumberCount = int.Parse(Console.ReadLine());
    int foundPrimeNumberCount = 0;
    int numberToCheck = 2;

    while (foundPrimeNumberCount < wantedPrimeNumberCount)
    {
        bool isPrime = true;
        for (int i = 2; i <= numberToCheck / 2; i++)
        {
            if (numberToCheck % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (isPrime)
        {
            Console.WriteLine(numberToCheck);
            foundPrimeNumberCount++;
        }

        numberToCheck++;
    }

    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}
