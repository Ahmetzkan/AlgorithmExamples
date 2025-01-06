//Write a C# program that takes two numbers
//as input and returns the sum of the numbers between those two numbers.

static void SumBetweenTwoNumbers(int number1, int number2)
{
    int sum = 0;
    for (int i = number1; i <= number2; i++)
    {
        sum += i;
    }
    Console.WriteLine("The sum of numbers between {0} and {1} is {2}", number1, number2, sum);
}

bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Please enter the first number:");
    int number1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Please enter the second number:");
    int number2 = int.Parse(Console.ReadLine());
    SumBetweenTwoNumbers(number1, number2);

    Console.WriteLine("\nDo you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}