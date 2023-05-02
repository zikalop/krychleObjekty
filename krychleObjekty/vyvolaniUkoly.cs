using Spectre.Console;
string[] array=new string[] { "krychle", "metody","koleso","kalkulačka"};
 var tabulky = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("string s otázkou nebo nadpis")
        .PageSize(14)
        .MoreChoicesText("")
        .AddChoices(array));

switch(tabulky)
{
    case "krychle":
        krychleObjekty.Vypocty.hlavniVypocet();//první úkol s třídami
        break;
    case "metody":
        ukolMetody.neivm.Main();//druhý ukol s třídami
        break;
    case "koleso":
        koleso.everithing.Main();//třetí úkol s třídami
        break;
    case "kalkulačka":
        kalkulacka.ucenie.Main();//čtvrtý úkol s třídami
        break;
}