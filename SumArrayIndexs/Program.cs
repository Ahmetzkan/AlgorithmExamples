//Algorithm that cumulatively adds indexes in an array

int[] sumArray = { 1, 2, 3, 4 };

int temp = 0;

for (int i = 0; i < sumArray.Length; i++)
{
    temp += sumArray[i];
    sumArray[i] = temp;
}

Console.WriteLine(string.Join(",", sumArray));
