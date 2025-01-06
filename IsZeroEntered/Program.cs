//Algorithm that sums all numbers entered until zero is entered from the keyboard

bool restartAgain = true;
while (restartAgain)
{
    int total = 0;
    while (true)
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            break;
        }
        else
        {
            total += number;
        }
    }
    Console.WriteLine($"Total sum: {total}");

    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");

}

