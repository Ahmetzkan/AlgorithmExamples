//Algorithm that separates the entered word letter by letter
bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Enter the word you want to separate letter by letter.: ");
    string word = Console.ReadLine();
   
    List<int> words = new List<int>();

    for (int i = 0; i < word.Length; i++)
    {
        words.Add(word[i]);
    }

    foreach (var item in words)
    {
        Console.Write((char)item + " - ");
    }   

    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");
}