using Spectre.Console;
namespace objektyKrychle
{
    class Vypocty
    {
        public class Kvadr
        {
            public int StranaA { get; set; }
            public int StranaB { get; set; }
            public int StranaC { get; set; }

            public Kvadr(int a, int b, int c)
            {
                StranaA = a;
                StranaB = b;
                StranaC = c;
            }


            public double objem()
            {
                return StranaA * StranaB * StranaC;
            }

            public double povrch()
            {
                return 2 * (StranaA * StranaB + StranaA * StranaC + StranaB * StranaC);
            }
            public double tUhlopricka()
            {
                int T_odmocnina = StranaA * StranaA + StranaB * StranaB + StranaC * StranaC;
                return Math.Sqrt(T_odmocnina);
            }
            public double sUhlopricka()
            {
                int S_odmocnina = StranaA * StranaA + StranaB * StranaB;
                return Math.Sqrt(S_odmocnina);
            }
        }

        public static void hlavniVypocet()
        {
            var tabulkaVypoctu = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                .Title("vyber si výpočet")
                .PageSize(4)
                .MoreChoicesText("[grey]šipkamy vybírej[/]")
                .AddChoices("Povrch", "Objem", "Tělesná úhlopříčka", "Stěnová úhlopříčka"));
            Console.WriteLine("zadej hodnoty stran");
            int hodnota1 = int.Parse(Console.ReadLine());
            int hodnota2 = int.Parse(Console.ReadLine());
            int hodnota3 = int.Parse(Console.ReadLine());
            var kvadr = new Kvadr(hodnota1, hodnota2, hodnota3);

            switch (tabulkaVypoctu)
            {
                case "Povrch":
                    Console.WriteLine($"Povrch se rovná: {kvadr.povrch()}");
                    break;
                case "Objem":
                    Console.WriteLine($"Objem se rovná: {kvadr.objem()}");
                    break;
                case "Tělesná úhlopříčka":
                    Console.WriteLine($"Tělesová úhlopříčka se rovná: {kvadr.tUhlopricka()}");
                    break;
                case "Stěnová úhlopříčka":
                    Console.WriteLine($"Stěnová úhlopříčka se rovná: {kvadr.sUhlopricka}");
                    break;
            }
        }
    }
}