//Algorithm that Sum of n factorial series

bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Enter a value for n:");
    int n = Convert.ToInt32(Console.ReadLine());

    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i / Factorial(i + 1);
    }

    Console.WriteLine($"Sum of the series for n= {n} : {sum}");

    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");

}

static double Factorial(int num)
{
    double fact = 1;
    for (int i = 2; i <= num; i++)
        {
        fact *= i;
    }
    return fact;
}
