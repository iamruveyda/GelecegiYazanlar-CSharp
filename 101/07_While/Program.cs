using System;

namespace _07_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int i = 0;

            while (i < 100)
            {
                toplam += i;
                i++;
            }

            Console.WriteLine(toplam);

            Console.WriteLine(" \n ########################### \n");

            Console.Write("Sayı Giriniz: ");

            int sayi = Convert.ToInt32(Console.ReadLine());
            int basamak = 0;

            while (sayi > 0)
            {
                basamak++;
                sayi = sayi / 10;
            }

            Console.WriteLine("Girdiğiniz sayı " + basamak.ToString() + " basamaklıdır.");



        }
    }
}


/*
 
     Kaynak: https://gelecegiyazanlar.turkcell.com.tr/konu/c-sharp/egitim/c-101/while-dongusu
     
     
     */
