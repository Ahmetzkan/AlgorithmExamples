//Algorithm that finds the number you want to find in an array

int[] array = { 1, 2, 3, 4 };

Console.WriteLine("Enter the number you want to find in the array");
int input = int.Parse(Console.ReadLine());
bool founded = false;

foreach (int i in array)
{
    if (i == input)
    {
        Console.WriteLine($"The number {i} is found in the array.");
        founded = true;
        break;

    }
}

if (!founded)
{
    Console.WriteLine("The number isnt found in the array");

}