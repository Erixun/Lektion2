using System;

namespace IFLabLektion2
{
    class Program
    {

        /// <summary>
        /// försök stoppa de för klaseen mest frekventa/förklarande metoderna längst upp
        /// </summary>
        static bool CanIBuyBeer(int age, string location, decimal promille, string leg)
        {
            //bool canBuyBeer = false;

            if (leg == "J" && promille < 1.0m)
            {
                if (location == "krogen" && age > 17)
                {
                    return true;//canBuyBeer = true;
                }
                else if (location == "systemet" && age > 19)
                {
                    return true;// canBuyBeer = true;
                }
            }
            return false;//canBuyBeer;
        }
        static void Main(string[] args)
        {
            //OM ålder > 17 OCH location == "krogen" OCH OM leg == "J" OCH OM promille < 1.0 JA
            //OM ålder > 19 OCH location == "systemet" OCH OM leg == "J" OCH OM promille < 1.0 JA
            Console.WriteLine("Hur gammal är du?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Location (systemet/krogen): ");
            string location = Console.ReadLine().ToLower();

            Console.WriteLine("Har du leg (J/N)?");
            string leg = Console.ReadLine().ToUpper();

            Console.WriteLine("Ange din promillehalt: ");
            decimal promille = decimal.Parse(Console.ReadLine());

            bool canBuyBeer = CanIBuyBeer(age, location, promille, leg);//false;

            //if (leg == "J" && promille < 1.0m)
            //{
            //    if (location == "krogen" && age > 17)
            //    {
            //        canBuyBeer = true;
            //    }
            //    else if (location == "systemet" && age > 19)
            //    {
            //        canBuyBeer = true;
            //    }
            //    else
            //    {
            //        canBuyBeer = false;
            //    }
            //}
            if (canBuyBeer)
            {
                Console.WriteLine("Du får köpa öl");
            }

            //nästla if-satser...
            if (age > 17 && location == "krogen" && leg == "J" && promille < 1.0m) 
                Console.WriteLine("Japp du får köpa öl.");
            else if (age > 19 && location == "systemet" && leg == "J" && promille < 1.0m)
                Console.WriteLine("Japp du får köpa öl.");
            else
                Console.WriteLine($"Nejnej ingen öl för dig, eftersom " +
                    $"{(leg != "J"? "du saknar leg" : promille >= 1.0m? "din promillehalt är för hög" : age < 17? "du är för ung": "du är på fel plats" )}"); //ange orsak...


            //en bra programmerare... skriver läsbar kod, svårläst kod kostar pengar
            //bra kod är enkel kod, handlar inte om att skriva så "snitsigt/tekniskt/modernt/fiffigt" som möjligt 
        }
    }
}
