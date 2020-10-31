using System;

namespace Sample1
{
    class Program
    {
        private static int Buyuksayi(int sayi1, int sayi2)

        {

            if (sayi1 > sayi2)

                return sayi1;

            else if (sayi2 > sayi1)

                return sayi2;

            else

                return sayi1;

        }

        static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Giriniz: ");
            int s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Girdiğiniz Sayılar Arasında En Büyük Olan Sayı: ");
            Console.Write(Buyuksayi(s1, s2));

            Console.ReadKey();
        }
    }
}
