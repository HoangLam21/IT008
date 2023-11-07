using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Program
    {

        class Int
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

            public int TimMin()
            {

                int min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                return min;

            }
        }

        class Float
        {
            private float[] arr;

            public void Nhap()
            {
                Console.WriteLine("Nhap so luong phan tu so thuc: ");
                int n = int.Parse(Console.ReadLine());
                arr = new float[n];

                for (int i = 0; i < n; i++)
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

            public float TimMin()
            {

                float min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                return min;

            }
        }

        class STring
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

            public string TimMin()
            {

                string min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length > min.Length)
                    {
                        min = arr[i];
                    }
                }
                return min;

            }
        }




        static void Main(string[] args)
        {

            Int maxInt = new Int();
            Int minInt = new Int();
            maxInt.Nhap();
            minInt.Nhap();
            int MaxSN = maxInt.TimMax();
            int MinSN = minInt.TimMin();


            Float maxFloat = new Float();
            Float minFloat = new Float();
            maxFloat.Nhap();
            minFloat.Nhap();
            float MaxST = maxFloat.TimMax();
            float MinST = minFloat.TimMin();


            STring maxString = new STring();
            STring minString = new STring();
            maxString.Nhap();
            minString.Nhap();
            string MaxS = maxString.TimMax();
            string MinS = minString.TimMin();




            Console.WriteLine("So lon nhat trong 1 day so nguyen: " + MaxSN + "\r\n");
            Console.WriteLine("So lon nhat trong 1 day so thuc: " + MaxST + "\r\n");
            Console.WriteLine("Chuoi lon nhat trong 1 day chuoi: " + MaxS + "\r\n");

            Console.WriteLine("So nho nhat trong 1 day so nguyen: " + MinSN + "\r\n");
            Console.WriteLine("So nho nhat trong 1 day so thuc: " + MinST + "\r\n");
            Console.WriteLine("Chuoi nho nhat trong 1 day chuoi: " + MinS + "\r\n");

        }

    }
}