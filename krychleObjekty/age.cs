namespace Age
{
    public class all
    {
        public class neznamy
        {
            public static string otz;
            public static int vek;

        }

        public static void Main()
        {
            
            Console.WriteLine("Kdy ses narodil (napiš pouze rok)");
            neznamy.vek= int.Parse(Console.ReadLine());
            switch (neznamy.vek)
            {
                case neznamy.vek >= 1925 and neznamy.vek <= 1941:
                    Console.WriteLine("Jsi generace silent");
                    break;
            }

        }
    }

}