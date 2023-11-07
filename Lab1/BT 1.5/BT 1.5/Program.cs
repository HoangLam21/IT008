using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BT_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap duong dan thu muc:  ");
            string filepath = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(filepath);
            FileInfo[] Files = directoryInfo.GetFiles();
            if (directoryInfo.Exists)
            {
                foreach (FileInfo file in Files)
                {
                    Console.WriteLine("File Name: " + file.Name);
                }
            }
            else
            {
                Console.WriteLine("Khong ton tai thu muc nao o duong dan nay!");
            }

            Console.ReadKey();
        }
    }
}
