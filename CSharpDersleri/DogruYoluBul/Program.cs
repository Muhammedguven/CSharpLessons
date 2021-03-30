using System;

namespace DogruYoluBul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oyunun amacı bitiş noktasına ulaşmak. Sağ-Sol dan birisini seç doğru yolu bul");
            IlkKavsak();
            IkinciKavsak();
            UcuncuKavsak();
        }
        public static void IlkKavsak()
        {
            string secim = Console.ReadLine();
            if (secim == "sağ")
            {
                Console.WriteLine("Doğru tarafı seçtiniz devamm..");
            }
            else if(secim == "sol")
            {
                Console.WriteLine("Uçurumdan düştünüz");
            }
            else
            {
                Console.WriteLine("Hatalı bir yön seçtiniz. Tekrar seçiniz");
            }
        }
        public static void IkinciKavsak()
        {
            string secim = Console.ReadLine();
            if (secim == "sol")
            {
                Console.WriteLine("Doğru tarafı seçtiniz devamm..");
            }
            else if (secim == "sağ")
            {
                Console.WriteLine("Uçurumdan düştünüz");
            }
            else
            {
                Console.WriteLine("Hatalı bir yön seçtiniz. Tekrar seçiniz");
            }
        }
        public static void UcuncuKavsak()
        {
            string secim = Console.ReadLine();
            if (secim == "sol")
            {
                Console.WriteLine("Doğru tarafı seçtiniz devamm..");
            }
            else if (secim == "sağ")
            {
                Console.WriteLine("Uçurumdan düştünüz");
            }
            else
            {
                Console.WriteLine("Hatalı bir yön seçtiniz. Tekrar seçiniz");
            }
        }
    }
}
