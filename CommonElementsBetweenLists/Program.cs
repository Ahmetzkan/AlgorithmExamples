//Algorithm that finds the first non repeating character index

bool restartAgain = true;
while (restartAgain)
{

    int[] aNums = { 2, 3, 4 };
    int[] bNums = { 1, 3, 4 };

    Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

    foreach (int i in aNums)
    {
        if (keyValuePairs.ContainsKey(i))
        {
            keyValuePairs[i]++;
        }
        else
        {
            keyValuePairs[i] = 1;
        }
    }

    List<int> commonNumbers = new List<int>();   

    foreach (var i in bNums)
    {
        if (keyValuePairs.ContainsKey(i) && keyValuePairs[i] >0)
        {
            commonNumbers.Add(i);
        }
    }
    Console.WriteLine("Common numbers:");
    foreach (var i in commonNumbers)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}
