namespace tryCatch
{
    public class vypocty
    {
        public class obejkty
        {
            public static char znak;
            /*public objekty(char a)
            {
                znak = a;
            }*/
        }
        public static void Main()
        {
            char[] array = new char[10];
            Console.WriteLine("zapiš 10 znaků(logicky jen jedno číslo/písmeno)");
            try
            {
                for(int i = 0; i < 10; i++)
                {
                    array[i] =  Char.Parse(Console.ReadLine());
                }
                Console.WriteLine($"zadané char byly: {array[0]},{array[1]},{array[2]},{array[3]},{array[4]},{array[5]},{array[6]},{array[7]},{array[8]},{array[9]}");
            }
            catch(Exception chytacChyb)
            {
                Console.WriteLine(chytacChyb.Message);
            }
        }
    }
}