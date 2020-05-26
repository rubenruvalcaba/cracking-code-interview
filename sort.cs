using System;

public class Sort
{
    public static void Run()
    {
        Console.WriteLine($"Sort 8,3,6,4,2,5,7,1 => {SortArray(new int[] { 8, 3, 6, 4, 2, 5, 7, 1 })}");
    }
    private static string SortArray(int[] array)
    {

        SortArray(array, 0, array.Length - 1);

        return String.Join(",", array);

    }

    private static void SortArray(int[] n, int left, int right)
    {
        int p = (right - left + 1) / 2;
        int i = left;
        int j = right;
        while (i < j)
        {
            if (n[i] < p)
                i++;
            if (n[j] > p)
                j--;

            if (n[i] >= p && n[j] <= p)
            {
                var t = n[j];
                n[j] = n[i];
                n[i] = t;
                i++;
                j--;
            }

        }
        if (left == 0 && right == n.Length - 1)
        {
            SortArray(n, left, p);
            SortArray(n, p + 1, right);
        }

    }

}