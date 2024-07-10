using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Khởi tạo mảng số nguyên
        int[] a = { 1, 2, 3, 4, 5 };

        // Tính tổng các phần tử trong mảng
        int sum = CalculateSum(a);

        // Hiển thị tổng
        Console.WriteLine("Tổng các phần tử trong mảng là: " + sum);

        // Để cửa sổ console không đóng ngay lập tức, chờ người dùng nhấn phím
        Console.WriteLine("Nhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }

    // Phương thức tính tổng các phần tử trong mảng
    static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (int number in array)
        {
            sum += number;
        }
        return sum;
    }
}
