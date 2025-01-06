//Algorithm that sorts 5 numbers in a series from smallest to largest

bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Enter any numbers separated by a space: ");
    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int temp;

    for (int i = 0; i < numbers.Length / 2; i++)
    {
        temp = numbers[i];
        numbers[0] = numbers[numbers.Length - i - 1];
        numbers[numbers.Length - i - 1] = temp;
    }

    for (int k = 0; k < numbers.Length; k++)
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