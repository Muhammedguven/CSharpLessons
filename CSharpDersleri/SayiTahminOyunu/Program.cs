using System;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayı tahmin oyunu
            int tahmin = 0;
            int hafiza;
            int sayac = 0;
            Random rastgeleSayi = new Random();
            hafiza = rastgeleSayi.Next(1, 100);
            while (tahmin != hafiza)
            {
                sayac++;
                Console.WriteLine("Sayı giriniz:");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > hafiza)
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz:");
                }
                else if (tahmin < hafiza)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz:");
                }
                else if (tahmin == hafiza)
                {
                    Console.WriteLine("Tebrikler. Doğru sayıyı buldunuz!!! " + sayac + ". adımda buldunuz");

                }
            }
        }
    }
}
