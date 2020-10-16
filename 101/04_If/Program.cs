using System;

namespace _04_If
{
    class Program
    {
        static void Main(string[] args)
        {

            //IF-ELSE

            Console.Write("Parolayı Giriniz: ");

            string parola01 = Console.ReadLine();


            if (parola01 == "1234")
            {
                Console.WriteLine("Parola doğru");
            }
            else
            {
                Console.WriteLine("Girilen parola doğru değil");
            }

            Console.WriteLine("\n ################################### \n");

            /*
             
             Burada if deyiminde VE (&&) operatörü ile iki koşulun da true (doğru) olması durumunda giriş doğrulanır.

             */

            Console.Write("Kullanıcı Adını Giriniz: ");

            string kullaniciAdi01 = Console.ReadLine();

            Console.Write("Parolayı Giriniz: ");

            string parola02 = Console.ReadLine();

            if (kullaniciAdi01 == "admin" && parola02 == "1234")
            {
                Console.WriteLine("Kullanıcı Adı ve Parola Doğru");
            }
            else
            {
                Console.WriteLine("Girilen Kullanıcı Adı veya Parola Doğru Değil");

            }


            Console.WriteLine("\n ################################### \n");

            //İç içe if

            Console.Write("Kullanıcı Adını Giriniz: ");

            string kullaniciAdi02 = Console.ReadLine();

            Console.Write("Parolayı Giriniz: ");

            string parola03 = Console.ReadLine();

            if (kullaniciAdi02 == "admin")
            {
                if (parola03 == "123456")
                {
                    Console.WriteLine("Kullanıcı Adı ve Parola Doğru");
                }
                else
                {
                    Console.WriteLine("Girilen Parola Doğru Değil");
                }
            }
            else
            {
                Console.WriteLine("Girilen Kullanıcı Adı Doğru Değil");
            }


            Console.WriteLine("\n ################################### \n");


            Console.Write("1den 12e kadar sayı giriniz: ");

            byte ay = Convert.ToByte(Console.ReadLine());

            if (ay == 1)
                Console.WriteLine("Ocak");
            else if (ay == 2)
                Console.WriteLine("Şubat");
            else if (ay == 3)
                Console.WriteLine("Mart");
            else if (ay == 4)
                Console.WriteLine("Nisan");
            else if (ay == 5)
                Console.WriteLine("Mayıs");
            else if (ay == 6)
                Console.WriteLine("Haziran");
            else if (ay == 7)
                Console.WriteLine("Temmuz");
            else if (ay == 8)
                Console.WriteLine("Ağustos");
            else if (ay == 9)
                Console.WriteLine("Eylül");
            else if (ay == 10)
                Console.WriteLine("Ekim");
            else if (ay == 11)
                Console.WriteLine("Kasım");
            else if (ay == 12)
                Console.WriteLine("Aralık");
            else
                Console.WriteLine("1-12 arası sayı girmelisiniz");

        }
    }
}

/*
Kaynak: https://gelecegiyazanlar.turkcell.com.tr/konu/c-sharp/egitim/c-101/if-deyimi

    */