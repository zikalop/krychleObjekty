using Spectre.Console;
namespace test
{
    class all
    {
    public static void Main()
        {
            /*Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Vítejte v bance :)");
            Console.ForegroundColor = ConsoleColor.DarkGray;*/
            var vyber3 = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("chcet spořit nebo si vzít půjčku")
                .PageSize(10)
                .MoreChoicesText("")
                .AddChoices("spořit", "půjčku"));
            if (vyber3 == "spořit")
            {
                sporeni();
            }
            else if (vyber3 == "půjčku")
            {
                splatky();
            }

        }
        public static void sporeni()
        {

            try
            {
                var vyberDelku = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("jak dlouho chcete spořit?")
                    .PageSize(10)
                    .MoreChoicesText("vybírej šipkamy")
                    .AddChoices("5 let", "10 let", "15 let"));

                Console.WriteLine("zadej počáteční částku");
                double Vklad = double.Parse(Console.ReadLine());
                switch (Vklad)
                {
                    case 15000000:
                    default:
                        throw new Exception();
                        break;

                }

                Console.WriteLine("chceš dávat měsíční vklad?(ano/ne)");
                string Rozhodnuti = Console.ReadLine();
                double VkladMesic = 0;
                if (Rozhodnuti == "ano")
                {
                    Console.WriteLine("zadej měsíční vklad");
                    VkladMesic = double.Parse(Console.ReadLine());
                }

                double x = 0;
                double y = 0;
                double z = 0;
                switch (vyberDelku)
                {
                    case "5 let":
                        x = (12 * 5) * VkladMesic;//60 měsíců
                        vyberDelku = "5 letech";
                        break;
                    case "10 let":
                        y = (12 * 10) * VkladMesic;//120 měsíců
                        vyberDelku = "10 letech";
                        break;
                    case "15 let":
                        z = (12 * 15) * VkladMesic; // 180 měsíců
                        vyberDelku = "15 letech";
                        break;
                }
                Console.WriteLine("zapiš procentrní úrok(0%-100%)");
                double Urok = double.Parse(Console.ReadLine());
                // UrokUkazka = Urok * 100;

                double vypocet = 0;
                double finalvypocet = 0;
                switch (vyberDelku)
                {
                    case "5 letech":
                        vypocet = x;
                        finalvypocet = vypocet * Urok;
                        break;
                    case "10 letech":
                        vypocet = y;
                        finalvypocet = vypocet * Urok;
                        break;
                    case "15 letech":
                        vypocet = z;
                        finalvypocet = vypocet * Urok;
                        break;
                }

                double KonecnaSplatka = finalvypocet;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"finální uspořená částka s vkladem {Vklad}, mesíčním vkladem {VkladMesic} a úrokem {Urok}% je po {vyberDelku} {KonecnaSplatka}kč");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception chyba)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Špatný input");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public static void splatky()
        {
            try
            {
                Console.WriteLine("zadej hodnotu pujčky");
                double P = double.Parse(Console.ReadLine());

                var roky = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("vyber si delku splácení")
                    .PageSize(10)
                    .MoreChoicesText("")
                    .AddChoices("1 rok", "2 roky", "4 roky"));
                double n = 0;
                double mesicSplatka = 0;
                double i = (double)0.4167;
                switch (roky)
                {
                    case "1 rok":
                        n = 1;
                        mesicSplatka = ((P * i * 1) / 100);
                        break;
                    case "2 roky":
                        n = 2;
                        mesicSplatka = ((P * i * 2) / 100);
                        break;
                    case "4 roky":
                        n = 4;
                        mesicSplatka = ((P * i * 4) / 100);
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"celkem zaplatíte: {Math.Round(P + mesicSplatka * n, 0)}kč a měsíčně budete splácet {Math.Round(mesicSplatka, 0)}kč");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Špatný input");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

}