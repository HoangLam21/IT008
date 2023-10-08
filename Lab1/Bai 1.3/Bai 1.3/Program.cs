﻿using System;
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

        class MaxInt
        {
            private int[] arr;

            public void Nhap()
            {
                Console.WriteLine("Nhap so luong phan tu so nguyen: ");
                int n = int.Parse(Console.ReadLine());
                arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap vao gia tri phan tu thu {0}: ", i + 1);
                    arr[i] = int.Parse(Console.ReadLine());
                }
            }

            public int TimMax()
            {

                int max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                return max;

            }
        }

        class MaxFloat
        {
            private float[] arr;

            public void Nhap()
            {
                Console.WriteLine("Nhap so luong phan tu so thuc: ");
                int n = int.Parse(Console.ReadLine());
                arr = new float[n];

                for (int i = 0; i <n; i++)
                {
                    Console.WriteLine("Nhap vao gia tri phan tu thu {0}: ", i + 1);
                    arr[i] = float.Parse(Console.ReadLine());
                }
            }

            public float TimMax()
            {
                float max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                return max;

            }
        }

        class MaxSTring        
        {
            private string[] arr;

            public void Nhap()
            {
                Console.WriteLine("Nhap so luong phan tu chuoi: ");
                int n = int.Parse(Console.ReadLine());
                arr = new string[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nhap vao gia tri phan tu thu {0}: ", i + 1);
                    arr[i] = Console.ReadLine();
                }
            }

            public string TimMax()
            {
                string max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length > max.Length)
                    {
                        max = arr[i];
                    }
                }
                return max;

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
        
            MaxInt maxInt=new MaxInt();
            maxInt.Nhap();
            int MaxSN= maxInt.TimMax();

            MaxFloat maxFloat = new MaxFloat();
            maxFloat.Nhap();
            float MaxST = maxFloat.TimMax();

            MaxSTring maxString = new MaxSTring();
            maxString.Nhap();
            string MaxS = maxString.TimMax();

            Console.WriteLine("So nho nhat trong 1 day so nguyen: " + minNguyen + "\r\n");
            Console.WriteLine("So nho nhat trong 1 day so thuc: " + minThuc + "\r\n");
            Console.WriteLine("Chuoi ngan nhat trong 1 day chuoi: " + minChuoi + "\r\n");

            Console.WriteLine("So lon nhat trong 1 day so nguyen: " + MaxSN + "\r\n");
            Console.WriteLine("So lon nhat trong 1 day so thuc: " + MaxST + "\r\n");
            Console.WriteLine("Chuoi lon nhat trong 1 day chuoi: " + MaxS + "\r\n");

            Console.ReadLine();

        }
    }
}
