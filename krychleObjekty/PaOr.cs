using Spectre.Console;

namespace PaOr
{
    public static class all
    {
        public static class objekty
        {
            public static int rand;
            public static string answer;
            public static string pannaOrel;
            public static int vysledekH=0;
            public static int vysledekP = 0;
        }
        public static void PaOr()
        {
            objekty.rand = new Random().Next(0, 2);
            if(objekty.rand == 0 ) 
            {
                objekty.pannaOrel = "orel";
            }
            else if (objekty.rand == 1)
            {
                objekty.pannaOrel = "panna";
            }
            //Console.WriteLine(objekty.rand);
        }
        public static void Main()
        {
           for(int i = 0; i < 10; i++)
            {              
                PaOr();
                AnsiConsole.MarkupLine($"[purple]Vítej v {i+1}. kole [/]");
                AnsiConsole.MarkupLine("[purple]--------------------------------[/]");
                Console.WriteLine("Hádej jestli padla Panna nebo Orel");
                objekty.answer = Console.ReadLine();
                if (objekty.answer == objekty.pannaOrel)
                {
                    objekty.vysledekH++;
                    AnsiConsole.MarkupLine("[green]uhod jsi ----- 1 bod pro tebe[/]");
                }
                else
                {
                    objekty.vysledekP++;
                    AnsiConsole.MarkupLine(@"[red]█▄░█ █░█ █░█   █░█ █░█
█░▀█ █▄█ █▀█   █▄█ █▀█[/]");
                }
                AnsiConsole.MarkupLine("[gray]Hej... klikni pro pokračování[/]");
                Console.ReadKey();
                Console.Clear();
            }


            var tabule = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("[purple]Vyber akci[/]")
                    .PageSize(10)
                    .MoreChoicesText("")
                    .AddChoices("Výsledná tabule","KONEC"));
            switch(tabule)
            {
                case "Výsledná tabule":
                    AnsiConsole.MarkupLine("[purple]!!!VÝSLEDKY!!![/]");
                    AnsiConsole.MarkupLine($"[purple]Hráč: {objekty.vysledekH}[/]");
                    AnsiConsole.MarkupLine($"[purple]PC: {objekty.vysledekP}[/]");
                    break;
                case "KONEC":
                    Console.Clear();
                    Console.WriteLine("KONEC");
                    break;
            }
        }
    }
}