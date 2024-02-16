using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReversed(arr, index - 1);
        }
    }
}