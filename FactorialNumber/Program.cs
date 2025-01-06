//Algorithm to find the factorial of the entered number

bool restartAgain = true;
while (restartAgain)
{
    int factorial = 1;

    Console.WriteLine("Enter a number:");
    string input = Console.ReadLine();
    int number = int.Parse(input);

    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    Console.WriteLine("Result: " + factorial);


    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}