// string[] lines = File.ReadAllLines("student.txt");
// foreach (string line in lines)
// {
//     Console.WriteLine(line);
// }

// string content = File.ReadAllText("avg_students.txt");
// Console.WriteLine(content);

// RECOMMEND
// using (StreamReader reader = new StreamReader("student.txt"))
// {
//     string? line;
//     while ((line = reader.ReadLine()) != null)
//     {
//         Console.WriteLine(line);
//     }
// }

// foreach(string line in File.ReadLines("avg_students.txt"))
// {
//     Console.WriteLine(line);
// }

/*
+-----------------------------+
+--------WRITE FILE-----------+
+-----------------------------+
*/

// string[] lines = new string[] { "Line 1", "Line 2", "chào" };
// File.WriteAllLines("students.txt", lines, Encoding.UTF8);

// using System.Text;

// string content = "Hello\nWorld chào";
// File.WriteAllText("input.txt", content, Encoding.UTF8); // auto create file

// RECOMMEND
// using(StreamWriter writer = new StreamWriter("students.txt"))
// {
//     writer.WriteLine("Line 1");
//     writer.WriteLine("Line 2");
//     writer.Write("No newline"); 
// }

// File.AppendAllText("students.txt", "Tạm biệt", Encoding.UTF8);
// File.AppendAllLines("students.txt", ["Line 4", "Line 5"]);


/*
+-----------------------------+
+--------CHECK FILE-----------+
+-----------------------------+
*/
// if (File.Exists("input.txt"))
// {
//     Console.WriteLine("File exists!");
// }
// else
// {
//     File.Create("input.txt").Close();
//     Console.WriteLine("File not found!");
// }

// using (FileStream fs = File.Create("input.txt"))
// {
// }

// if (File.Exists("input.txt"))
// {
//     File.Delete("input.txt");
// }

// File.Copy("student.txt", "students.txt", overwrite: true);

File.Move("input.txt", "new_input.txt");

