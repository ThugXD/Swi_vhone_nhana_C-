using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pallindrome
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            String original, reverse = "";

            Console.WriteLine("Enter a string : ");
            original = Console.ReadLine();

            int length = original.Length;

            for (int i = length - 1; i >= 0; i--)
                reverse = reverse + original.ElementAt(i);

            if (original.Equals(reverse))
                Console.WriteLine("Entered string is a palindrome.");
            else
                Console.WriteLine("Entered string is not a palindrome.");

            Console.ReadLine();
        }
    }
}
