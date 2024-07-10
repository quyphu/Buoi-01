using System;

class Program
{
    static void Main()
    {
        int[] sortedArray = { 2, 5, 7, 10, 15, 18, 21, 25, 30, 35 };
        int target = 18;

        int resultIndex = BinarySearch(sortedArray, target);

        if (resultIndex != -1)
        {
            Console.WriteLine("Phần tử {target} được tìm thấy tại chỉ số {resultIndex}.");
        }
        else
        {
            Console.WriteLine("Phần tử {target} không có trong mảng.");
        }
    }

    static int BinarySearch(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int middle = left + (right - left) / 2;

            // So sánh phần tử giữa với giá trị tìm kiếm
            if (array[middle] == target)
            {
                return middle;
            }

            // Nếu phần tử tìm kiếm lớn hơn phần tử giữa, tìm ở nửa bên phải
            if (array[middle] < target)
            {
                left = middle + 1;
            }
            // Nếu phần tử tìm kiếm nhỏ hơn phần tử giữa, tìm ở nửa bên trái
            else
            {
                right = middle - 1;
            }
        }

        // Nếu không tìm thấy phần tử
        return -1;
    }
}
