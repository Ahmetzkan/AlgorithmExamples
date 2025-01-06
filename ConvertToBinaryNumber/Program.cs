bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Enter a number:");
    int number = int.Parse(Console.ReadLine());
    int dividing = 2;
    string binaryNumber = "";

    while (number > 0)
    {
        int remainder = number % 2;
        binaryNumber = remainder + binaryNumber;
        number /= 2;
    }

    Console.WriteLine("Binary number:" + binaryNumber);

    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}
