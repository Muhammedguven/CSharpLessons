using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ValorantClasses.Models;

namespace ValorantClasses
{
    public class Database
    {
        //List<Part> parts = new List<Part>();
        List<Gun> guns = new List<Gun>();
        List<Hero> heros = new List<Hero>();
        List<Insan> players = new List<Insan>();
        public Database()//contstructor --> yapıcı --İlk çalışacak alan
        {
            guns.Add(new Gun() { GunName = "Spectre", Bullets = 32, Color = "Red" });
            guns.Add(new Gun() { GunName = "Vandal", Bullets = 30, Color = "Blue" });
            heros.Add(new Hero() { HeroName = "JETT", HeroSkin = "FESTİVAL", Skill1 = "Görüş Kısıtlama", Skill2 = "İleri Uçma" });
            heros.Add(new Hero() { HeroName = "SAGE", HeroSkin = "UÇAN SKİN", Skill1 = "Can Basma", Skill2 = "Yeniden Doğurma" });
            players.Add(new Insan() { Id = 1839, UserName = "selamkoc", Coin = 0 });
            players.Add(new Insan() { Id = 1534, UserName = "Kolaj", Coin = 50 });
        }
        public void SilahlariGoster()
        {
            Console.WriteLine("Silah Sayısı :" + guns.Count());
            foreach (var silah in guns)
            {
                Console.WriteLine("Silah Adı : " + silah.GunName);
                Console.WriteLine("Mermi Sayısı : " + silah.Bullets);
                Console.WriteLine("Silah Rengi : " + silah.Color);
            }
        }
        public void HerolariGoster()
        {
            Console.WriteLine("Hero Sayısı : " + heros.Count());
            foreach (var kahraman in heros)
            {
                Console.WriteLine("Kahraman Adı : " + kahraman.HeroName);
                Console.WriteLine("Kahraman Skini : "+ kahraman.HeroSkin);
                Console.WriteLine("Kahraman Özelliği 1 : " + kahraman.Skill1);
                Console.WriteLine("Kahraman Özelliği 2 : " + kahraman.Skill2);
            }
        }
        public void PlayerlariGoster()
        {
            Console.WriteLine("Player Sayısı : " + players.Count());
            foreach (var oyuncu in players)
            {
                Console.WriteLine("Player Id : " + oyuncu.Id);
                Console.WriteLine("Player Kullanıcı Adı : " + oyuncu.UserName);
                Console.WriteLine("Player Coini : " + oyuncu.Coin);
            }
        }


    }
}
