using System;

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
            */

            Console.WriteLine($"is 'abc' permutation of 'cab' {IsPermutation("abc", "cab")}");
            Console.WriteLine($"is 'abc' permutation of 'abc' {IsPermutation("abc", "abc")}");
            Console.WriteLine($"is 'abc' permutation of 'xyz' {IsPermutation("abc", "xyz")}");
            Console.WriteLine($"is 'a' permutation of 'xyz' {IsPermutation("a", "xyz")}");

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