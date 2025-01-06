namespace AmicablePairs
{
    public class Program
    {
        // Write a C# program finds first two amicable pairs. (Output: 1-> 220-284 2: 1184-1210) 
        static void Main(string[] args)
        {
            int number = 0, number2 = 0;

            List<int> amicableList = new List<int>();

            for (int i = 0; i < 2000; i++)
            {
                number = getAmicable(i);
                number2 = getAmicable(number);

                if (number != i && number2 == i && !amicableList.Contains(number) && !amicableList.Contains(number2))
                {
                    amicableList.Add(number);
                    amicableList.Add(number2);

                    Console.WriteLine(number2 + " - " + number);
                }
            }

        }
        public static int getAmicable(int number)
        {
            int numberDivisors = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    numberDivisors += i;
                }
            }
            return numberDivisors;
        }
    }
}