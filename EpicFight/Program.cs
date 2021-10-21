using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            hero = RandomHero();
            villain = RandomVillain();
            Console.WriteLine($"Random hero: {hero}");
            Console.WriteLine($"Random villain: {villain}");
        }
        private static string RandomHero()
        {
            string[] heroes = { "Batman", "Spongebob", "Spiderman", "Patric", "Lara Croft" };
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, heroes.Length);
            string randomHero = heroes[RandomIndex];
            return randomHero;
            Console.WriteLine($"Computer chose random hero be {randomHero}");
        }
        private static string RandomVillain()
        {
            string[] villains = { "Emme", "Issi", "Vanaema" };
            Random rnd = new Random();
            int RandomIndex = rnd.Next(0, villains.Length);
            string randomVillain = villains[RandomIndex];
            return randomVillain;
        }
    }
}
