// using System.ComponentModel.DataAnnotations;

// class Student
// {
//     [Key]
//     public int Id { get; set; }

//     [Required]
//     public string Name { get; set; } = string.Empty;

//     [Range(0, 10)]
//     public double Score { get; set; }

//     public override string ToString() => $"{Id}: {Name} - {Score}";
// }

// class AppDbContext : DbContext
// {
//     public DbSet<Student> Students { get; set; }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         // tạo file database SQLite
//         optionsBuilder.UseSqlite("Data Source=students.db");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         using var db = new AppDbContext();
//         db.Database.EnsureCreated();
//         while (true)
//         {
//             Console.WriteLine("\n=== MENU ===");
//             Console.WriteLine("1. Add student");
//             Console.WriteLine("2. View all");
//             Console.WriteLine("3. Update");
//             Console.WriteLine("4. Delete");
//             Console.WriteLine("5. Find By Name");
//             Console.WriteLine("6. Avg Score");
//             Console.WriteLine("0. Exit");
//             Console.Write("Choose: ");
//             var choice = Console.ReadLine();

//             switch (choice)
//             {
//                 case "1":
//                     AddStudent(db);
//                     break;
//                 case "2":
//                     ViewStudents(db);
//                     break;
//                 case "3":
//                     UpdateStudent(db);
//                     break;
//                 case "4":
//                     DeleteStudent(db);
//                     break;
//                 case "5":
//                     FindByName(db);
//                     break;
//                 case "6":
//                     AvgScore(db);
//                     break;
//                 case "0":
//                     return;
//                 default:
//                     Console.WriteLine("Invalid choice!");
//                     break;
//             }
//         }
//     }

//     static void AddStudent(AppDbContext db)
//     {
//         Console.Write("Enter name: ");
//         string name = Console.ReadLine()!;
//         Console.Write("Enter score: ");
//         double score = double.Parse(Console.ReadLine()!);

//         var student = new Student { Name = name, Score = score };
//         db.Students.Add(student);
//         db.SaveChanges();
//         Console.WriteLine("✅ Added!");
//     }

//     static void ViewStudents(AppDbContext db)
//     {
//         var students = db.Students.ToList();
//         Console.WriteLine("\nAll Students:");
//         foreach (var s in students)
//         {
//             Console.WriteLine(s);
//         }
//     }

//     static void UpdateStudent(AppDbContext db)
//     {
//         Console.Write("Enter student Id to update: ");
//         int id = int.Parse(Console.ReadLine()!);

//         var s = db.Students.Find(id);
//         if (s == null)
//         {
//             Console.WriteLine("❌ Not found");
//             return;
//         }

//         Console.Write("New name: ");
//         s.Name = Console.ReadLine()!;
//         Console.Write("New score: ");
//         s.Score = double.Parse(Console.ReadLine()!);
//         db.SaveChanges();
//         Console.WriteLine("✅ Updated!");
//     }

//     static void DeleteStudent(AppDbContext db)
//     {
//         Console.Write("Enter student Id to delete: ");
//         int id = int.Parse(Console.ReadLine()!);

//         var s = db.Students.Find(id);
//         if (s == null)
//         {
//             Console.WriteLine("❌ Not found");
//             return;
//         }

//         db.Students.Remove(s);
//         db.SaveChanges();
//         Console.WriteLine("✅ Deleted!");
//     }

//     static void FindByName(AppDbContext db)
//     {
//         Console.Write("Input name: ");
//         string name = Console.ReadLine() ?? string.Empty;
//         List<Student> s = db.Students.Where(s => s.Name.ToLower().Contains(name.ToLower())).ToList();
//         foreach (var student in s)
//         {
//             Console.WriteLine(student);
//         }
//     }

//     static void AvgScore(AppDbContext db)
//     {
//         double avgScore = db.Students.Average(s => s.Score);
//         Console.WriteLine($"{avgScore:F2}");
//     }
// }
