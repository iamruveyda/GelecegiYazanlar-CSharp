using System;

namespace _11_Metot
{
    class Program
    {

        /*
         
             DönüşTipi değişkenAdı;

değişkenAdı = metot();
*/
        static void Main(string[] args)
        {
            Random rasgele = new Random();
            int sayi;
            sayi = rasgele.Next(1, 101);
            
            Console.WriteLine(sayi);


            Console.WriteLine(" \n ##########################################################3############## \n");

            int sayi01 = 5;

            Console.WriteLine(KareAl(sayi01));


        }


        static int KareAl(int sayi)
        {
            int sonuc;
            sonuc = sayi * sayi;
            return sonuc;
        }

    }
}
