using System;
using System.Collections.Generic;

namespace TinhCanChi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> thien_can = new List<string>();
            thien_can.Add("Canh");
            thien_can.Add("Tan");
            thien_can.Add("Nham");
            thien_can.Add("Quy");
            thien_can.Add("Giap");
            thien_can.Add("At");
            thien_can.Add("Binh");
            thien_can.Add("Dinh");
            thien_can.Add("Mau");
            thien_can.Add("Ky");
            List<string> dia_chi = new List<string>();
            dia_chi.Add("Than");
            dia_chi.Add("Dau");
            dia_chi.Add("Tuat");
            dia_chi.Add("Hoi");
            dia_chi.Add("Ty_s");
            dia_chi.Add("Suu");
            dia_chi.Add("Dan");
            dia_chi.Add("Mao");
            dia_chi.Add("Thin");
            dia_chi.Add("Ty_j");
            dia_chi.Add("Ngo");
            dia_chi.Add("Mui");
            Console.WriteLine("Nhap nam sinh: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int tc = year % 10;
            int dc = year % 12;
            Console.WriteLine("Can chi theo nam sinh "+ year + "la: "+ thien_can[tc] + " "+ dia_chi[dc]); 
        }
    }
}
