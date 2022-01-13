using P224ExampleTask1.Models;
using System;

namespace P224ExampleTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student stu1 = new Student("A B", "P224", 23);

            //Console.WriteLine(stu1);

            string word = "Hello";
            while (word.Length > 0)
            {
                int count = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[0] == word[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{word[0]}={count}");
                Console.WriteLine(word);
                word = word.Replace(word[0].ToString(), "");
            }
        }
    }
}
