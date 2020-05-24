using System;
using System.Text;

namespace chapter1
{
    class exercises
    {
        public static void Run()
        {
            /*
            Console.WriteLine($"IsUniqueString abcd {IsUniqueString("abcd")}");
            Console.WriteLine($"IsUniqueString abbc {IsUniqueString("abbc")}");
            Console.WriteLine($"IsUniqueString a {IsUniqueString("a")}");
           

            Console.WriteLine($"is 'abc' permutation of 'cab' {IsPermutation("abc", "cab")}");
            Console.WriteLine($"is 'abc' permutation of 'abc' {IsPermutation("abc", "abc")}");
            Console.WriteLine($"is 'abc' permutation of 'xyz' {IsPermutation("abc", "xyz")}");
            Console.WriteLine($"is 'a' permutation of 'xyz' {IsPermutation("a", "xyz")}");

            Console.WriteLine($"Urilify 'a b c    ' -> {urlify("a b c    ")}");
            Console.WriteLine($"Urilify 'this is an awesome test        ' -> {urlify("this is an awesome test        ")}");
            Console.WriteLine($"Urilify 'NoSpacesBetween' -> {urlify("NoSpacesBetween")}");
*/

            Console.WriteLine($"'taco cat' is palindrome: {IsPalindrome("taco cat")}");
            Console.WriteLine($"'abba' is palindrome: {IsPalindrome("abba")}");
            Console.WriteLine($"'abdba' is palindrome: {IsPalindrome("abdba")}");
            Console.WriteLine($"'not a palindrome' is palindrome: {IsPalindrome("not a palindrome")}");

        }

        private static bool IsPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length == 1)
                return true;

            int j = text.Length - 1;
            int i = 0;
            while (i < text.Length && i != j)
            {
                if (text[i] == ' ')
                {
                    i++;
                    if (i > text.Length)
                        break;
                }

                if (text[j] == ' ')
                {
                    j--;
                    if (i == j)
                        break;
                }

                if (text[i] != text[j])
                    return false;

                i++;
                j--;
            }

            return true;

        }

        // Replace spaces by %20 
        private static string urlify(string text)
        {

            // Validate input
            if (string.IsNullOrEmpty(text))
                return "";

            // Traverse any character
            var sb = new StringBuilder();
            var arr = text.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == ' ')
                {
                    // Move to the right the remain chars
                    for (var j = arr.Length - 1; j > i + 1; j--)
                        arr[j] = arr[j - 2];

                    // Encode the space for this position
                    arr[i] = '%';
                    arr[i + 1] = '2';
                    arr[i + 2] = '0';

                }
                sb.Append(arr[i]);
            }

            return sb.ToString();

        }

        private static bool IsUniqueString(string stringToCheck)
        {
            // Validate input
            if (string.IsNullOrEmpty(stringToCheck))
                return true;

            // Check every character in s against the rest of the string
            var s = stringToCheck.ToLower();
            for (int i = 0; i < s.Length; i++)
                for (int j = i + 1; j < s.Length; j++)
                    if (s[i] == s[j]) // if has a match then it's not unique
                        return false;

            return true;

        }

        // Given two strings, write a method to decide if one is a permutation of the other
        private static bool IsPermutation(string first, string second)
        {
            if (string.IsNullOrEmpty(first) || string.IsNullOrEmpty(second))
                return false;

            if (first.Length != second.Length)
                return false;

            first = first.ToLower();
            second = second.ToLower();
            if (first == second)
                return false;

            var anyDifferentPosition = false;
            for (int i = 0; i < first.Length; i++)
            {
                var exists = false;
                var samePos = false;
                for (int j = 0; j < second.Length; j++)
                    if (first[i] == second[j])
                    {

                        exists = true;
                        samePos = i == j;
                        break;
                    }

                if (!exists)
                    return false;

                if (!anyDifferentPosition && !samePos)
                    anyDifferentPosition = true;

            }

            return anyDifferentPosition;

        }
    }

}