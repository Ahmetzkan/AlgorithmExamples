//Algorithm to find out whether a number is a perfect square or not

Console.WriteLine("Enter a number");
int input = int.Parse(Console.ReadLine());
bool isPerfectSquare = false;


for (int i = 0; i <= input; i++)
{
    if (i * i == input)
    {
        isPerfectSquare = true;
    }
    else if (i * i > input)
    {
        break;
    }
}

if (isPerfectSquare)
{
    Console.WriteLine($"{input} is a perfect square");
}
else
{
    Console.WriteLine($"{input} isnt a perfect square");

}