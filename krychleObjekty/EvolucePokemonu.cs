using Spectre.Console;

namespace EvolucePokemonu
{
    public class all
    {
        public class vice
        {
            public static string pokemonName;
            //public static List<string> nameP=new List<string>();
        }
        public static void Main()
        {
            try
            {
                bool cycle = true;
                while (cycle)
                {
                    Console.Clear();
                    var pokemoni = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                        .Title("Vyber si element pokemona")
                        .PageSize(10)
                        .MoreChoicesText("")
                        .AddChoices("[blue]Voda[/]", "[red]Oheň[/]", "[green]Země[/]", "[yellow]Elektřina[/]"));
                    switch (pokemoni)
                    {
                        case "[blue]Voda[/]":
                            vice.pokemonName = "Squirtle";
                            Console.WriteLine(@"
                ,-'            ""`-.
              ,'                   `-.
            ,'                        \
          ,'                           .
          .'\               ,"""".       `
         ._.'|             / |  `       \
         |   |            `-.'  ||       `.
         |   |            '-._,'||       | \
         .`.,'             `..,'.'       , |`-.
         l                       .'`.  _/  |   `.
         `-.._'-   ,          _ _'   -"" \  .     `
    `.""""""""""'-.`-...,---------','         `. `....__.
    .'        `""-..___      __,'\          \  \     \
    \_ .          |   `""""""""'    `.           . \     \
      `.          |              `.          |  .     L
        `.        |`--...________.'.        j   |     |
          `._    .'      |          `.     .|   ,     |
             `--,\       .            `7""""' |  ,      |
                ` `      `            /     |  |      |    _,-'""""""`-.
                 \ `.     .          /      |  '      |  ,'          `.
                  \  v.__  .        '       .   \    /| /              \
                   \/    `""""\""""""""""""""`.       \   \  /.''                |
                    `        .        `._ ___,j.  `/ .-       ,---.     |
                    ,`-.      \         .""     `.  |/        j     `    |
                   /    `.     \       /         \ /         |     /    j
                  |       `-.   7-.._ .          |""          '         /
                  |          `./_    `|          |            .     _,'
                  `.           / `----|          |-............`---'
                    \          \      |          |
                   ,'           )     `.         |
                    7____,,..--'      /          |
                                      `---.__,--.'");
                            break;
                        case "[red]Oheň[/]":
                            vice.pokemonName = "Charmander";
                            Console.WriteLine(@"
                 _.--""""`-..
                ,'          `.
              ,'          __  `.
             /|          "" __   \
            , |           / |.   .
            |,'          !_.'|   |
          ,'             '   |   |
         /              |`--'|   |
        |                `---'   |
         .   ,                   |                       ,"".
          ._     '           _'  |                    , ' \ `
      `.. `.`-...___,...---""""    |       __,.        ,`""   L,|
      |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \
    -:..     `. `-..--_.,.<       `""      / `.        `-/ |   .
      `,         """"""""'     `.              ,'         |   |  ',,
        `.      '            '            /          '    |'. |/
          `.   |              \       _,-'           |       ''
            `._'               \   '""\                .      |
               |                '     \                `._  ,'
               |                 '     \                 .'|
               |                 .      \                | |
               |                 |       L              ,' |
               `                 |       |             /   '
                \                |       |           ,'   /
              ,' \               |  _.._ ,-..___,..-'    ,'
             /     .             .      `!             ,j'
            /       `.          /        .           .'/
           .          `.       /         |        _.'.'
            `.          7`'---'          |------""'_.'
           _,.`,_     _'                ,''-----""'
       _,-_    '       `.     .'      ,\
       -"" /`.         _,'     | _  _  _.|
        """"--'---""""""""""'        `' '! |! /
                                `"" "" -' ");
                            break;
                        case "[green]Země[/]":
                            vice.pokemonName = "Bulbasaur";
                            Console.WriteLine(@"/
                            _,.------....___,.' ',.-.
                         ,-'          _,.--""        |
                       ,'         _.-'              .
                      /   ,     ,'                   `
                     .   /     /                     ``.
                     |  |     .                       \.\
           ____      |___._.  |       __               \ `.
         .'    `---""""       ``""-.--""'`  \               .  \
        .  ,            __               `              |   .
        `,'         ,-""'  .               \             |    L
       ,'          '    _.'                -._          /    |
      ,`-.    ,"".   `--'                      >.      ,'     |
     . .'\'   `-'       __    ,  ,-.         /  `.__.-      ,'
     ||:, .           ,'  ;  /  / \ `        `.    .      .'/
     j|:D  \          `--'  ' ,'_  . .         `.__, \   , /
    / L:_  |                 .  ""' :_;                `.'.'
    .    """"'                  """"""""""'                    V
     `.                                 .    `.   _,..  `
       `,_   .    .                _,-'/    .. `,'   __  `
        ) \`._        ___....----""'  ,'   .'  \ |   '  \  .
       /   `. ""`-.--""'         _,' ,'     `---' |    `./  |
      .   _  `""""'--.._____..--""   ,             '         |
      | ."" `. `-.                /-.           /          ,
      | `._.'    `,_            ;  /         ,'          .
     .'          /| `-.        . ,'         ,           ,
     '-.__ __ _,','    '`-..___;-...__   ,.'\ ____.___.'
     `""^--'..'   '-`-^-'""--    `-^-'`.''""""""""""`.,^.`.--'");
                            break;
                        case "[yellow]Elektřina[/]":
                            vice.pokemonName = "Pikachu";
                            Console.WriteLine(@"quu..__
     $$$b  `---.__
      ""$$b        `--.                          ___.---uuudP
       `$$b           `.__.------.__     __.---'      $$$$""              .
         ""$b          -'            `-.-'            $$$""              .'|
           "".                                       d$""             _.'  |
             `.   /                              ...""             .'     |
               `./                           ..::-'            _.'       |
                /                         .:::-'            .-'         .'
               :                          ::''\          _.'            |
              .' .-.             .-.           `.      .'               |
              : /'$$|           .@""$\           `.   .'              _.-'
             .'|$u$$|          |$$,$$|           |  <            _.-'
             | `:$$:'          :$$$$$:           `.  `.       .-'
             :                  `""--'             |    `-.     \
            :##.       ==             .###.       `.      `.    `\
            |##:                      :###:        |        >     >
            |#'     `..'`..'          `###'        x:      /     /
             \                                   xXX|     /    ./
              \                                xXXX'|    /   ./
              /`-.                                  `.  /   /
             :    `-  ...........,                   | /  .'
             |         ``:::::::'       .            |<    `.
             |             ```          |           x| \ `.:``.
             |                         .'    /'   xXX|  `:`M`M':.
             |    |                    ;    /:' xXXX'|  -'MMMMM:'
             `.  .'                   :    /:'       |-'MMMM.-'
              |  |                   .'   /'        .'MMM.-'
              `'`'                   :  ,'          |MMM<
                |                     `'            |tbap\
                 \                                  :MM.-'
                  \                 |              .''
                   \.               `.            /
                    /     .:::::::.. :           /
                   |     .:::::::::::`.         /
                   |   .:::------------\       /
                  /   .''               >::'  /
                  `',:                 :    .'
                                       `:.:'");
                            break;


                    }
                    switch (vice.pokemonName)
                    {
                        case "Squirtle":
                            AnsiConsole.Markup($"[blue]Kochej se svým pokemonem {vice.pokemonName} času máš dost[/]"); 
                            break;
                        case "Charmander":
                            AnsiConsole.Markup($"[red]Kochej se svým pokemonem {vice.pokemonName} času máš dost[/]");
                            break;
                        case "Bulbasaur":
                            AnsiConsole.Markup($"[green]Kochej se svým pokemonem {vice.pokemonName} času máš dost[/]");
                            break;
                        case "Pikachu":
                            AnsiConsole.Markup($"[yellow]Kochej se svým pokemonem {vice.pokemonName} času máš dost[/]");
                            break;
                    }
                    Console.WriteLine();
                    AnsiConsole.MarkupLine("[grey]Psssst.... klikni pro pokračnování[/]");
                    Console.ReadKey();
                    Console.Clear();
                    var x = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                            .Title("Chceš pokračovat?")
                            .PageSize(10)
                            .MoreChoicesText("")
                            .AddChoices("[green]Ano[/]", "[red]Ne[/]"));

                    switch (x)
                    {
                        case "[green]Ano[/]":
                            /*Console.WriteLine("Klikni pro pokračovaní kódu");
                            Console.ReadKey();*/
                            Console.Clear();
                            cycle = true;
                            break;
                        case "[red]Ne[/]":
                            Console.WriteLine("kód končí");
                            cycle = false;
                            break;
                    }
                }
            }
            catch (Exception chybaa)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(chybaa);
            }
        }
    }
}

