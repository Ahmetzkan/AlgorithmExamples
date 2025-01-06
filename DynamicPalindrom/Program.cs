string text = "121te st";
text = text.Trim().Replace(" ", "");

string[] textArray = new string[] { text }; //121test
Array.Reverse(textArray);//tset121

string index = textArray[0];
int length = index.Length;
bool temp = false;
string tempString = "";

for (int i = 0; i < length; i++)
{
    if (text.Equals(textArray[0]))
    {
       temp = true;
    }
    else
    {
        temp = false;
    }
}

Console.WriteLine(temp);