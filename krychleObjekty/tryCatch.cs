using Spectre.Console;
namespace tryCatch
{
    public class vypocty
    {
        public static void Main()
        {
            var hodnoty = new char[10];
            bool cyklus = true;
            var list = new List<char>();
            var obsah=new List<string>();
            for (int i = 1; i <= 10; i++) obsah.Add($"{i}. index");
            obsah.Add("konec");
            obsah.Add("výpis");
            while (cyklus)
            {
                Console.Clear();
                var chari = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("vyber si index do kterého budeš vypisovat char")
                        .PageSize(10)
                        .MoreChoicesText("")
                        .AddChoices(obsah));
                if (chari== "konec")
                {
                    Console.WriteLine("cyklus končí");
                    cyklus = false;
                    break;
                }
                if(chari=="výpis")
                {
                    Console.WriteLine($"zadané hodnoty byly: {String.Join(",", hodnoty)}");
                    cyklus=false;
                    break;
                }
                char znaky = AnsiConsole.Ask<char>("zadej znak: ");
                int poziceZ=obsah.IndexOf(chari);
                obsah[poziceZ]=$"{poziceZ+1}.index={znaky}";
                hodnoty[poziceZ] = znaky;
            }
        }
    }
}