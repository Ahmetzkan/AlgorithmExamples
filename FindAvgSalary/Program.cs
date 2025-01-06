int[] numbers = { 10, 20, 30, 40, 50 };
double average = CalculateAverage(numbers);

Console.WriteLine("The average is: " + average);

static double CalculateAverage(int[] array)
{
    int sum = 0;
    foreach (int number in array)
    {
        sum += number;
    }

    double average = (double)sum / array.Length;

    return average;
}

