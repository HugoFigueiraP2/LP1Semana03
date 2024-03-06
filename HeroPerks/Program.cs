using System;
using System.Linq;

namespace HeroPerks
{
    class Program
    {
        [Flags]
        enum Perks
        {
            None = 0,
            WaterBreathing = 1 << 0,
            Stealth = 1 << 1,
            AutoHeal = 1 << 2,
            DoubleJump = 1 << 3
        }
        static void Main(string[] args)
        {
            string user = args[0];
            Perks playerPerks = Perks.None;

            int count_w = 0;
            int count_a = 0;
            int count_s = 0;
            int count_d = 0;
            foreach (char perkChar in user)
            {
                if (perkChar == 'w')
                {
                    playerPerks ^= Perks.WaterBreathing;
                    ++count_w;
                }
                    
                else if (perkChar == 'a')
                {
                    playerPerks ^= Perks.Stealth;
                    ++count_a;
                }

                else if (perkChar == 's')
                {
                    playerPerks ^= Perks.AutoHeal;
                    ++count_s;
                }
                else if (perkChar == 'd')
                {
                    playerPerks ^= Perks.DoubleJump;
                    ++count_d;
                }
                else
                {
                    Console.WriteLine("Unknown perk!");
                    return;
                }
            }

            if (count_w % 2 != 0)
            {
                Console.Write(Perks.WaterBreathing + ", ");
            }

            if (count_a % 2 != 0)
            {
                Console.Write(Perks.Stealth + ", ");
            }

            if (count_s % 2 != 0)
            {
                Console.Write(Perks.AutoHeal + ", ");
            }

            if (count_d % 2 != 0)
            {
                Console.Write(Perks.DoubleJump + ", ");
            }

            Console.WriteLine();


            if (playerPerks == Perks.None)
            {
                Console.WriteLine("No perks at all!");
                Console.WriteLine("Not gonna make it!");
            }
            else
            {
                if ((playerPerks & (Perks.Stealth | Perks.DoubleJump)) == (Perks.Stealth | Perks.DoubleJump))
                {
                    Console.WriteLine("Silent jumper");
                }

                if ((playerPerks & Perks.AutoHeal) == 0)
                {
                    Console.WriteLine("Not gonna make it!");
                }

            }


            
           

        }
    }
}
