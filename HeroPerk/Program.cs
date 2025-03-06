using System;
using HeroPerks;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
           string perk = args[0].Trim().ToLower();

           Perks playerPerks = 0;

           int count1 =0;
           int count2 =0;
           int count3 =0;
           int count4 =0;

           foreach (char let in perk)
           {
             if (let != 'w' && let != 'a' && let != 's' && let != 'd')
             {
                Console.WriteLine("!Unknown perk!");
             }
           }

        }
    }
}
