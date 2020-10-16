using System;

namespace _08_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
           
            int sayac = 0;

            do
            {
                sayac++;
                toplam += sayac;
            }
            while (sayac < 100);

            Console.WriteLine("Toplam: " + toplam.ToString() + ",Sayaç: " + sayac.ToString());
        }
    }
}


/*
 
     Kaynak: https://gelecegiyazanlar.turkcell.com.tr/konu/c-sharp/egitim/c-101/do-while-dongusu
     
     */
