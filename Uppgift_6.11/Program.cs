using System;
namespace Uppgift_6_11
{
    class Program
    {
        static void Main(string[] args)
        {
            RitaKvadrat(4, 'A');
            RitaKvadrat(3, 'B', 2);
        }
        /// <summary>
        /// Ritar en kvadrat med angivna parametrar
        /// </summary>
        /// <param name="sidLängd">Hur lång kvadratens sida ska vara</param>
        /// <param name="tecken">VIlket tecken kvadraten ska vara gjord av</param>
        /// <param name="mellanrum">Hur stort mellanrum det ska vara mellan varje tecken</param>
        static void RitaKvadrat(int sidLängd, char tecken, int mellanrum = 0)
        {
            for (int i = 0; i < sidLängd; i++) //Rader
            {
                for (int j = 0; j < sidLängd; j++) //Tecken i rad
                {
                    Console.Write(tecken);

                    for (int k = 0; k < mellanrum; k++) //Mellanrum i rad
                    {
                        Console.Write(' ');
                    }
                }

                if (i != sidLängd - 1)
                {
                    for (int j = 0; j < mellanrum; j++) //mellarum mellan rader
                    {
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
            }
        }
    }
}