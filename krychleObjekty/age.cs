namespace Age
{
    public class all
    {
        public class neznamy
        {
            public static string otazka;
            public static int vek;

        }

        public static void Main()
        {
            try
            {
                Console.WriteLine("Kdy ses narodil (napiš pouze rok)");
                neznamy.vek = int.Parse(Console.ReadLine());
                if (neznamy.vek >= 1925 && neznamy.vek <= 1941)
                {
                    Console.WriteLine("Jsi z generace Silent");
                }
                if (neznamy.vek >= 1946 && neznamy.vek <= 1964)
                {
                    Console.WriteLine("Jsi z generace Baby boomers");
                }
                if (neznamy.vek >= 1964 && neznamy.vek <= 1979)
                {
                    Console.WriteLine("Jsi z generace X ");
                }
                if (neznamy.vek >= 1980 && neznamy.vek <= 1997)
                {
                    Console.WriteLine("Jsi z generace Y");
                }
                if (neznamy.vek >= 1997 && neznamy.vek <= 2023)
                {
                    Console.WriteLine("Jsi z generace Z ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Špatný input");
            }
        }

    }
}