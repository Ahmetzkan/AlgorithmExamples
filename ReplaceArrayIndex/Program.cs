//Algorithm that replace array index with desired number

int[] array = { 1, 2, 2, 4 }; 

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == 3)
    {
        array[i] = 2; 
    }
}

foreach (var item in array)
{
    Console.Write(item + " ");
}