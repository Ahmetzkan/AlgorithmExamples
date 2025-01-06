//Algorithm that returns the sentence by capitalizing the first letter of each sentence

bool restartAgain = true;
while (restartAgain)
{
    Console.WriteLine("Please enter a sentence:");
    string sentence = Console.ReadLine();
    string[] sentenceArray = sentence.Split(' ');// that sentence is test.

    for (int i = 0; i < sentenceArray.Length; i++)
    {
        sentenceArray[i] = char.ToUpper(sentenceArray[i][0]) + (sentenceArray[i].Substring(1));
    }

    Console.WriteLine(string.Join(" ", sentenceArray));


    Console.WriteLine("Do you want to restart the program? (Y/N)");
    string restart = Console.ReadLine();
    restartAgain = (restart == "Y" || restart == "y");

}