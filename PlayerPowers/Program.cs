using System;

namespace PlayerPowers
{
    
    class Program
    {
        //powers_for_players myPowers = powers_for_players.None;
        static void Main(string[] args)
        {
            Console.Write("Número de jogadores: ");
            int n = int.Parse(Console.Read());

            string [][] players = new string[n][3];

            powers_for_players

            for(int i = 0; i < players.Lenght; i++)
            {
                for (int j = 0; i < 3; j++)
                {
                    Console.WriteLine($"(Player {i + 1}) Enter a power: ");
                    pow = Console.ReadLine();

                    power_convert = (powers_for_players)Enum.Parse(typeof(powers_for_players), pow);

                    switch(pow)
                    {
                        case "Fly":

                            players[i][j] ^= power_convert.Fly;

                            break;

                        case "XRayVision":
                            players[i][j] ^= powers_for_players.XRayVision;
                            break;

                        case "SuperStrength":
                            players[i][j] ^= powers_for_players.SuperStrength;
                            break;

                        default:
                            Console.WriteLine("Power not found!");
                            break;

                    }

                }
                
                Console.WriteLine(players[i][j]);
                
            }










        }
    }
}
