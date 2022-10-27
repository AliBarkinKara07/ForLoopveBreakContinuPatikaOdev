using System;
using System.Linq.Expressions;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i < sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            int tektoplam = 0;
            int cifttoplam = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 2 == 1)
                    tektoplam += i;
                else
                    cifttoplam += i;
            }
            Console.WriteLine("TekToplam:" + tektoplam);
            Console.WriteLine("Çift Toplam:" + cifttoplam);
        }
    }
}
