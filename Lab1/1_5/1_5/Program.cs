using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Nhập đường dẫn thư mục: ");
        string folderPath = Console.ReadLine();

        if (Directory.Exists(folderPath))
        {
            string[] files = Directory.GetFiles(@folderPath);
            if (files.Length > 0)
            {
                Console.WriteLine("Các tập tin trong thư mục:");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            else
            {
                Console.WriteLine("Thư mục không chứa tập tin nào.");
            }
        }
        else
        {
            Console.WriteLine("Đường dẫn thư mục không tồn tại.");
        }

        Console.ReadLine();
    }
}