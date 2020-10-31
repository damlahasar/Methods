using System;

namespace Example3
{
    class Program
    {
        private static double NotHesaplama(int vize, int final)
        {
            double ortalama = (vize * 0.4 + final * 0.6);
            return ortalama;
        }

        static void Main(string[] args)
        {
            Console.Write("Vize Notunuzu Giriniz: ");
            int vize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final Notunuzu Giriniz: ");
            int final = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ortalamanız: ");
            Console.WriteLine(NotHesaplama(vize, final));
            Console.ReadKey();
        }
    }
}
