// Algorithm to find how many repeating numbers there are

int[] repeatingNumbers = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };

Dictionary<int, int> countRepeatingNumbers = new Dictionary<int, int>();

for (int i = 0; i < repeatingNumbers.Length; i++)
{
    if (countRepeatingNumbers.ContainsKey(repeatingNumbers[i]))
    {
        countRepeatingNumbers[repeatingNumbers[i]]++;
    }
    else
    {
        countRepeatingNumbers[repeatingNumbers[i]] = 1;

    }
}

foreach (var i in countRepeatingNumbers)
{
    Console.WriteLine($"This number {i.Key} repeats itself until: {i.Value}");
}