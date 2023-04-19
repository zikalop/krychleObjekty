using Spectre.Console;
string[] array=new string[] { "krychle", "metody"};
 var tabulky = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("string s otázkou nebo nadpis")
        .PageSize(14)
        .MoreChoicesText("")
        .AddChoices(array));

switch(tabulky)
{
    case "krychle":
        krychleObjekty.Vypocty.hlavniVypocet();//první úkol s třídamy
        break;
    case "metody":
        ukolMetody.neivm.Main();//druhý ukol s třídamy
        break;
}