using Spectre.Console;

namespace animal
{
    public static class all
    {
        public static class objekty
        {
            public static bool cycle = true;
            public static Dictionary<string, string> atributyZ = new Dictionary<string, string>();

        }
        public static void Main()
        {
           

            while (objekty.cycle)
            {
                var tabule = AnsiConsole.Prompt(
                 new SelectionPrompt<string>()
                     .Title("Co chceš dělat?")
                     .PageSize(10)
                     .MoreChoicesText("")
                     .AddChoices("1. Přidat zvíře", "2. Odebrat zvíře", "3. Upravit zvíře", "4. Vypsat zvířata", "0. Ukončit program"));
                

                switch (tabule)
                {
                    case "1. Přidat zvíře":
                        string input1 = Console.ReadLine();
                        string input2 = Console.ReadLine();
                        objekty.atributyZ.Add(input1, input2);
                        Console.Clear();
                        break;
                    case "2. Odebrat zvíře":
                        odebrani();
                        break;
                    case "3. Upravit zvíře":
                        break;
                    case "4. Vypsat zvířata":
                        Console.WriteLine("Zvířata:");
                        foreach (KeyValuePair<string, string> s in objekty.atributyZ)
                        {
                            Console.WriteLine(s);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "0. Ukončit program":
                        break;
                }
            }
        }
        public static void odebrani()
        {
            List<string> values = new();
            foreach (KeyValuePair<string, string> s in objekty.atributyZ)
            {
                values.Add($"{s.Key} {s.Value}");//pridá "s" do listu "values"
            }
            var tabule = AnsiConsole.Prompt(
                 new SelectionPrompt<string>()
                     .Title("Co chceš odebrat?")
                     .PageSize(10)
                     .MoreChoicesText("")
                     .AddChoices(values));
            objekty.atributyZ.Remove(tabule);
            Console.Clear();
        }
    }
}