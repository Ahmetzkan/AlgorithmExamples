//Algorithm that finds the first non repeating character index


bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Enter a text: ");
    string input = Console.ReadLine();

    Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

    foreach (var i in input)
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

    foreach (var i in input)
    {
        if (keyValuePairs[i] == 1)
        {
            Console.WriteLine($"First non-repeating character index: {i}");
            break;
        }
    }


    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}
