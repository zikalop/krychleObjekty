namespace koleso
{
    public class everithing
    {
        public class objekty
        {
            public static int obsahK1;
            public static int obsahK2;
            public static double obsahK3;
            public static int obsahOb;
            public static int vysledek;
            public objekty(int k1, int k2, int k3, int ob, int Vyskedek)
            {
                obsahK1 = k1;
                obsahK2 = k2;
                obsahK3 = k3;
                obsahOb = ob;
                vysledek = Vyskedek;
            }
        }
        public static void Main()
        {
            vypocty();
        }
        public static void vypocty()
        {
            int K1 = 95;
            int K2 = 95;
            int K3 = 1963;
            int Ob = 100;
            int obsah = K3 - (K1 + K2 + Ob);
            var vypocet = new objekty(K1, K2, K3, Ob, obsah);
            Console.WriteLine($"obsah smajlíku je {obsah}cm²");
        }
    }

}