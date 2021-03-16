using System;

namespace EnBuyukSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            //üç değişken tanımla a=20 b=10 c=15 büyükten küçüğe sıralayan uygulama
            //örnek: a sayısını giriniz b sayısını giriniz    c sayısını giriniz en büyük sayı b sayısı

            int a = 20;
            int b = 30;
            int c = 45;

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(a + " sayısı en büyük sayı");
                }
                else
                {
                    Console.WriteLine(c + " sayısı en büyük sayı");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine(b + " sayısı en büyük sayı");
                }
                else
                {
                    Console.WriteLine(c + " sayısı en büyük sayı");
                }
            }
        }
    }
}
