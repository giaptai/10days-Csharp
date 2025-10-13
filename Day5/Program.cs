// namespace StudetnApp
// {
//     class Student
//     {
//         private int id;
//         private string name = string.Empty;
//         private int score;

//         public string Name
//         {
//             get { return this.name; }
//             set { this.name = value ?? string.Empty; }
//         }

//         public int Score
//         {
//             get { return score; }
//             set
//             {
//                 if (value < 0)
//                 {
//                     Console.WriteLine("Score khong hop le");
//                 }
//                 else
//                 {
//                     this.score = value;
//                 }
//             }
//         }
//         public int Id
//         {
//             get { return this.id; }
//             set { this.id = value; }
//         }
//         public Student(int id, string name, int score)
//         {
//             this.Name = name!;
//             this.Score = score;
//             this.Id = id;
//         }

//         public Student()
//         {

//         }

//         public void Display()
//         {
//             Console.WriteLine($"Tên: {Name}, Score: {Score}, Id: {Id}");
//         }
//         public bool IsPassed()
//         {
//             return Score >= 5;
//         }
//     }

//     class StudentManager
//     {
//         private List<Student> students;

//         public StudentManager()
//         {
//             this.students = new List<Student>();
//         }

//         public void AddStudent(Student s)
//         {
//             if (students.Any(x => x.Id == s.Id))
//             {
//                 Console.WriteLine($"Student với Id={s.Id} đã tồn tại. Bỏ qua thêm.");
//                 return;
//             }
//             students.Add(s);
//         }

//         public void RemoveStudentById(int id)
//         {
//             Student? student = students.FirstOrDefault(s => s.Id == id);
//             if (student != null)
//             {
//                 students.Remove(student);
//                 Console.WriteLine($"Đã xóa student Id={id}");
//             }
//             else
//             {
//                 Console.WriteLine("Not found student");
//             }
//         }

//         public Student? FindByName(string keyword)
//         {
//             Student? student = students.Find(s => s.Name == keyword);
//             if (student != null)
//             {
//                 return student;
//             }
//             else
//             {
//                 return null;
//             }
//         }

//         public List<Student> ShowAll()
//         {
//             return students;
//         }
//     }

//     class Program
//     {
//         static void Main()
//         {
//             Student s1 = new Student(1, "An", 4);
//             Student s2 = new(2, "Long", 10);
//             Student s3 = new(3, "Nam", 7);

//             StudentManager studentManager = new();
//             //Add Student
//             studentManager.AddStudent(s1);
//             studentManager.AddStudent(s2);
//             studentManager.AddStudent(s3);
//             // Remove Student
//             studentManager.RemoveStudentById(1);
//             // Find by NAME
//             Student? found = studentManager.FindByName("Long");
//             if (found != null)
//             {
//                 Console.WriteLine("\nKết quả FindByName(\"Long\"):");
//                 found.Display();
//             }
//             else
//             {
//                 Console.WriteLine("Không tìm thấy student theo tên.");
//             }
//             //show all
//             Console.WriteLine("\nDanh sách hiện tại:");
//             foreach (Student st in studentManager.ShowAll())
//             {
//                 st.Display();
//             }
//             Console.WriteLine("\nDanh sách đã qua môn:");
//              foreach (Student st in studentManager.ShowAll().Where(x => x.IsPassed()))
//             {
//                 st.Display();
//             }
//         }
//     }
// }
