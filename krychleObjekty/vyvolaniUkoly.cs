using Spectre.Console;
string[] array=new string[] { "krychleObjekty", "metody","koleso","kalkulačka","tryCatch","projektKveten","knihovna", "test" , "nuda_projekt","age","EvolucePokemonu","Random Country" };
 var tabulkaSProjekty = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("vyber praci kterou chceš spustit")
        .PageSize(14)
        .MoreChoicesText("")
        .AddChoices(array));

switch(tabulkaSProjekty)
{
    case "knihovna":
        knihovna.all.Main();
        break;
    case "test":
        test.all.Main();
        break;
    case "krychleObjekty":
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
    case "nuda_projekt":
        nuda_projekt.all.Main();
        break;
    case "age":
        Age.all.Main();
        break;
    case "EvolucePokemonu":
        EvolucePokemonu.all.Main();
        break;
    case "Random Country":
        RandomCountry.all.Main();
        break;
}
//novy pc ve skole