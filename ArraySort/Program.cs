//Algorithm that sorts 5 numbers in a series from smallest to largest

bool restartAgain = true;
while (restartAgain)
{
    int[] numbers = new int[] { 5, 4, 3, 2, 1 };

    int temp;

    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }

    for (int k = 0; k < 5; k++)
    {
        if (k == numbers.Length - 1)
        {
            Console.Write(numbers[k]);
        }
        else
        {
            Console.Write(numbers[k] + " - ");
        }
    }

    Console.WriteLine("\nDo you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}