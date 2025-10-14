
// class Student
// {
//     private string name = string.Empty;
//     private double score;

//     public Student(string name, double score)
//     {
//         this.Name = name;
//         this.Score = score;
//     }

//     public string Name
//     {
//         get => name;
//         set => name = value;
//     }

//     public double Score
//     {
//         get => score;
//         set
//         {
//             if (value < 0 || value > 10)
//             {
//                 throw new Exception("The f my freind ?");
//             }
//             else
//             {
//                 score = value;
//             }
//         }
//     }
//     public override string ToString() => $"Student: {Name} - {Score:F1}";
// }

// class Practice
// {
//     static List<Student> students = new List<Student>
//     {
//         new Student("Nam", 7.4),
//         new Student("Hoai", 5.3),
//         new Student("Tam", 8.2),
//         new Student("Long", 9.0),
//         new Student("Thinh", 10)
//     };

//     private static void Display(IEnumerable<Student> students)
//     {
//         foreach (Student s in students)
//         {
//             Console.WriteLine(s.ToString());
//         }
//     }

//     static void Main(string[] args)
//     {
//         int choice;
//         do
//         {
//             Console.WriteLine("1. Hiển thị tất cả sinh viên");
//             Console.WriteLine("2. Lọc sinh viên có điểm ≥ 8");
//             Console.WriteLine("3. Tính điểm trung bình");
//             Console.WriteLine("4. Tìm sinh viên có điểm cao nhất");
//             Console.WriteLine("""
//             5. Nhóm sinh viên theo học lực
//                 - ≥ 8: Giỏi
//                 - 6.5 – 7.9: Khá
//                 - < 6.5: Trung bình
//             """);
//             Console.WriteLine("0. Thoát");
//             Console.Write("Your choice: ");
//             choice = int.Parse(Console.ReadLine()!);
//             switch (choice)
//             {
//                 case 1:
//                     Display(students);
//                     break;
//                 case 2:
//                     List<Student> stu = students.Where(s => s.Score >= 8).ToList();
//                     Display(stu);
//                     break;
//                 case 3:
//                     double avgScore = students.Average(s => s.Score);
//                     Console.WriteLine($"DTb: {avgScore:F2}");
//                     break;
//                 case 4:
//                     Student? sHighest = students.OrderByDescending(s => s.Score).FirstOrDefault();
//                     Console.WriteLine($"Student highest score: {sHighest?.Name} - {sHighest?.Score}");
//                     break;
//                 case 5:
//                     Console.WriteLine("High score");
//                     List<Student> high = students.Where(s => s.Score >= 8).ToList();
//                     Display(high);
//                     Console.WriteLine("Mid score");
//                     List<Student> mid = students.Where(s => s.Score >= 6.5 && s.Score <= 7.9).ToList();
//                     Display(mid);
//                     Console.WriteLine("Low score");
//                     List<Student> low = students.Where(s => s.Score < 6.5).ToList();
//                     Display(low);
//                     // 
//                     IEnumerable<IGrouping<string, Student>>? groups = students.GroupBy(s =>
//                     s.Score >= 8 ? "Gioi" :
//                     s.Score >= 6.5 ? "kha" : "Trung binh");
//                     foreach (IGrouping<string, Student>? g in groups)
//                     {
//                         Console.WriteLine($"\nHọc lực: {g.Key} ({g.Count()} sinh viên)");
//                         Display(g);
//                     }
//                     break;
//             }
//         } while (choice != 0);
//     }
// }