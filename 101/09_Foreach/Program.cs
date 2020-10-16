using System;

namespace _09_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 1, 2, 3, 4, 5, 6 };

            int carpim = 1;
            
            foreach (int x in sayilar)
            {
                carpim = carpim * x;
            }
        }
    }
}

/*
 
     Kaynak: https://gelecegiyazanlar.turkcell.com.tr/konu/c-sharp/egitim/c-101/foreach-dongusu
     
     */
