
/* 
Author: Loni Campbell
Date: 2/5/21
Practice calling a method
*/

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Friend. What's your name?");
            string input = Console.ReadLine();
            string Hello = HelloMethod(input);
            Console.WriteLine(Hello);
        }
        private static string HelloMethod(string name)
        {
            string sentence = "Hello " + name + "!";

            return sentence;
        }
    }
}
