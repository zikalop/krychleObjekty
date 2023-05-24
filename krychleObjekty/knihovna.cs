using Spectre.Console;
namespace knihovna
{
    public class all
    {
        public class objekty
        {
            public static string inputA;
            public static int inputR;
            public static string inputJ;
            public static string input;
            /*public objekty(string autor,string year, int name)
            {
                inputA = autor;
                inputR = year;  
                inputJ = name;
            }*/
        }
        public class vice
        {
            public static bool cyklus = true;
        }
        public static void Main()
        {
            try
            {
                    while(vice.cyklus=true)
                    {
                        Console.WriteLine("Vítam Vás, zadejte následující informace o knize");
                        objekty.inputJ = AnsiConsole.Ask<string>("Jméno:");
                        string[] arrayJ = { objekty.inputJ};
                        objekty.inputR = AnsiConsole.Ask<int>("Rok:");
                        int[] arrayR = {objekty.inputR};
                        objekty.inputA = AnsiConsole.Ask<string>("Autor(zapisuj bez mezer):");
                        string[] arrayA = { objekty.inputA};
                        Console.WriteLine("Chceš zobrazit vše nebo přidávat dále?(z/p)");
                        objekty.input = Console.ReadLine();
                        switch(objekty.input)
                        {
                            case "z":
                            Console.Clear();    
                            AnsiConsole.MarkupLine("[purple]Vypsané informace jsou:[/]");
                                    foreach (string j in arrayJ)
                                    {
                                        Console.WriteLine(j);
                                    }
                                    foreach (int r in arrayR)
                                    {
                                        Console.WriteLine(r);
                                    }
                                    foreach(string a in arrayA)
                                    {
                                        Console.WriteLine(a);
                                    }
                            Console.ReadKey();    
                            Console.Clear();
                            break;
                    }
                    Console.Clear();
                }
            }
            catch(Exception)
            {
                AnsiConsole.MarkupLine("[red]Invalid input[/]");
            }
        }
    }
}                     