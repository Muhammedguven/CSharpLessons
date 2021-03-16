using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //Login işlemi

            string username = "ibrahim";
            string sifre = "123";
            int girisHakki = 3;
            while (true)
            {
                if (girisHakki == 0)
                {
                    Console.WriteLine("Hesabınız kitlenmiştir");
                    break;
                }
                Console.WriteLine("Kullanıcı adınızı giriniz:");
                string girilenKullaniciAdi = Console.ReadLine();
                Console.WriteLine("Şifrenizi giriniz:");
                string girilenSifre = Console.ReadLine();

                if (girilenKullaniciAdi == username && girilenSifre == sifre)
                {
                    Console.WriteLine("Hoşgeldiniz");
                    break;
                }
                else if (girilenKullaniciAdi == username && girilenSifre != sifre)
                {
                    Console.WriteLine("Şifreniz Yanlış");
                }
                else if (girilenKullaniciAdi != username && girilenSifre == sifre)
                {
                    Console.WriteLine("Kullanıcı adınız Yanlış");
                }
                else
                {
                    Console.WriteLine("Hatalı bilgiler");
                }
                girisHakki -= 1;
                Console.WriteLine(girisHakki + " hakkınız kaldı");

            }
        }
}
