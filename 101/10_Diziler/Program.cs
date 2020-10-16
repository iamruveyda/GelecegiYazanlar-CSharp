using System;

namespace _10_Diziler
{

    /*
     
         tip diziismi = new tip[elemansayisi];

tip:      Dizide tutulacak verilerin tipidir.
diziismi: Dizinin ismidir.
boyut:    Dizide tutulacak eleman sayısıdır.
         
         */
    class Program
    {
        static void Main(string[] args)
        {

            short[] futbolTakimi = new short[11];

            futbolTakimi[0] = 1;
            futbolTakimi[1] = 4;
            futbolTakimi[2] = 5;
            futbolTakimi[3] = 2;
            futbolTakimi[4] = 8;
            futbolTakimi[5] = 12;
            futbolTakimi[6] = 19;
            futbolTakimi[7] = 99;
            futbolTakimi[8] = 22;
            futbolTakimi[9] = 10;
            futbolTakimi[10] = 11;

            foreach (short futbolcu in futbolTakimi)
            {
                Console.WriteLine(futbolcu);
            }

            
            Console.WriteLine(" \n ##########################################################3############## \n");

            short[] futbolTakimi2 = { 1, 4, 5, 2, 8, 12, 19, 99, 22, 10, 11 };

            foreach (short futbolcu in futbolTakimi2)
            {
                Console.WriteLine(futbolcu);
            }


           
            Console.WriteLine(" \n ##########################################################3############## \n");

            /* Length: Bu metot, dizideki toplam eleman sayısını döndürür. */

            string[] isimler = new string[40];

            Console.WriteLine(isimler.Length);


            
          
            
            Console.WriteLine(" \n ##########################################################3############## \n");

            /*Clear: Bu metot, içine parametreler alarak, dizinin belirtilen alanındaki değerleri temizler.*/

            int[] dizi = { 50, 63, 64, 75 };

            //1. elemandan itibaren (63) siler
            Array.Clear(dizi, 1, 2);

            // Dizideki tüm elemanları siler
            Array.Clear(dizi, 0, dizi.Length);

          
           
            
            
            Console.WriteLine(" \n ##########################################################3############## \n");

            /* Reverse: Bu metot, dizi elemanlarının sıralamasını indeks sırasına göre tersine çevirir.*/

            string[] harfler = { "A", "B", "C" };
            Array.Reverse(harfler);
            Console.WriteLine(harfler[2]);

           
            
            
            
            Console.WriteLine(" \n ######################################################################## \n");

            /* Sort: Bu metot, dizi elemanlarını dizinin tipine bağlı olarak sıralar. */

            string[] harfler02 = { "C", "B", "A" };
            Array.Sort(harfler02);
            Console.WriteLine(harfler02[2]);

            
            
            
            
            Console.WriteLine(" \n ######################################################################## \n");

            /* IndexOf : Bu metot, dizi içindeki bir elemanın indeksini döndürür*/

            decimal[] sonuclar = { 78, 99, 100, 12 };
            decimal maksimum = 100;
            Console.WriteLine(Array.IndexOf(sonuclar, maksimum).ToString());


        }


    }
}