//Algorithm that adding a new element to an array entered by the user at an index chosen by the user

bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Write the number you want to enter with a space..");
    int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    Console.WriteLine("Enter the new element:");
    int newElement = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the index where you want to insert the new element:");
    int indexToAdd = int.Parse(Console.ReadLine());

    int[] tempArrays = new int[numbers.Length + 1];
    for (int i = 0; i < indexToAdd; i++)
    {
        tempArrays[i] = numbers[i];
    }

    tempArrays[indexToAdd] = newElement;

    for (int i = indexToAdd; i < numbers.Length; i++)
    {
        tempArrays[i + 1] = numbers[i];
    }

    numbers = tempArrays;

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