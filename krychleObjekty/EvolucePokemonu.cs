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
                    var pokemoni = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                        .Title("Vyber si element pokemona")
                        .PageSize(10)
                        .MoreChoicesText("")
                        .AddChoices("[blue]Voda[/]", "[red]Oheň[/]", "[green]Země[/]", "[yellow]Elektřina[/]"));
                    switch (pokemoni)
                    {
                        case "[blue]Voda[/]":
                            vice.pokemonName = "squirtle";
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
                            vice.pokemonName = "charmander";
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
                            vice.pokemonName = "bulbasaur";
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
                            vice.pokemonName = "pikachu";
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
                    AnsiConsole.MarkupLine("[grey]Kochej se svým pokemonem [/]" + vice.pokemonName+ "[grey] času máš dost[/]");
                    AnsiConsole.MarkupLine("[grey][/]");
                    AnsiConsole.MarkupLine("[grey]Psssst.... klikni pro pokračnování[/]");
                    Console.ReadKey();
                    Console.Clear();
                    var x = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                            .Title("Chceš pokračovat nebo chceš kód ukončit?")
                            .PageSize(10)
                            .MoreChoicesText("")
                            .AddChoices("[green]Ano[/]","[red]Ne[/]"));

                    switch (x)
                    {
                        case "ano":
                            Console.WriteLine("Klikni pro pokračovaní kódu");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        case "ne":
                            Console.WriteLine("kód končí");
                            cycle = false;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Špatný intput");
            }
        }
    }
}

