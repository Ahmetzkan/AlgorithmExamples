//Algorithm that finds missing and repeating numbers

int[] numbers = { 4, 3, 6, 2, 1, 1 };

Array.Sort(numbers);//1,1,2,3,4,6

for (int i = 1; i < numbers.Length; i++)
{

    if (numbers[i] == numbers[i - 1])
    {
        Console.WriteLine("This number is repeating yourself: " + numbers[i]);
    }
    if (numbers[i] == numbers[i - 1] + 2)
    {
        Console.WriteLine("This number is missing: " + (numbers[i - 1] + 1));
    }
}

