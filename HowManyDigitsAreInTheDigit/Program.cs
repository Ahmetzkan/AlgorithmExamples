//Algorithm to find how many digits a number has

Console.WriteLine("Enter a input:");
int input = int.Parse(Console.ReadLine());

int counter = 0;

for (; input > 0; input /= 10)
{
    counter++;
}

Console.WriteLine(counter);