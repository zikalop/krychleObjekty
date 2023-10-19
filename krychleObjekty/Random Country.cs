using Spectre.Console;
using static System.Net.Mime.MediaTypeNames;

namespace RandomCountry
{
    
    public static class all
    {
        public static class objekty
        {
            public static string obsah_textaku = File.ReadAllText("text.txt");
            public static string volba;
            public static string volbaz;
            public static string letterR;
            public static int volba1=0;
            public static int volba2=0;

        }
        public static void Main()
        {
            var rgb = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Vyber si kterou [red]ba[/][green]r[/][blue]vou[/] chceš vidět text")
                    .PageSize(10)
                    .MoreChoicesText("")
                    .AddChoices("[red]R[/]","[green]G[/]","[blue]B[/]"));

            switch (rgb)
            {
                case "[red]R[/]":
                    all.Red();
                    break;
                case "[green]G[/]":
                    all.Green();
                    break; 
                case "[blue]B[/]":
                    all.Blue();
                    break;
            }


        }
        public static void pZem()
        {
            string file = @"C:\Users\vojtech.zika\Documents\GitHub\krychleObjekty\krychleObjekty\text.txt";
            string[] radky = File.ReadAllLines(file);
            Console.WriteLine("Zadej zemi kterou chceš najít(napiš 1. písmeno)");
            string HPismeno = Console.ReadLine();
            AnsiConsole.MarkupLine("[red]---------[/][white]------------[/][blue]---------[/]");
            foreach (string pZeme in radky)
            {
                if (pZeme.StartsWith(HPismeno.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    
                    AnsiConsole.MarkupLine($"[red]{pZeme}[/]");
                }
            }
            AnsiConsole.MarkupLine("[red]---------[/][white]------------[/][blue]---------[/]");
        }

        public static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            string[] zeme = objekty.obsah_textaku.Split(new[] { "\n" }, StringSplitOptions.None);
            List<string> seznam_zemi = zeme.ToList();

            foreach (string jednaZeme in seznam_zemi)
            {
                Console.WriteLine($"--- ZEMĚ ---");
                Console.WriteLine(jednaZeme);
            }

            Console.WriteLine("chcete vygenerovat náhodnou zemi y/n");
            objekty.volba = Console.ReadLine();
            if (objekty.volba == "y")
            {
                Random generator = new Random();
                Console.WriteLine("zadej Range z kterýho budou země generovaný \n1.");
                objekty.volba1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2.");
                objekty.volba2 = int.Parse(Console.ReadLine());
                int nahodnaPozice = generator.Next(objekty.volba1, objekty.volba2);
                Console.WriteLine(seznam_zemi[nahodnaPozice]);
            }
            else if (objekty.volba == "n")
            {
                Console.WriteLine("kk jdem na další krok");
            }
            all.pZem();
        }

        public static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            string[] zeme = objekty.obsah_textaku.Split(new[] { "\n" }, StringSplitOptions.None);
            List<string> seznam_zemi = zeme.ToList();

            foreach (string jednaZeme in seznam_zemi)
            {
                Console.WriteLine($"--- ZEMĚ ---");
                Console.WriteLine(jednaZeme);
            }

            Console.WriteLine("chcete vygenerovat náhodnou zemi y/n");
            objekty.volba = Console.ReadLine();
            if (objekty.volba == "y")
            {
                Random generator = new Random();
                Console.WriteLine("zadej Range z kterýho budou země generovaný \n1.");
                objekty.volba1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2.");
                objekty.volba2 = int.Parse(Console.ReadLine());
                int nahodnaPozice = generator.Next(objekty.volba1, objekty.volba2);
                Console.WriteLine(seznam_zemi[nahodnaPozice]);
            }
            else if (objekty.volba == "n")
            {
                Console.WriteLine("kk končim");
            }
            all.pZem();
        }

        public static void Blue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string[] zeme = objekty.obsah_textaku.Split(new[] { "\n" }, StringSplitOptions.None);
            List<string> seznam_zemi = zeme.ToList();

            foreach (string jednaZeme in seznam_zemi)
            {
                //jednaZeme.TrimEnd();
                Console.WriteLine($"--- ZEMĚ ---");
                Console.WriteLine(jednaZeme);
            }

            Console.WriteLine("chcete vygenerovat náhodnou zemi y/n");
            objekty.volba = Console.ReadLine();
            if (objekty.volba == "y")
            {
                Random generator = new Random();
                Console.WriteLine("zadej Range z kterýho budou země generovaný \n1.");
                objekty.volba1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2.");
                objekty.volba2 = int.Parse(Console.ReadLine());
                int nahodnaPozice = generator.Next(objekty.volba1, objekty.volba2);
                Console.WriteLine(seznam_zemi[nahodnaPozice]);
            }
            else if (objekty.volba == "n")
            {
                Console.WriteLine("kk končim");
            }
            all.pZem();
        }
    }
}        