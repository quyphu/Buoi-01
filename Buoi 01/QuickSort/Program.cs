using System;

class Program
{
    static void Main()
    {
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Mảng trước khi sắp xếp:");
        PrintArray(array);

        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("Mảng sau khi sắp xếp:");
        PrintArray(array);
    }

    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            // Phân chia mảng và tìm chỉ số phân vùng
            int pi = Partition(array, low, high);

            // Đệ quy sắp xếp các nửa
            QuickSort(array, low, pi - 1);
            QuickSort(array, pi + 1, high);
        }
    }

    static int Partition(int[] array, int low, int high)
    {
        // Chọn phần tử cuối làm pivot
        int pivot = array[high];
        int i = (low - 1); // Chỉ số phần tử nhỏ hơn

        for (int j = low; j < high; j++)
        {
            // Nếu phần tử hiện tại nhỏ hơn hoặc bằng pivot
            if (array[j] <= pivot)
            {
                i++;

                // Đổi chỗ array[i] và array[j]
                Swap(array, i, j);
            }
        }

        // Đổi chỗ pivot với phần tử tiếp theo của phần tử nhỏ hơn
        Swap(array, i + 1, high);

        return i + 1;
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static void PrintArray(int[] array)
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}
