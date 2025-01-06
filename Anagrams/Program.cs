namespace Anagrams
{
    public class Program
    {
        static void Main(string[] args)
        {
            // How to check if two Strings are anagrams of each other? 

            Console.WriteLine("Please, enter the first word");
            string word = Console.ReadLine().ToLower();

            Console.WriteLine("Please, enter the second word");
            string word2 = Console.ReadLine().ToLower();
            //abc //cba
            bool isAnagrams = false;

            char[] chars = word.ToCharArray(); 
            char[] chars2 = word2.ToCharArray();

            Array.Reverse(chars);
            Array.Reverse(chars2);

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == chars2[i])
                {
                    isAnagrams |= true;
                }
            }

            if (isAnagrams)
            {
                Console.WriteLine($"This number: {word} and this number: {word2} is anagram");
            }
            else
            {
                Console.WriteLine("This numbers not anagram");
            }
        }
    }
}