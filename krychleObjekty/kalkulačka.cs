using Spectre.Console;
namespace kalkulacka
{
    public class ucenie
    {
        public static void Main()
        {
            int rozdil, soucet, deleni, nasobeni, mocnina, odmocnina, z;
            int a = 0;
            int b = 0;
            string x;
            string y;
            string pocty;
            MENU:
             Console.WriteLine("!pro platnost kódu zadeje všechna slova pravopisně dobře!");
            Console.WriteLine("jakou barvu chcete?(je na výběr z barev modrá,zelená a červená)");
            y = Console.ReadLine();
            if (y == "modrá")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("konzole je teď v modré");
            }
            else if (y == "zelená")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("konzole je teď v zelené");
            }
            else if (y == "červená")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("konzole je teď v červené");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("barva není na výběr");
                Console.ForegroundColor = ConsoleColor.White;
                goto MENU;
            }


            Console.WriteLine("napiš znak dle operace(+,-,/,*,**(mocnina),//(odmocnina)");
            pocty = Console.ReadLine();
            if (pocty == "//")
            {
                Console.WriteLine("1.cislo");
                a = int.Parse(Console.ReadLine());
            }
            else if (pocty == "**")
            {
                Console.WriteLine("1.cislo");
                a = int.Parse(Console.ReadLine());
            }
            try
            {
                if (pocty != "**")
                {
                    Console.WriteLine("1.cislo");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("2.cislo");
                    b = int.Parse(Console.ReadLine());
                }
            }
            catch(Exception chyba)
            {
                Console.WriteLine(chyba.Message);
            }
            



            if (pocty == "+")
            {
                soucet = a + b;
                Console.WriteLine("soucet je " + soucet);
            }
            else if (pocty == "-")
            {
                rozdil = a - b;
                Console.WriteLine("rozdil je" + rozdil);
            }
            else if (pocty == "*")
            {
                nasobeni = a * b;
                Console.WriteLine("nasobeni je " + nasobeni);
            }
            else if (pocty == "/")
            {
                if (b == 0)
                {
                    Console.WriteLine("nulou nelze dělit");
                    return;
                }
                deleni = a / b;
                Console.WriteLine("deleni je " + deleni);
            }
            else if (pocty == "**")
            {
                mocnina = a * a;
                Console.WriteLine("mocnina je " + mocnina);
            }
            else if (pocty == "//")
            {
                odmocnina = a;
                Console.WriteLine($"odmocnina je {Math.Sqrt(odmocnina)}");
            }





            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("chces počítat znova?");
            x = Console.ReadLine();
            if (x == "ano")
            {
                goto MENU;
            }
            else
            {
                Console.WriteLine("konec kódu");
            }
        }
    }
}