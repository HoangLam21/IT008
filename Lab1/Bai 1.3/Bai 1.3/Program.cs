using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._3
{
    internal class Program
    {
        class SoNguyen
        {
            private int[] songuyen;

            public void Nhap()
            {
                int n;
                Console.Write("Nhap so luong so nguyen: ");
                n = int.Parse(Console.ReadLine());
                songuyen = new int[n];
                for(int  i = 0; i < songuyen.Length; i++)
                {
                    Console.Write("Nhap so nguyen thu " + (i + 1) + ": ");
                    songuyen[i] = int.Parse(Console.ReadLine());
                }
            }
            public int Min()
            {
                int min = songuyen[0];
                for (int i = 1; i < songuyen.Length; i++)
                { 
                    if (songuyen[i]  < min)
                    {
                        min = songuyen[i];
                    }
                }
                return min;
            }
        }

        class SoThuc
        {
            private double[] sothuc;
            public void Nhap()
            {
                int n;
                Console.Write("\r\nNhap so luong so thuc: ");
                n = int.Parse(Console.ReadLine());
                sothuc = new double[n];
                for (int j = 0; j < sothuc.Length; j++)
                {
                    Console.Write("Nhap so nguyen thu " + (j + 1) + ": ");
                    sothuc[j] = double.Parse(Console.ReadLine());
                }
            }
            public double Min()
            {
                double min = sothuc[0];
                for (int j = 1; j < sothuc.Length;j++)
                {
                    if(sothuc[j] < min )
                        min = sothuc[j];
                }
                return min;
            }
        }
        
        class Chuoi
        {
            private string[]array;
            public void Nhap()
            {
                int n;
                Console.Write("\r\nNhap so luong chuoi: ");
                n = int.Parse(Console.ReadLine());
                array = new string[n];
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("Nhap chuoi thu " + (i+1) + ": ");
                    array[i] = Console.ReadLine();
                }
            }

            public string Min()
            {
                string min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i].Length < min.Length)
                        min = array[i];
                }
                return min;
            }
        }

        
    static void Main(string[] args)
        {
            SoNguyen soNguyen = new SoNguyen();
            soNguyen.Nhap(); 
            int minNguyen = soNguyen.Min();
            
            SoThuc soThuc = new SoThuc();
            soThuc.Nhap();
            double minThuc = soThuc.Min();
            
            Chuoi chuoi = new Chuoi();
            chuoi.Nhap();
            string minChuoi = chuoi.Min();

            Console.WriteLine("So nho nhat trong 1 day so nguyen: " + minNguyen + "\r\n");
            Console.WriteLine("So nho nhat trong 1 day so thuc: " + minThuc + "\r\n");
            Console.WriteLine("Chuoi ngan nhat trong 1 day chuoi: " + minChuoi + "\r\n");

            Console.ReadLine();

        }
    }
}
