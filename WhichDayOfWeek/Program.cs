//Algorithm that finds which day a certain date is after a number is entered.

bool restartAgain = true;
while (restartAgain)
{
    string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

    Console.WriteLine("Enter a number for how many days you want to go forward: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("What day is today?");
    string day = Console.ReadLine();

    int currentIndex = Array.IndexOf(days, day);

    if (currentIndex == -1)
    {
        Console.WriteLine("Invalid day");
        continue;
    }

    int futureIndex = (currentIndex + number) % 7;

    Console.WriteLine($"After {number} days, it will be {days[futureIndex]}.");


    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}