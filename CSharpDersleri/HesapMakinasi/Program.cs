using System;

namespace HesapMakinasi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Menu();

            }

        }

        public static void Menu()
        {
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.WriteLine("5- Çıkış");
            Console.WriteLine("İşlem Seçiniz :");
            int Secim = Convert.ToInt32(Console.ReadLine());
            if (Secim == 5)
            {
                Console.Clear();
                Console.WriteLine("Çıkış yapılıyor..");
                Environment.Exit(0);
            }
            Console.WriteLine("1.SAYIYI GİRİNİZ:");
            int Sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.SAYIYI GİRİNİZ:");
            int Sayi2 = Convert.ToInt32(Console.ReadLine());

            switch (Secim)
            {
                case 1:
                    Console.WriteLine("Toplama işlemi sonucu = " + Toplama(Sayi1, Sayi2));
                    break;
                case 2:
                    Console.WriteLine("Çıkarma işlemi sonucu = " + Cikarma(Sayi1, Sayi2));
                    break;
                case 3:
                    Console.WriteLine("Carpma islemi sonucu = " + Carpma(Sayi1, Sayi2));
                    break;
                case 4:
                    Console.WriteLine("Bölme işlemi sonucu = " + Bolme(Sayi1, Sayi2));
                    break;
            }
            Console.WriteLine("Sayfayı temizlemek için bir tuşa basınız");

            Console.ReadLine();
            Console.Clear();
        }

        public static int Toplama(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public static int Cikarma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            return sonuc;
        }
        public static int Carpma(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public static double Bolme(int sayi1, int sayi2)
        {
            double sonuc = Convert.ToDouble(sayi1) / Convert.ToDouble(sayi2);
            return sonuc;
        }

    }
}
