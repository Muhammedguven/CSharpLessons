using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int hesap = 1000;

            Console.WriteLine("Hoşgeldiniz");
            Console.WriteLine("************************");

            Console.WriteLine("1 - Bakiye Görüntüle");
            Console.WriteLine("2 - Para Çek");
            Console.WriteLine("3 - Para Yatır");
            Console.WriteLine("4 - Çıkış");
            Console.WriteLine("************************");
            while (true)
            {
                Console.WriteLine("Bir işlem seçiniz");
                int islem = Convert.ToInt32(Console.ReadLine());

                switch (islem)
                {
                    case 1:
                        Console.WriteLine(hesap + " TL paranız bulunmaktadır");
                        break;
                    case 2:
                        Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                        int cekilenPara = Convert.ToInt32(Console.ReadLine());
                        if (cekilenPara > hesap)
                        {
                            Console.WriteLine("O kadar paranız yok");
                            break;
                        }
                        hesap = hesap - cekilenPara;
                        Console.WriteLine(cekilenPara + " TL para çektiniz");
                        Console.WriteLine(hesap + "TL paranız hesabınızda kaldı");
                        break;
                    case 3:
                        Console.WriteLine("Yatırmak istediğiniz tutarı giriniz:");
                        int yatirilanPara = Convert.ToInt32(Console.ReadLine());
                        hesap += yatirilanPara;
                        Console.WriteLine(yatirilanPara + " TL kadar para yatırdınız ");
                        Console.WriteLine(hesap + "TL paranız hesabınızda oldu");
                        break;
                    case 4:
                        Console.WriteLine("Çıkış yapılıyor iyi günler dileriz!!!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Hatalı bir işlem seçtiniz");
                        break;

                }
            }
    }
}
