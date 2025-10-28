
using System;
using System.Collections.Generic;

public class InsertionSort
{

    public List<int> Sort(List<int> arr)
    {
        for (int i = 1; i < arr.Count; i++)
        {

            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                arr[j] = key;
                j = j - 1;
            }
        }

        return arr;
    }

    public static void Main(string[] args)
    {
        List<int> arr = new List<int> { 500, 5, 1, 9, 8, 7, 1, 2, 4555, 77777, 4, 9, 0 };

        InsertionSort my_class = new InsertionSort();
        List<int> sorted = my_class.Sort(arr);
        Console.WriteLine(string.Join(",", sorted));

    }
}