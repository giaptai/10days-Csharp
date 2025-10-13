
// namespace MyApp
// {

//     public class InvalidPriceException : Exception
//     {
//         public InvalidPriceException(string message) : base(message)
//         {

//         }
//     }

//     class Product
//     {
//         public string? Name { get; set; }
//         private double _price;
//         public double Price
//         {
//             get => _price;
//             set
//             {
//                 if (value < 0)
//                 {
//                     throw new InvalidPriceException("Giá sản phẩm không thể âm!");
//                 }
//                 _price = value;
//             }
//         }
//         static void Main()
//         {
//             // exception handling
//             try
//             {
//                 int a = 10;
//                 int b = 0;
//                 int result = a / b;
//             }
//             catch (DivideByZeroException e)
//             {
//                 Console.WriteLine($"eRROR: {e.Message}");
//             }
//             finally
//             {
//                 Console.WriteLine("Khối finally luôn được thực thi.");
//             }

//             Product product = new();
//             product.Price = -3;
//         }
//     }
// }