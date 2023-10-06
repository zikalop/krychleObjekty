namespace projektKveten
{
    public class all
    {
        public static class vice
        {
            public static bool cyklus = true; 
        }
        public class Product
        {
            public Product(string name, double price)
            {
                Name = name; 
                Price = price;
            }
            public string Name { get; set; }
            public double Price { get; set; }
        }
        public static class Inventory
        { 
            public static List<Product> produkty = new List<Product>();
            public static int counts { get; set; } = Inventory.produkty.Count;

            public static void Addproduct()
            {
                Console.WriteLine("zadej název a cenu produktu");
                string name = Console.ReadLine();
                double price = Double.Parse(Console.ReadLine());
                produkty.Add(new Product(name, price));
                Console.Clear();
            }
            public static void RemoveProduct(string name)
            {
                try 
                { 
                    var selectedProduct = produkty.Find(p => p.Name == name);
                    produkty.RemoveAt(produkty.IndexOf(selectedProduct));
                    Console.Clear();
                }
                catch(Exception pokazeni) 
                {
                    Console.WriteLine(pokazeni.Message);
                }
            }
            public static void ShowProduct()
            {
                    Console.Clear();
                    Console.WriteLine("aktualní list je");
                    foreach (var item in produkty) Console.WriteLine($"{item.Name},{item.Price} kč");
                    vice.cyklus = false;
              
            }
            public static void Main()
            {
                while(vice.cyklus)
                {
                    try
                    {
                        Console.WriteLine("zadej akci kterou chceš s produkty provést buď přidat(p),odstranit(o) nebo zobrazit(z)");
                        char akceP=Char.Parse(Console.ReadLine());  
                        Console.Clear();
                        switch(akceP)
                        {
                            default:throw new Exception();
                                    
                            case 'p':
                                Inventory.Addproduct();
                                break;
                            case 'o':
                                Console.WriteLine("napiš název produkty,který chceš smazat");
                                string name=Console.ReadLine();
                                Inventory.RemoveProduct(name);
                                break;
                            case 'z':
                                Inventory.ShowProduct();
                                break;
                        }
                    }
                    catch (Exception) 
                    {
                        Console.WriteLine("Byl zadán špatný input"); 
                        break; 
                    }
                }
            }
        }

    }
}