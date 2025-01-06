//Algorithm to find uncontrolled anagram number

string text = "a man, a plan, a canal, Panama"; 

string currentText = text.Replace(",", "");
currentText = currentText.Replace(" ", "").ToLower();

var reverseArray = currentText.Reverse();
string reverseText = "";

foreach (var item in reverseArray)
{
    reverseText += item;
}


if (currentText == reverseText)
{
    Console.WriteLine("That is a desired number");
}
else
{
    Console.WriteLine("That is not a desired number");
}