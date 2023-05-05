using Spectre.Console; 
namespace projektKveten
{
    public class all
    {
        public static void Main() { Inventory.Addproduct(); }
        public class Product
        {
            public string Name ;
            public double Price;
            public Product(string name, double price)
            {

            }

        }
        public static class Inventory
        {
            public static List<Product> prodakty = new List<Product>();
            public static Array products=new int[] { };
            public static int counts;

            public static void Addproduct(string name,double price)
            {
                prodakty.Add(new Product(name, price));
            }
        }

    }
}