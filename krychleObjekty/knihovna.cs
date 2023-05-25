using Spectre.Console;
namespace knihovna
{
    public class all
    {
        public class objekty
        {
            public static string inputA;
            public static int inputR;
            public static string inputJK;
            public static char input;
            //public static char input2;
            public static List<kniha> Knihy=new List<kniha>();
            public static bool cyklus = true;
            public static char rozhodnuti;
            public static string hledani;
        }
        public class kniha
        {
            public kniha(string autor, int rok, string jmeno)
            {
                this.autor = autor;
                this.rok = rok;
                this.jmeno = jmeno;
            }

            public string autor;
            public int rok;
            public string jmeno;

        }
        public class metody
        {
            public static void Hledani()
            {

                Console.WriteLine("Chceš hledat podle názvu knihy nebo autora?(k/a)");
                objekty.rozhodnuti = Char.Parse(Console.ReadLine());
                switch (objekty.rozhodnuti)
                {
                    case 'k':
                        Console.WriteLine("zadej název knihy, kterou chceš najít");
                        objekty.hledani = Console.ReadLine();
                        if (objekty.hledani == objekty.inputJK) 
                            {                   
                                Console.WriteLine(objekty.inputJK);
                                Console.WriteLine("hotovo");
                            }
                        break;
                    case 'a':
                        Console.WriteLine("zadej název autora, podle kterého chceš hledat");
                        objekty.hledani = Console.ReadLine();
                            if (objekty.hledani == objekty.inputA)
                            {
                                Console.WriteLine(objekty.inputA + objekty.inputJK + objekty.inputR);
                                Console.WriteLine("hotovo");
                            }
                        break;
                }
            }
            public static void Pridat()
            {
                Console.WriteLine("Vítam Vás, teď zadejte následující informace o knize");
                objekty.inputJK = AnsiConsole.Ask<string>("Jméno:");
                objekty.inputR = AnsiConsole.Ask<int>("Rok:");
                objekty.inputA = AnsiConsole.Ask<string>("Autor:");

                objekty.Knihy.Add(new kniha(objekty.inputJK, objekty.inputR, objekty.inputA));

                Console.WriteLine("Chceš zobrazit vše,přidávat dále a nebo hledat?(z/p/h)");
                objekty.input =Char.Parse(Console.ReadLine());
            }
        }
        public static void Main()
        {
            try
            {
                metody.Pridat();
                while (objekty.cyklus = true)
                {
                    switch (objekty.input)
                    {
                        case 'z':
                            Console.Clear();
                            AnsiConsole.MarkupLine("[purple]Vypsané informace jsou:[/]");

                            foreach (var objekty in objekty.Knihy)
                            {
                                Console.WriteLine($"Jméno: {objekty.jmeno}\nRok vydání je: {objekty.rok}\nAutorem je: {objekty.autor}");
                                Console.WriteLine();
                            }

                            Console.ReadKey();
                            Console.Clear();
                            objekty.cyklus = false;
                            break;
                       
                        case 'p':
                            Console.Clear();
                            metody.Pridat();
                            break;

                        case 'h':
                            Console.Clear();
                            metody.Hledani();
                            break;
                    }
                    
                }
            }
            catch (Exception)
            {
                AnsiConsole.MarkupLine("[red]Invalid input[/]");
            }
        }
    }
}                     
