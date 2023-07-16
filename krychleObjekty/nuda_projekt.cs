using Spectre.Console;

namespace nuda_projekt
{
    public class all
    {
        public static class objekty
        {
            public static int udaniH;
            public static double vypocetR;
            public static int udaniC;
            public static string rozhodnuti;
        }

        public static void Main()
        {
            try
            {
                Console.WriteLine("zadej ryhclost(kmh/h)");
                objekty.udaniH = int.Parse(Console.ReadLine())*1000;
                
                Console.Write("chceš zadat vteřiny nebo hodiny?(v/H): ");
                objekty.rozhodnuti = Console.ReadLine();
                
                if(objekty.rozhodnuti=="h")
                {
                    Console.WriteLine("zadej časový úsek, který bude vynásoben rychlostí km/h a zjistíš kolik si ujel za X času");
                    objekty.udaniC= int.Parse(Console.ReadLine()); 
                }
                else if(objekty.rozhodnuti=="v")
                {
                    Console.WriteLine("zadej časový úsek, který bude vynásoben rychlostí km/h a zjistíš kolik si ujel za X času");
                    objekty.udaniC = int.Parse(Console.ReadLine())*60;
                }
                else { Console.WriteLine("Špatný input"); }
                
                objekty.vypocetR=(objekty.udaniH*objekty.udaniC)/3600;
                Math.Round(objekty.vypocetR, 1);
                Console.WriteLine($"výsledek je {objekty.vypocetR}km");
            }
            catch (Exception)
            {
                Console.WriteLine("Špatný input");
            }
        }

    }
}
