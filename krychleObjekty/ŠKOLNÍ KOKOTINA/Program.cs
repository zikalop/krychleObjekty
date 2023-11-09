using Animal;

bool programIsRunning = true;
ServiceAnimal serviceAnimal = new ServiceAnimal();
while (programIsRunning)
{
    Console.WriteLine("1. Přidat zvíře");
    Console.WriteLine("2. Odebrat zvíře");
    Console.WriteLine("3. Upravit zvíře");
    Console.WriteLine("4. Vypsat zvířata");
    Console.WriteLine("5. Ukončit program");

    Console.WriteLine("Co si přeješ vykonat?");
    Console.ReadLine();
}