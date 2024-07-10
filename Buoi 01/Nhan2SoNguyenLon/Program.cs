using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Khởi tạo hai số nguyên lớn
        string num1 = "123456789012345678901234567890";
        string num2 = "987654321098765432109876543210";

        // Nhân hai số
        string result = MultiplyLargeNumbers(num1, num2);

        // Hiển thị kết quả
        Console.WriteLine("Kết quả của phép nhân là:");
        Console.WriteLine(result);

        // Để chương trình không tự động đóng, chờ người dùng nhấn một phím
        Console.WriteLine("Nhấn phím bất kỳ để thoát...");
        Console.ReadKey(); // Gọi phương thức ReadKey để chờ nhấn phím
    }

    static string MultiplyLargeNumbers(string num1, string num2)
    {
        int len1 = num1.Length;
        int len2 = num2.Length;
        int[] result = new int[len1 + len2];

        // Reverse các chuỗi số để dễ nhân
        char[] num1Arr = num1.ToCharArray();
        char[] num2Arr = num2.ToCharArray();
        Array.Reverse(num1Arr);
        Array.Reverse(num2Arr);
        num1 = new string(num1Arr);
        num2 = new string(num2Arr);

        // Nhân từng chữ số
        for (int i = 0; i < len1; i++)
        {
            int n1 = num1[i] - '0';
            for (int j = 0; j < len2; j++)
            {
                int n2 = num2[j] - '0';
                result[i + j] += n1 * n2;
                // Xử lý carry
                if (result[i + j] >= 10)
                {
                    result[i + j + 1] += result[i + j] / 10;
                    result[i + j] %= 10;
                }
            }
        }

        // Tạo chuỗi kết quả
        StringBuilder sb = new StringBuilder();
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (!(sb.Length == 0 && result[i] == 0)) // Bỏ qua số 0 đầu tiên
            {
                sb.Append(result[i]);
            }
        }

        return sb.Length == 0 ? "0" : sb.ToString();
    }
}
