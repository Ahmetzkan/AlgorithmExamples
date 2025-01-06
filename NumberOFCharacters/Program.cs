//Algorithm that finds the number of characters in the text

bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Enter a string: ");
    string input = Console.ReadLine();

    Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

    foreach (char i in input)
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

    foreach (var i in keyValuePairs)
    {
        Console.WriteLine($"Char: {i.Key}, Count: {i.Value}");
    }


    args = new string[] { input };

    if (args.Length > 0 && args[0].Length > 0)
    {
        Console.WriteLine("First character of args:" + args[0][0]);
    }

    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}
