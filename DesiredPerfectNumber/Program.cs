//Algorithm to find as many prime numbers as desired
// 6 = 1+2+3

bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("How many perfect numbers do you want to find?");
    int wantedPerfectNumberCount = int.Parse(Console.ReadLine());
    int foundPerfectNumberCount = 0;
    int numberToCheck = 2;

    while (foundPerfectNumberCount < wantedPerfectNumberCount)
    {
        int sum = 1;
        for (int i = 2; i <= numberToCheck/2; i++)
        {
            if (numberToCheck % i == 0)
            {
                sum += i;
            }
        }

        if (sum == numberToCheck)
        {
            Console.WriteLine(numberToCheck + " is a perfect number '\n'");
            foundPerfectNumberCount++;
        }

        numberToCheck++;
    }

    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}
