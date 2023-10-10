using System;

namespace _1._2
{
    public class PhanSo : IComparable<PhanSo>
    {
        private int tu;
        private int mau;
        public int tuso
        {
            get { return tu; }
            set { tu = value; }
        }
        public int mauso
        {
            get { return mau; }
            set { mau = value; }
        }

        public PhanSo(int tu = 0, int mau = 1)
        {
            this.tu = tu;
            this.mau = mau;
        }
        public static int UCLN(int a, int b)
        {
            int m = Math.Abs(a);
            int n = Math.Abs(b);
            if (m == 0 && n == 0) return 1;
            if (m == 0 || n == 0) return m + n;
            while (m != n)
            {
                if (m > n)
                    m -= n;
                else
                    n -= m;
            }
            return m;
        }
        public void Nhap(string input)
        {
            tu = int.Parse(input.Split('/')[0]);
            mau = int.Parse(input.Split('/')[1]);
        }
        public void Xuat()
        {
            if (mau < -1)
                Console.Write("{0}/{1}", -tu, -mau);
            else if (mau == -1)
                Console.Write(-tu);
            else if (mau == 0)
                Console.Write("Cannot divide by 0.");
            else if (mau == 1)
                Console.Write(tu);
            else
                Console.Write("{0}/{1}", tu, mau);
        }
        public PhanSo RutGon()
        {
            int gcd = UCLN(tu, mau);
            tu /= gcd;
            mau /= gcd;
            return this;
        }

        //chuyển kiểu ngầm định từ số nguyên sang phân số
        public static implicit operator PhanSo(int value)
        {
            return new PhanSo(value, 1);
        }

        // Chuyển kiểu tường minh từ phân số ra số thực
        public static explicit operator double(PhanSo ps)
        {
            return (double)ps.tu / ps.mau;
        }


        // các hàm tính toán + - * / và các hàm so sánh == != > <
        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            return new PhanSo(ps1.tu * ps2.mau + ps2.tu * ps1.mau, ps1.mau * ps2.mau).RutGon();
        }
        public static PhanSo operator -(PhanSo ps)
        {
            return new PhanSo(-1 * ps.tu, ps.mau).RutGon();
        }
        public static PhanSo operator -(PhanSo ps1, PhanSo ps2)
        {
            return (ps1 + (-ps2)).RutGon();
        }
        public static PhanSo operator *(PhanSo ps1, PhanSo ps2)
        {
            return new PhanSo(ps1.tu * ps2.tu, ps1.mau * ps2.mau).RutGon();
        }
        public static PhanSo operator /(PhanSo ps1, PhanSo ps2)
        {
            return new PhanSo(ps1.tu * ps2.mau, ps1.mau * ps2.tu).RutGon();
        }
        public static bool operator ==(PhanSo ps1, PhanSo ps2)
        {
            if (ReferenceEquals(ps1, null) || ReferenceEquals(ps2, null))
                return false;
            return ps1.tu * ps2.mau == ps2.tu * ps1.mau;
        }
        public static bool operator !=(PhanSo ps1, PhanSo ps2)
        {
            return !(ps1 == ps2);
        }
        public static bool operator >(PhanSo ps1, PhanSo ps2)
        {
            return (ps1.tu * ps2.mau > ps1.mau * ps2.tu);
            //return ps1.CompareTo(ps2) > 0;
        }
        public static bool operator <(PhanSo ps1, PhanSo ps2)
        {
            return (ps1.tu * ps2.mau < ps1.mau * ps2.tu);
            //return ps1.CompareTo(ps2) < 0;
        }

        // cài đặt hàm CompareTo trong interface IComparable để test Array.Sort()
        public int CompareTo(PhanSo other)
        {
            double ps1 = (double)this;
            double ps2 = (double)other;
            return ps1.CompareTo(ps2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            PhanSo other = (PhanSo)obj;
            return tu * other.mau == other.tu * mau;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + tu.GetHashCode();
                hash = hash * 23 + mau.GetHashCode();
                return hash;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mang phan so (vd: 1/3 -1/3 22/4): ");
            string input = Console.ReadLine();
            string[] inputPS = input.Split(' ');
            PhanSo[] arrayPS = new PhanSo[inputPS.Length];
            for (int i = 0; i < arrayPS.Length; i++)
            {
                arrayPS[i] = new PhanSo();
                arrayPS[i].Nhap(inputPS[i]);
            }

            //test Array.Sort()
            Console.Write("Mang chua sap xep: ");
            foreach (PhanSo ps in arrayPS)
            {
                ps.Xuat();
                Console.Write("\t");
            }

            Array.Sort(arrayPS);
            Console.WriteLine();
            Console.Write("\nMang da sap xep: ");
            foreach (PhanSo ps in arrayPS)
            {
                ps.Xuat();
                Console.Write("\t");
            }

            Console.ReadLine();
        }
    }
}
