//Which word is the longest?
string[] words = { "abcabcbb", "bbbbb", "pwwkew" };
string maxWord = "";
int maxCount = 0;

foreach (var word in words)
{
    int uniqueCount = word.Distinct().Count();
    Console.WriteLine(uniqueCount);
    if (uniqueCount > maxCount)
    {
        maxCount = uniqueCount;
        maxWord = word;
    }
}