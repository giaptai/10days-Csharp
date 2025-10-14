// namespace MyPractice
// {
//     class InvalidPriceException : Exception
//     {
//         public InvalidPriceException(string message) : base(message)
//         {

//         }
//     }

//     class Product
//     {
//         private int productId;
//         private string name = string.Empty;
//         private float price;

//         public static List<Product> products = new List<Product>();
//         public static Dictionary<int, Product> productDict = new Dictionary<int, Product>();
//         public Product(int productId, string name, float price)
//         {
//             this.ProductId = productId;
//             Name = name;
//             this.Price = price;
//         }
//         public int ProductId
//         {
//             get => productId;
//             set => productId = value;
//         }

//         public string Name
//         {
//             get => name;
//             set => name = value;
//         }

//         public float Price
//         {
//             get => price;
//             set
//             {
//                 if (value < 0)
//                 {
//                     throw new InvalidPriceException("The fuck");
//                 }
//                 this.price = value;
//             }
//         }

//         public void AddProduct(Product p)
//         {
//             if (products.Any(item => item.ProductId == p.ProductId))
//             {
//                 Console.WriteLine("Duplicate ID ok");
//                 return;
//             }
//             products.Add(p);
//         }

//         public static Product? FindByName(int searchId)
//         {
//             bool check = productDict.ContainsKey(searchId);
//             if (check)
//             {
//                 return productDict[searchId];
//             }
//             else
//             {
//                 Product? product = products.Find(p => p.ProductId == searchId);
//                 if (product != null)
//                 {
//                     productDict[product.ProductId] = product;
//                     return product;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Not exist");
//                     return null;
//                 }
//             }
//         }

//         static void Main(string[] args)
//         {
//             short choice;
//             do
//             {
//                 Console.WriteLine("1. Nhập danh sách sản phẩm");
//                 Console.WriteLine("2. Tìm kiếm sản phẩm theo tên");
//                 Console.WriteLine("0. Exit");
//                 choice = Convert.ToInt16(Console.ReadLine());
//                 switch (choice)
//                 {
//                     case 1:
//                         Console.Write("Input N product: ");
//                         int n = int.Parse(Console.ReadLine()!);
//                         try
//                         {
//                             for (int i = 0; i < n; i++)
//                             {
//                                 Console.WriteLine($"\nSản phẩm #{i + 1}");
//                                 Console.Write("ID: ");
//                                 int id = int.Parse(Console.ReadLine()!);
//                                 Console.Write("Tên: ");
//                                 string name = Console.ReadLine()!;
//                                 Console.Write("Giá: ");
//                                 float price = float.Parse(Console.ReadLine()!);
//                                 Product p = new Product(id, name, price);
//                                 products.Add(p);
//                             }
//                         }
//                         catch (InvalidPriceException e)
//                         {
//                             Console.WriteLine($"Lỗi nhập giá: {e.Message}");
//                         }
//                         break;
//                     case 2:
//                         Console.Write("\nNhập ID sản phẩm cần tìm: ");
//                         int searchId = int.Parse(Console.ReadLine()!);
//                         Product pF = FindByName(searchId);
//                         Console.WriteLine($"Sản phẩm: Id: {pF.ProductId}, Name: {pF.Name}, Price: {pF.Price}");
//                         break;
//                 }

//             } while (choice != 0);
//         }
//     }
// }