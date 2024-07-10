using System;

class Program
{
    static void Main()
    {
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Mảng trước khi sắp xếp:");
        PrintArray(array);

        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("Mảng sau khi sắp xếp:");
        PrintArray(array);
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            // Sắp xếp nửa bên trái
            MergeSort(array, left, middle);

            // Sắp xếp nửa bên phải
            MergeSort(array, middle + 1, right);

            // Hợp nhất hai nửa đã sắp xếp
            Merge(array, left, middle, right);
        }
    }

    static void Merge(int[] array, int left, int middle, int right)
    {
        // Tạo các mảng tạm thời cho hai nửa
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        // Sao chép dữ liệu vào các mảng tạm thời
        Array.Copy(array, left, leftArray, 0, n1);
        Array.Copy(array, middle + 1, rightArray, 0, n2);

        // Chỉ số bắt đầu cho các mảng tạm thời
        int i = 0, j = 0;
        int k = left;

        // Hợp nhất các mảng tạm thời trở lại vào mảng chính
        while (i < n1 && j < n2)
        {
            if (leftArray[i] <= rightArray[j])
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }

        // Sao chép các phần tử còn lại của leftArray, nếu có
        while (i < n1)
        {
            array[k] = leftArray[i];
            i++;
            k++;
        }

        // Sao chép các phần tử còn lại của rightArray, nếu có
        while (j < n2)
        {
            array[k] = rightArray[j];
            j++;
            k++;
        }
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
