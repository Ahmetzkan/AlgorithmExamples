//Algorithm that finds the prime dividing factors of the entered number

bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Enter a number:");
    int number = int.Parse(Console.ReadLine());
    int dividing = 2;

    while (number > 1)
    {
        if (number % dividing == 0)
        {
            number /= dividing;
        }
        else
        {
            dividing++;
        }
        Console.WriteLine("Prime factors:" + dividing);

    }

    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");

}

