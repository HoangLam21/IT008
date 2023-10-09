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
            
            MaxInt maxInt = new MaxInt();
            maxInt.Nhap();
            int MaxSN = maxInt.TimMax();

            MaxFloat maxFloat = new MaxFloat();
            maxFloat.Nhap();
            float MaxST = maxFloat.TimMax();

            MaxSTring maxString = new MaxSTring();
            maxString.Nhap();
            string MaxS = maxString.TimMax();


            Console.WriteLine("So lon nhat trong 1 day so nguyen: " + MaxSN + "\r\n");
            Console.WriteLine("So lon nhat trong 1 day so thuc: " + MaxST + "\r\n");
            Console.WriteLine("Chuoi lon nhat trong 1 day chuoi: " + MaxS + "\r\n");

        }

    }
}
