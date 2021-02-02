using System;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for string and displays
            String palindrome, revString = "";
            Console.WriteLine("check to see if your string is a palindrome!");
            palindrome = Console.ReadLine();
            Console.WriteLine("your string is {0}",palindrome);

            //reverses the string
            for (int i=palindrome.Length-1; i>=0; i--)
            {
                revString = revString + palindrome[i];
            }

            //decides if its a palindrome or not and displays result
            Console.WriteLine("your string reversed is {0}",revString);
            if (palindrome == revString)
            {
                Console.WriteLine("it is a palindrome!");

            }

            else
                Console.WriteLine("it is not a palindrome ):");
        }

     
}





    }

