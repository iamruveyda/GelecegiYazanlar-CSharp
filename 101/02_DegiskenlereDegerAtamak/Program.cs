using System;

namespace _02_DegiskenlereDegerAtamak
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Eğer bir tam sayı değişken oluşturulacaksa, o veri tipini (int) kullanarak tanım yapmak gerekmektedir.
             
             */
            int a;
            int b;

            a = 10;
            b = a;

            Console.WriteLine("a: {0} b: {1}", a, b);     

            int c = 20;

            string isim = "Turkcell Geleceği Yazanlar";

            Console.WriteLine("c: {0} isim: {1}", c, isim);

            isim = "Yeni Değer";

            Console.WriteLine("isim: {0}", isim);


            /*
             * Programın akışı içerisinde hangi tipte olacağı, hangi değerin atanması gerektiği belirsiz ya da programcı, 
             * değişken tipinin C# tarafından atanmasını isteyebilir.
             * Bu tür değişkenlere ise Implicit değişken denilmektedir ve var anahtar kelimesi ile ifade edilir.

             */

            var num01= 20;

            Console.WriteLine("num: {0}", num01);

            var isim01 = "Turkcell";

            Console.WriteLine("isim01: {0}", isim01);


            var sayi = 10;
            Console.WriteLine(sayi.GetType());

        }
    }
}

/*
 
     Kaynak: https://gelecegiyazanlar.turkcell.com.tr/konu/c-sharp/egitim/c-101/degiskenlere-deger-atamak
     
     
     */
