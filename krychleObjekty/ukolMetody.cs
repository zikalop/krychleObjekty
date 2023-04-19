namespace ukolMetody
{
    public class neivm
    {
        public class objekty
        {
            public string x { get; set; }
        }
        public static void Main()
        {
            Console.WriteLine("zapiš náhodné číslo ve stringu, které se vypíše v v integeru");
            string input=Console.ReadLine();
            int prevod=int.Parse(input);
            Console.WriteLine($"přeparsované číslo {prevod} a jeho datový typ je {prevod.GetType()}");
        }
    }
}