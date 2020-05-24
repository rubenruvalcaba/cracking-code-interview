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
    }

}