﻿namespace CharacterCounts
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Write a C# program gives character counts in a string Ex: Tobeto -> t:2, o:2, b:1, e:1

            Console.WriteLine("Please, enter the word ");
            string name = Console.ReadLine().ToUpper();

            string uniqueName = "";


            foreach (var item in name)
            {
                if (uniqueName.Contains(item) == false)
                {
                    uniqueName += item.ToString();
                }
            }

            foreach (var item in uniqueName)
            {
                int count = name.Count(a => a == item);
                Console.WriteLine(item + " " + count);
            }

            Console.ReadLine();
        }
    }
}