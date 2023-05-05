using Spectre.Console;
string[] array=new string[] { "krychle", "metody","koleso","kalkulačka","tryCatch","projektKveten" };
 var tabulky = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("string s otázkou nebo nadpis")
        .PageSize(14)
        .MoreChoicesText("")
        .AddChoices(array));

switch(tabulky)
{
    case "krychle":
        krychleObjekty.Vypocty.hlavniVypocet();
        break;
    case "metody":
        ukolMetody.neivm.Main();
        break;
    case "koleso":
        koleso.everithing.Main();
        break;
    case "kalkulačka":
        kalkulacka.ucenie.Main();
        break;
    case "tryCatch":
        tryCatch.vypocty.Main();
        break;
    case "projektKveten":
        projektKveten.all.Inventory.Main();
        break;
}