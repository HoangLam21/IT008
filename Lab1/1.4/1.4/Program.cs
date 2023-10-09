using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperature
{
    public delegate void ThayDoiNhietDo(float NhietDo);
    public class NhietKe
    {
        public event ThayDoiNhietDo NhietDoThayDoi;
        private float nhietdo;

        public float NhietDo
        {
            get { return this.nhietdo; }
            set { this.nhietdo = value; }
        }
        public NhietKe(float NhietDoBanDau = 0)
        {
            this.nhietdo = NhietDoBanDau;
        }
        public void updateNhietDo()
        {
            Random randomnd = new Random();
            float nhietdomoi = (float)randomnd.NextDouble() * 100;
            if (nhietdomoi != this.nhietdo)
            {
                this.nhietdo = nhietdomoi;
                NhietDoThayDoi?.Invoke(nhietdomoi);

            }

        }
    }
    class ManHinhHienThiNhietDo
    {
        public void DKNhanThongBaoSuKienThayDoiNhietDo(NhietKe nhietke)
        {
            nhietke.NhietDoThayDoi += Nhietke_NhietDoThayDoi;
        }
        public void HuyDKNhanThongBaoSuKienThayDoiNhietDo(NhietKe nhietke)
        {
            nhietke.NhietDoThayDoi -= Nhietke_NhietDoThayDoi;
        }
        private void Nhietke_NhietDoThayDoi(float NhietDo)
        {
            Console.WriteLine($"Nhiet do moi la: {NhietDo} do C ");
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            NhietKe nhietke = new NhietKe();
            Console.WriteLine($"Nhiet do ban dau la: {nhietke.NhietDo} do C");
            ManHinhHienThiNhietDo manhinhhienthinhietdo = new ManHinhHienThiNhietDo();
            manhinhhienthinhietdo.DKNhanThongBaoSuKienThayDoiNhietDo(nhietke);
            do
            {
                nhietke.updateNhietDo();
                Console.WriteLine("nhan Enter de tiep tuc, nhan 0 de ket thuc ");
            } while (Console.ReadLine() != "0");
            manhinhhienthinhietdo.HuyDKNhanThongBaoSuKienThayDoiNhietDo(nhietke);
            //Console.ReadLine();
        }
    }
}
