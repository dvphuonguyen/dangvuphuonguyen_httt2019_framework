using System;

namespace SoChinhPhuong
{
    class Program
    {
        static int SoChinhPhuong(int soNguyen)
        {
             if (soNguyen == 0 || soNguyen == 1){
                return 1;
            }
            else if (soNguyen > 1)
            {
                double _sqrt = Math.Sqrt(soNguyen);
                if(_sqrt*_sqrt == soNguyen)
                {
                    return 1;
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so bat ky: ");
            int soNguyen = int.Parse(Console.ReadLine());
            if (SoChinhPhuong(soNguyen)==1)
            {
                Console.WriteLine(soNguyen + " la so chinh phuong");
            }
            else
            {
                Console.WriteLine(soNguyen + " khong la so chinh phuong");
            }
        }
    }
}
