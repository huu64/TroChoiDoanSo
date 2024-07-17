using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Chương trình đoán số ===");

        // Tạo số ngẫu nhiên
        Random random = new Random();
        int targetNumber = random.Next(100, 999);

        // Chuyển số ngẫu nhiên thành chuỗi
        string targetString = targetNumber.ToString();

        // Biến đếm số lần đoán
        int attempt = 1;

        // Số lần đoán tối đa
        const int MAX_GUESS = 7;

        // Biến lưu trữ phản hồi từ máy tính
        string feedback = "";

        while (feedback != "+++" && attempt < MAX_GUESS)
        {
            // Yêu cầu người chơi nhập số đoán
            Console.Write("Lần đoán thứ {0}: ", attempt);
            string guess = Console.ReadLine();

            // Lấy phản hồi từ máy tính
            feedback = GetFeedback(targetString, guess);

            // Hiển thị phản hồi
            Console.WriteLine("Phản hồi từ máy tính: {0}", feedback);

            // Tăng số lần đoán
            attempt++;
        }

        // Thông báo kết quả
        Console.WriteLine("Người chơi đã đoán {0} lần. Trò chơi kết thúc!", attempt - 1);

        if (attempt > MAX_GUESS)
        {
            Console.WriteLine("Người chơi thua cuộc. Số cần đoán là: {0}", targetNumber);
        }
        else
        {
            Console.WriteLine("Người chơi thắng cuộc!");
        }

        Console.ReadLine();
    }

    static string GetFeedback(string target, string guess)
    {
        string feedback = "";

        for (int i = 0; i < target.Length; i++)
        {
            if (target[i] == guess[i])
            {
                feedback += "+";
            }
            else if (target.Contains(guess[i].ToString()))
            {
                feedback += "?";
            }
        }

        return feedback;
    }
}