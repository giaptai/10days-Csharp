// using System.IO;

// class Program
// {
//     static void Main()
//     {
//         string path = "student.txt";
//         if (File.Exists(path))
//         {
//             using StreamReader reader = new StreamReader(path);
//             string? line;
//             while ((line = reader.ReadLine()) != null)
//             {
//                 // Console.WriteLine(line);
//             }
//         }
//         else
//         {
//             Console.WriteLine("File không tồn tại!");
//             // if file isn't exist then create new
//             using StreamWriter writer = new StreamWriter(path, append: true);
//             writer.WriteLine("Nguyen Van A, 8.6");
//             writer.WriteLine("Nguyen Pham Long, 9.2");
//         }
//         // Read all line
//         string allText = File.ReadAllText(path);
//         Console.WriteLine(allText);
//         // copy content into another file - if not exist file's paste create new file
//         File.Copy("student.txt", "a.txt", overwrite: true);
//         File.Delete("a.txt");
//         bool exists = File.Exists("student.txt");
//         Console.WriteLine(exists);
//     }
// }