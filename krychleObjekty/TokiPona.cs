using Spectre.Console;

namespace TokiPona
{
    public static class all
    {
        public static void tokiP()
        {
            AnsiConsole.MarkupLine(@"[green]        ,----,                                                                                 
      ,/   .`|                                   ,-.----.                                      
    ,`   .'  :              ,-.                  \    /  \                                     
  ;    ;     /          ,--/ /|   ,--,           |   :    \                                    
.'___,/    ,'  ,---.  ,--. :/ | ,--.'|           |   |  .\ :   ,---.        ,---,              
|    :     |  '   ,'\ :  : ' /  |  |,            .   :  |: |  '   ,'\   ,-+-. /  |             
;    |.';  ; /   /   ||  '  /   `--'_            |   |   \ : /   /   | ,--.'|'   |  ,--.--.    
`----'  |  |.   ; ,. :'  |  :   ,' ,'|           |   : .   /.   ; ,. :|   |  ,""' | /       \   
    '   :  ;'   | |: :|  |   \  '  | |           ;   | |`-' '   | |: :|   | /  | |.--.  .-. |  
    |   |  ''   | .; :'  : |. \ |  | :           |   | ;    '   | .; :|   | |  | | \__\/: . .  
    '   :  ||   :    ||  | ' \ \'  : |__         :   ' |    |   :    ||   | |  |/  ,"" .--.; |  
    ;   |.'  \   \  / '  : |--' |  | '.'|        :   : :     \   \  / |   | |--'  /  /  ,.  |  
    '---'     `----'  ;  |,'    ;  :    ;        |   | :      `----'  |   |/     ;  :   .'   \ 
                      '--'      |  ,   /         `---'.|              '---'      |  ,     .-./ 
                                 ---`-'            `---`                          `--`---'     
                                                                                               [/]");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
        }
        
        public static void Main()
        {
            Dictionary<string, string> slovnik_toki = new Dictionary<string, string>();
            bool cycle = true;
            tokiP();
            while (cycle= true)
            {               
                Console.WriteLine("zadej 1. věc a pak 2.(při třetim stisknutí je mozno zmáčknout k jako konec)");
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                ConsoleKeyInfo input3 = Console.ReadKey();
                char inputC='i';
                slovnik_toki.Add(input1, input2);
                switch(inputC)
                {
                    case 'k' or 'K':
                        break;
                }
                
                Console.Clear();
                tokiP();
            }
            var tabule = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Vyber si:")
                    .PageSize(10)
                    .MoreChoicesText("")
                    .AddChoices("Zobrazit vyplněné hodnoty"));            
            switch (tabule)
            {
                case "Zobrazit vyplněné hodnoty":
                    foreach (KeyValuePair<string, string> s in slovnik_toki)
                    {
                        Console.WriteLine(s);
                    }
                    break;
            }
        }
    }
}