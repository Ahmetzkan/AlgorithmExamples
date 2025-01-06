//Algorithm that finds the greatest common multiple of the entered number

bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Enter a first number:");
    int number1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter a second number:");
    int number2 = int.Parse(Console.ReadLine());

    while (number1 != number2)
    {
        if (number1 > number2)
        {
            number1 -= number2;
        }
        else if (number1 < number2)
        {
            number2 -= number1;
        }
    }
    Console.WriteLine("The greatest common divisor is: " + number1);


    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}
