namespace linqdemo
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
        public int price { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { Id = 1,Name="Earphones",Brand="Sony",Quantity=9,price=1000},
                new Product { Id = 2,Name="Laptop",Brand="hp",Quantity=19,price=90000},
                new Product { Id = 3,Name="Tablet",Brand="samsung",Quantity=3,price=1500},
                new Product { Id = 4,Name="Desktop",Brand="dell",Quantity=7,price=50000},
                new Product { Id = 5,Name="camera",Brand="lenovo",Quantity=4,price=70000}
            };
            var query=from x in products where x.Id == 5 select x;
            foreach (Product p in query)
            {
                Console.WriteLine($"{p.Id} {p.Name} {p.Brand} {p.Quantity} {p.price}");
            }

            var result=products.Where(x=> x.Brand == "Sony").ToList();
            foreach (Product p in result)
            {
                Console.WriteLine($"{p.Id} {p.Name} {p.Brand} {p.Quantity} {p.price}");
            }

            var item=products.Find(x=>x.Name == "Tablet");
            Console.WriteLine($"{item.Id} {item.Name} {item.Brand} {item.Quantity} {item.price}");

            var item1=products.Where(x=>x.price==products.Max(p=>p.price)).FirstOrDefault();
            Console.WriteLine($"{item1.Id} {item1.Name} {item1.Brand} {item1.Quantity} {item1.price}");
        }
    }
}