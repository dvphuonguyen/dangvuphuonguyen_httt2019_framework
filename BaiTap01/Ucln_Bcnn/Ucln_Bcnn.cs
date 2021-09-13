using System;

namespace Ucln_Bcnn
{
    class Program
    {
        static int Ucln(int Number_1, int Number_2)
        {
            Number_1 = Math.Abs(Number_1);
            Number_2 = Math.Abs(Number_2);
            if(Number_1 == 0 || Number_2 == 0)
            {
                return 0;
            }
            else
            {
                while(Number_1 != Number_2)
                {
                    if(Number_1 > Number_2)
                    {
                        Number_1 -= Number_2;
                    }
                    else
                    {
                        Number_2 -= Number_1;
                    }
                }
                return Number_1;
            }
        }
        static int Bcnn(int Number_1, int Number_2)
        {
            return Number_1 * Number_2 / Ucln(Number_1, Number_2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu nhat: ");
            int Number_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thu hai: ");
            int Number_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Uoc chung lon nhat cua hai so: " + Ucln(Number_1, Number_2));
            if (Number_1 == 0 || Number_2 == 0)
            {
                Console.WriteLine("Boi chung nho nhat: loi");
            }
            else
            {
                Console.WriteLine("Boi chung nho nhat cua hai so: " + Bcnn(Number_1, Number_2));
            }
        }
    }
}
