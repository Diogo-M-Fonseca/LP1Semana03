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

             switch (let)
             {
                case 'w': count1++; break;
                case 'a': count2++; break;
                case 's': count3++; break;
                case 'd': count4++; break;
             }
           }

        if (count1 % 2 != 0) playerPerks |= Perks.WarpShift;

        if (count2 % 2 != 0) playerPerks |= Perks.AutoHeal;

        if (count3 % 2 != 0) playerPerks |= Perks.Stealth;

        if (count4 % 2 != 0) playerPerks |= Perks.DoubleJump;

        if (playerPerks != 0)
        {
            Console.WriteLine(playerPerks);

            if((playerPerks & Perks.Stealth)!=0 & (playerPerks & Perks.DoubleJump)!=0)
            {
                Console.WriteLine("!Silent Jumper!");
            }

            if ((playerPerks & Perks.AutoHeal)== 0)
            {
                Console.WriteLine("!Not gonna make it!");
            }
        }
        else
        {
            Console.WriteLine("!No perks at all!");
            Console.WriteLine("!Not gonna make it!");
        }
        }
    }
}
