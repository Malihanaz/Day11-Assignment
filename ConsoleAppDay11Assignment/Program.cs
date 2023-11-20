using System;

class QuickSort
{
    public static void Main()
    {
        int[] array = { 12, 4, 5, 6, 7, 3, 1, 15, 2, 10 };

        Console.WriteLine("Original array: " + string.Join(", ", array));

        QuickSortAlgorithm(array, 0, array.Length - 1);

        Console.WriteLine("Sorted array: " + string.Join(", ", array));

        // Check if the array is sorted correctly
        Console.WriteLine("Array is sorted: " + IsSorted(array));
    }

    static void QuickSortAlgorithm(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);

            QuickSortAlgorithm(arr, low, pivotIndex - 1);
            QuickSortAlgorithm(arr, pivotIndex + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }

    static bool IsSorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
                return false;
        }
        return true;
    }
}
