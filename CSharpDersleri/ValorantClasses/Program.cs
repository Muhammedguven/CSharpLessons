using System;
using ValorantClasses.Models;

namespace ValorantClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Database veritabanım = new Database();
            
            while (true)
            {
                Menu();
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        veritabanım.SilahlariGoster();
                        break;
                    case "2":
                        veritabanım.HerolariGoster();
                        break;
                    case "3":
                        veritabanım.PlayerlariGoster();
                        break;
                }
            }
            

        }
       
        public static void Menu()
        {
            Console.WriteLine("********************");
            Console.WriteLine("1-Silahları Göster");
            Console.WriteLine("2-Heroları Göster");
            Console.WriteLine("3-Playerları Göster");
            Console.WriteLine("********************");
        }
    }
}
