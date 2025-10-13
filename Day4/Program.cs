
// array
// int[] nums = new int[5];
// nums[0] = 10;
// nums[1] = 15;
// int[] nums2 = { 1, 2, 3, 4 };
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.Write($"{nums[i]} ");
// }
// Console.WriteLine();
// foreach(int num in nums2)
// {
//     Console.Write($"{num} ");
// }
// Console.WriteLine();
// end array

// List
// List<string> names = new List<string>();
// names.Add("Lan");
// names.Add("Minh");
// names.Add("Tú");
// names.Remove("Minh");
// Console.WriteLine(names[0]);
// Console.WriteLine(names.Count);
// Console.WriteLine(names.Contains("Tú"));
// foreach (string name in names)
// {
//     Console.Write($"{name} ");
// }
// Console.WriteLine();
//END List

// Dictionary
// Dictionary<string, int> ages = new Dictionary<string, int>();
// ages["Lan"] = 20;
// ages["Thư"] = 24;
// foreach (KeyValuePair<string, int> age in ages)
// {
//     Console.WriteLine($"{age.Key} : {age.Value}");
// }
// List<KeyValuePair<string, int>> ageList = ages.ToList();
// List<KeyValuePair<string, int>> ageList2 = [..ages];
// for (int i = 0; i < ageList.Count; i++)
// {
//     Console.WriteLine($"{ageList[i].Key} : {ageList[i].Value}");
// }
// end Dictionary

// String
// String s = "abcdef123";
// string sLow = "abcdef123";

// Console.WriteLine(s.Length);
// Console.WriteLine(sLow.Length);

// Console.WriteLine(s.ToUpper());
// Console.WriteLine(sLow.ToUpper());

// Console.WriteLine(s.ToLower());
// Console.WriteLine(sLow.ToLower());

// Console.WriteLine(s.Trim());
// Console.WriteLine(sLow.Trim());

// Console.WriteLine(s.Contains("ab"));
// Console.WriteLine(sLow.Contains('a'));

// Console.WriteLine(s.Substring(1, 3));
// Console.WriteLine(sLow.Substring(1, 3));

// Console.WriteLine(s.Split("1"));
// Console.WriteLine(sLow.Split("1"));

// Console.WriteLine(s.Replace("a", "Z"));
// Console.WriteLine(sLow.Replace("a", "Z"));
// end String

// Q1
// Console.Write("Input N number: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] nums = new int[N];
// for (int i = 0; i < N; i++)
// {
//     Console.Write($"Phần tử [{i}]: ");
//     nums[i] = Convert.ToInt32(Console.ReadLine());
// }
// int sum = 0;
// foreach (int x in nums)
// {
//     sum += x;
// }
// Console.WriteLine($"Tổng: {sum}");
// END Q1

// Q2
// List<string> studentNames = new();
// studentNames.Add("Lan");
// studentNames.Add("Minh");
// studentNames.Add("Long");
// Console.WriteLine("Danh sách ban đầu:");
// foreach(string name in studentNames)
// {
//     Console.WriteLine(name);
// }
// studentNames.Remove("Minh");
// Console.WriteLine("Sau khi xóa Minh:");
// foreach (string name in studentNames)
// {
//     Console.WriteLine(name);
// }
// if (studentNames.Contains("Long"))
// {
//     Console.WriteLine("Long có trong danh sách!");
// }
// END Q2

// Q3
// Dictionary<string, int> students = new Dictionary<string, int>();
// students["Lan"] = 20;
// students["Minh"] = 22;
// students["Thư"] = 24;
// Console.Write("Nhập tên cần tra: ");
// string name = Console.ReadLine()!;
// if (students.ContainsKey(name))
// {
//     Console.WriteLine($"{name} {students[name]} tuổi");
// }
// else
// {
//     Console.WriteLine("Không tìm thấy!");
// }
// END Q3

// Q4
// Console.Write("Input sur and name: ");
// string fullName = Console.ReadLine()!;
// string[] parts = fullName.Split(" ");
// Console.WriteLine($"{parts[0]} {parts[1].ToUpper()}");
// END Q4

// Q5
// List<string> students = new List<String>();
// int choice = -1;
// do
// {
//     Console.WriteLine("1. Thêm sinh viên");
//     Console.WriteLine("2. Xóa sinh viên");
//     Console.WriteLine("3. Tìm sinh viên");
//     Console.WriteLine("4. Hiển thị danh sách");
//     Console.WriteLine("5. Thoát");
//     Console.Write("Your choice: ");
//     choice = Convert.ToInt32(Console.ReadLine()!);
//     switch (choice)
//     {
//         case 1:
//             Console.Write("Tên sinh viên: ");
//             string name = Console.ReadLine()!;
//             students.Add(name);
//             break;

//         case 2:
//             Console.Write("Tên sinh viên: ");
//             string nameEdit = Console.ReadLine()!;
//             if (students.Contains(nameEdit))
//             {
//                 students.Remove(nameEdit);
//             }
//             else
//             {
//                 Console.WriteLine("Sv không tồn tại");
//             }
//             break;
//         case 3:
//             Console.Write("Tên sinh viên: ");
//             string nameFind = Console.ReadLine()!;
//             if (students.Contains(nameFind))
//             {
//                 Console.WriteLine("Tìm thấy");
//             }
//             else
//             {
//                 Console.WriteLine("Sv không tồn tại");
//             }
//             break;
//         case 4:
//             foreach (string student in students)
//             {
//                 Console.Write($"{student} ");
//             }
//             Console.WriteLine();
//             break;
//     }
// } while (choice != 5);
// END Q5

