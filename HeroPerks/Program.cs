using System;

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

            foreach (char perkChar in user)
            {
                if (perkChar == 'w')
                    playerPerks ^= Perks.WaterBreathing;
                else i
                

            }

        }
    }
}
