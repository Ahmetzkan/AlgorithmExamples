//Algorithm that finds how many numbers up to 10 are positive and how many are negative

bool restartAgain = true;
while (restartAgain)
{
    int positiveNumberCount = 0;
    int negativeNumberCount = 0;

    Console.WriteLine("Enter 10 numbers:");
    for (int i = 0; i < 10; i++)
    {
        Console.Write($"Number {i + 1}: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            positiveNumberCount++;
        }
        else if (number < 0)
        {
            negativeNumberCount++;
        }
    }

    Console.WriteLine($"Positive number count: {positiveNumberCount}");
    Console.WriteLine($"Negative number count: {negativeNumberCount}");

    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}
