// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Student
// {
//     private int id;
//     private string name = string.Empty;
//     private double score;

//     public Student(int id, string name, double score)
//     {
//         this.Id = id;
//         this.Name = name;
//         this.Score = score;
//     }
//     public int Id { get => id; set => id = value; }
//     public string Name
//     {
//         get => name;
//         set { name = value ?? string.Empty; }
//     }
//     public double Score { get => score; set => score = value; }
//     public override string ToString()
//     {
//         return $"{Id}. {Name} -  {Score}";
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         List<Student> students = new List<Student>
//         {
//             new Student(1, "An", 7.6),
//             new Student (2, "Bình", 8.0 ),
//             new Student (3, "Chi", 9.2 ),
//             new Student (4, "Duy", 6.8 ),
//             new Student (5, "Hà", 8.5 ),
//         };

//         List<Student> excellent = students.Where(s => s.Score >= 8).ToList();

//         Console.WriteLine("danh sách sinh viên xuất sắc");
//         excellent.ForEach(Console.WriteLine);

//         Student top = students.OrderByDescending(s => s.Score).First();
//         Console.WriteLine($"\nSinh viên điểm cao nhất: {top.Name} ({top.Score})");

//         double avg = students.Average(s => s.Score);
//         Console.WriteLine($"\nDiem trung binh: {avg:F2}");
//     }
// }