using OopFriendAssembly.ArrayLibrary;
using System;

namespace OopFriendAssembly.App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 1, 2, 5 };
            int[] result = ArrayHelper.BubbleSort(array, SortOrder.Ascending);
            string resultList = string.Join(", ", result);
            Console.WriteLine($"Sorted array={resultList}");
        }
    }
}
