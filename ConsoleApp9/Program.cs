//public class Program
//{
//static void Main(string[] args)
//{
//    // File ga yo'l
//    var filePath = @"D:\All_Homework\Test.txt";
//    // FileInfo sinfidan yangi obyect hosil qilish
//    FileInfo fileInfo = new FileInfo(filePath);
//    // Exist yordamida File mavjudligini tekshirish
//    if(fileInfo.Exists)
//    {
//        Console.WriteLine($"File joylashgan Katalog : \t {fileInfo.Directory}");
//        Console.WriteLine($"Fayl kengaytmasi : \t {fileInfo.Extension}");
//        Console.WriteLine($"Fayl ni Toliq nomi : {fileInfo.FullName}");
//        Console.WriteLine();
//    }
//    Console.ReadKey();
//}


//    static void Main(string[] args)
//    {
//        var filePath = @"D:\All_Homework\Test.txt";
//        var filename = new FileInfo(filePath);

//        using(StreamWriter sw = filename.CreateText())
//        {
//            sw.WriteLine("hello");
//            sw.WriteLine("Shoyad");
//            sw.WriteLine("What's up");
//        }

//        using (StreamReader sw = filename.OpenText())
//        {
//            var h = " ";
//            while((h = sw.ReadLine()) != null)
//            {
//                Console.WriteLine(h);
//            }
//        }
//    }
//}

//class Program
//{
//    static async Task<string> ReadFileAsync(string file)
//    {
//        string content = string.Empty;
//        using (StreamReader reader = new StreamReader(file))
//        {
//            content = await reader.ReadToEndAsync();
//        }
//        return content;
//    }
//    static async void ContentToConsole()
//    {
//        string readFileTask = await ReadFileAsync(@"D:\All_Homework\Test.txt");
//        Console.WriteLine($"Filedagi ma'lumotlar {readFileTask}");
//    }

//    static void Main(string[] args)
//    {
//        Task task = new Task(ContentToConsole);
//         task.Start();
//        task.Wait();
//        Console.ReadLine();
//    }
//}


var accessory = new ProductType("Accessory", "something", 1300);
var laptop = new ProductType("Laptop", "something", 2124);
var beverages = new ProductType("Beverages", "something", 4334);


var products = new List<Product>()
{
    new Product("Razor", "x5", accessory, 100),
    new Product("Asus", "X6",  accessory, 4343),
    new Product("Asus", "X7",  accessory, 474),
    new Product("Cola", "Fanta", accessory,  384)
};


var newMiniMarket = new List<int>();
var result = newMiniMarket.DefaultIfEmpty(12);

var prices = products.Select(item => item.Price).Average();
var brands = products.Select(item => item.Brand).Distinct();


var productsSimple = products.Select(item => new
{
    Name = item.Model,
    item.Price
}).ToList();

var ProductsTypes = new List<ProductType>()
{
    accessory,
    laptop,
    beverages
};

public class ProductType
{
    public ProductType(string name, string description, int recommendedPrice)
    {
        Id = new Guid();
        Name = name;
        Description = description;
        RecommendedPrice = recommendedPrice;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int RecommendedPrice { get; set; }
}

public interface IProduct
{

}

public class Laptop : IProduct
{

}
public class Phone : IProduct
{

}

public class Product : IProduct
{
    public Product(string brand, string model, ProductType type, int price)
    {
        Id = new Guid();
        Brand = brand;
        Model = model;
        Type = type;
        Price = price;
    }

    public Guid Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public ProductType Type { get; set; }
    public int Price { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}\tBrand : {Brand}\tModel : {Model}\tPrice : {Price}";
    }
}




