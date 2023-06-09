using System;

namespace Palindrome
{
    using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                bool isPalindrome = IsPalindrome(arg);
                
                Console.WriteLine($"{arg} -> {isPalindrome}");
            }
        }

        static bool IsPalindrome(string str)
        {
            if (str == null)
                throw new ArgumentNullException(nameof(str));

            if (str.Length < 2)
                return true;

            return IsPalindromeRecursive(str, 0, str.Length - 1);
        }

        static bool IsPalindromeRecursive(string str, int start, int end)
        {
            if (start >= end)
                return true;

            if (str[start] != str[end])
                return false;

            return IsPalindromeRecursive(str, start + 1, end - 1);
        }
    }
}
}

