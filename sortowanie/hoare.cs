using System;

class Program {
    static void Main(string[] args) {
        int[] arr = { 5, 3, 8, 4, 2 };
        QuickSort(arr, 0, arr.Length - 1);
        Console.WriteLine(string.Join(", ", arr));
    }

    static void QuickSort(int[] arr, int left, int right) {
        if (left < right) {
            int pivot = Partition(arr, left, right);
            QuickSort(arr, left, pivot);
            QuickSort(arr, pivot + 1, right);
        }
    }

    static int Partition(int[] arr, int left, int right) {
        int pivot = arr[left];
        int i = left - 1;
        int j = right + 1;
        while (true) {
            do {
                i++;
            } while (arr[i] < pivot);

            do {
                j--;
            } while (arr[j] > pivot);

            if (i >= j) {
                return j;
            }

            Swap(arr, i, j);
        }
    }

    static void Swap(int[] arr, int i, int j) {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
