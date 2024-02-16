using Spectre.Console;

namespace JP
{
    public class all
    {
        public class obj
        {

        }

        public static void Main()
        {
            var tabule = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Co chceš vybrat?")
                    .PageSize(10)
                    .MoreChoicesText("")
                    .AddChoices("Slovník","Časové údaje", "Slovesa", "Pozdravy", "První setkání"));

        }
        public static void slovník()
        {

        }
        
        public static void časU()
        {
            string[] čSlova = {"Ototoi",};
        }

        public static void slovesa()
        {

        }

        public static void pozdravy()
        {

        }

        public static void prvníS()
        {

        }
    }
}