// using System.IO;

// class Student
// {
//     private string name = string.Empty;
//     private double score;

//     public Student(string name, double score)
//     {
//         Name = name;
//         Score = score;
//     }

//     public string Name
//     {
//         get => name;
//         set => name = value ?? string.Empty;
//     }

//     public double Score
//     {
//         get => score;
//         set
//         {
//             if (value < 0 || value > 10)
//             {
//                 throw new ArgumentOutOfRangeException("WTF ???");
//             }
//             else
//             {
//                 score = value;
//             }
//         }
//     }

//     public override string ToString()
//     {
//         return $"{Name} - {Score}";
//     }
// }

// class Practice
// {
//     private const string path = "students.txt";
//     private static List<Student> students = new List<Student>();
//     static void Main()
//     {
//         Console.Write("Input n Students: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         using (StreamWriter writer = new StreamWriter(path, append: false))
//         {
//             for (int i = 0; i < n; i++)
//             {
//                 Console.Write("Name: ");
//                 string name = Console.ReadLine() ?? string.Empty;
//                 Console.Write("Score: ");
//                 double score = double.Parse(Console.ReadLine()!);
//                 Student student = new(name, score);
//                 students.Add(student);

//                 writer.WriteLine(student.ToString());
//             }
//         }
//         Console.WriteLine("Doc file va in ra man hinh: ");
//         using StreamReader reader = new StreamReader(path);
//         // way 1
//         string? line;
//         while ((line = reader.ReadLine()) != null)
//         {
//             Console.WriteLine(line);
//         }
//         //  Way 2
//         string allLine = File.ReadAllText(path);
//         Console.WriteLine(allLine);
//         // tinh diem trung binh
//         using StreamReader reader1 = new StreamReader("avg_students.txt");
//         List<double> scoreList = new List<double>();
//         string lineScore;
//         while ((lineScore = reader1.ReadLine()) != null)
//         {
//             scoreList.Add(double.Parse(lineScore.Split(',')[1]));
//         }
//         double avgScore = scoreList.Average(s => s);
//         Console.WriteLine($"Diem trung binh: {avgScore:F2}");
//     }
// }