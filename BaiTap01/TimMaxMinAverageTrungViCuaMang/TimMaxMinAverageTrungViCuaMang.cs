using System;
using System.Collections.Generic;

namespace TimMaxMinAverageTrungViCuaMang
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr_int = new List<int>();
            Console.WriteLine("Nhap so luong phan tu mang: ");
            int soLuong = int.Parse(Console.ReadLine());
            for(int i = 0; i < soLuong; i++)
            {
                Console.WriteLine("Nhap phan tu thu " + i);
                arr_int.Add(int.Parse(Console.ReadLine()));
            }
            int max_arr = arr_int[0];
            for(int i = 1; i < soLuong; i++)
            {
                if(max_arr < arr_int[i])
                {
                    max_arr = arr_int[i];
                }
            }
            int min_arr = arr_int[0];
            for (int i = 1; i < soLuong; i++)
            {
                if (min_arr > arr_int[i])
                {
                    min_arr = arr_int[i];
                }
            }
            int sum_arr = 0;
            for(int i = 0; i < soLuong; i++)
            {
                sum_arr += arr_int[i];
            }
            arr_int.Sort();
            float trung_vi;
            Console.WriteLine(string.Join(", ", arr_int));
            if (soLuong % 2 == 1)
            {
                trung_vi = arr_int[(soLuong - 1) / 2];
            }
            else
            {
                trung_vi = (float)(arr_int[(int)((float)soLuong/2 - 0.5)] + arr_int[(int)((float)soLuong / 2 + 0.5)]) / 2;
            }
            Console.WriteLine("Gia tri lon nhat: "+ max_arr);
            Console.WriteLine("Gia tri nho nhat: "+ min_arr);
            Console.WriteLine("Gia tri trung binh: " + (float)sum_arr/ soLuong);
            Console.WriteLine("Gia tri trung vi: "+ trung_vi);
        }
    }
}
