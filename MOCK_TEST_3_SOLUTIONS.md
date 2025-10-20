# 🎯 MOCK TEST 3 - ĐÁP ÁN CHI TIẾT (CHALLENGE)

---

## ⭐ Câu 1: Merge Two Sorted Arrays (In-Place)

### 📝 Đề bài:
Gộp hai mảng đã sắp xếp `nums1` và `nums2` vào `nums1` **in-place** (không tạo mảng mới).

### 💡 Giải thích thuật toán:

**Ý tưởng chính:** Merge từ **CUỐI về ĐẦU** để tránh ghi đè dữ liệu

**Tại sao merge từ cuối?**
- Nếu merge từ đầu → phải dịch chuyển các phần tử → O(n²)
- Nếu merge từ cuối → các ô trống ở cuối nums1 → O(n)

**Cách làm:**
```
nums1 = [1, 2, 3, 0, 0, 0], m = 3
nums2 = [2, 5, 6], n = 3

p1 = 2 (index cuối của nums1 thực sự)
p2 = 2 (index cuối của nums2)
p = 5 (index cuối của nums1)

So sánh nums1[p1] vs nums2[p2], chọn số lớn hơn cho nums1[p]
```

**Minh họa:**
```
Bước 1: So sánh 3 vs 6 → Chọn 6
[1, 2, 3, 0, 0, 6]
        ↑        ↑
       p1        p

Bước 2: So sánh 3 vs 5 → Chọn 5
[1, 2, 3, 0, 5, 6]
        ↑     ↑
       p1     p

Bước 3: So sánh 3 vs 2 → Chọn 3
[1, 2, 3, 3, 5, 6]
     ↑     ↑
    p1     p

Bước 4: So sánh 2 vs 2 → Chọn 2 từ nums2
[1, 2, 2, 3, 5, 6]
  ↑     ↑
 p1     p

Bước 5: Còn nums2[0] = 2 chưa copy → Copy vào
[1, 2, 2, 3, 5, 6]
```

### ✅ Code Solution:

```csharp
using System;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1;      // Pointer cuối của nums1 (phần có data)
        int p2 = n - 1;      // Pointer cuối của nums2
        int p = m + n - 1;   // Pointer cuối của nums1 (bao gồm cả phần trống)

        // Merge từ cuối về đầu
        while (p2 >= 0)
        {
            if (p1 >= 0 && nums1[p1] > nums2[p2])
            {
                nums1[p] = nums1[p1];
                p1--;
            }
            else
            {
                nums1[p] = nums2[p2];
                p2--;
            }
            p--;
        }

        // Nếu còn phần tử trong nums2, copy vào
        // (Nếu còn phần tử trong nums1 thì đã đúng vị trí rồi, không cần làm gì)
    }
}
```

### 🧪 Test Cases:

```csharp
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        // Test 1: Case cơ bản
        int[] test1 = {1, 2, 3, 0, 0, 0};
        solution.Merge(test1, 3, new int[] {2, 5, 6}, 3);
        PrintArray(test1); // [1, 2, 2, 3, 5, 6]

        // Test 2: nums1 rỗng
        int[] test2 = {0};
        solution.Merge(test2, 0, new int[] {1}, 1);
        PrintArray(test2); // [1]

        // Test 3: nums2 rỗng
        int[] test3 = {1};
        solution.Merge(test3, 1, new int[] {}, 0);
        PrintArray(test3); // [1]

        // Test 4: nums1 lớn hơn tất cả
        int[] test4 = {4, 5, 6, 0, 0, 0};
        solution.Merge(test4, 3, new int[] {1, 2, 3}, 3);
        PrintArray(test4); // [1, 2, 3, 4, 5, 6]

        // Test 5: nums2 lớn hơn tất cả
        int[] test5 = {1, 2, 3, 0, 0, 0};
        solution.Merge(test5, 3, new int[] {4, 5, 6}, 3);
        PrintArray(test5); // [1, 2, 3, 4, 5, 6]

        // Test 6: Có phần tử trùng
        int[] test6 = {1, 2, 2, 0, 0};
        solution.Merge(test6, 3, new int[] {2, 2}, 2);
        PrintArray(test6); // [1, 2, 2, 2, 2]
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine("[" + string.Join(", ", arr) + "]");
    }
}
```

### ⏱️ Độ phức tạp:
- **Time:** O(m + n) - duyệt mỗi phần tử đúng 1 lần
- **Space:** O(1) - merge in-place, không dùng thêm mảng

---

## ⭐ Câu 2: Valid Sudoku Checker

### 📝 Đề bài:
Kiểm tra bảng Sudoku 9x9 có hợp lệ hay không (chỉ kiểm tra các ô đã điền).

### 💡 Giải thích thuật toán:

**3 điều kiện phải check:**
1. **Mỗi hàng:** không có số trùng
2. **Mỗi cột:** không có số trùng
3. **Mỗi ô con 3x3:** không có số trùng

**Ý tưởng:** Dùng **HashSet** để track các số đã gặp

**Cách tính box index cho ô (i, j):**
```
Box layout (9 boxes, index 0-8):
┌─────┬─────┬─────┐
│  0  │  1  │  2  │  Rows 0-2
├─────┼─────┼─────┤
│  3  │  4  │  5  │  Rows 3-5
├─────┼─────┼─────┤
│  6  │  7  │  8  │  Rows 6-8
└─────┴─────┴─────┘
 Cols  Cols  Cols
 0-2   3-5   6-8

Box index = (i / 3) * 3 + (j / 3)

Ví dụ:
- Ô (0, 0) → Box 0: (0/3)*3 + (0/3) = 0
- Ô (2, 5) → Box 1: (2/3)*3 + (5/3) = 0*3 + 1 = 1
- Ô (4, 7) → Box 5: (4/3)*3 + (7/3) = 1*3 + 2 = 5
- Ô (8, 8) → Box 8: (8/3)*3 + (8/3) = 2*3 + 2 = 8
```

### ✅ Code Solution:

```csharp
using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        // Tạo HashSet cho 9 hàng, 9 cột, 9 boxes
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        // Khởi tạo các HashSet
        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        // Duyệt qua từng ô
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char c = board[i][j];

                // Bỏ qua ô trống
                if (c == '.')
                    continue;

                // Tính box index
                int boxIndex = (i / 3) * 3 + (j / 3);

                // Kiểm tra duplicate
                if (!rows[i].Add(c) || !cols[j].Add(c) || !boxes[boxIndex].Add(c))
                {
                    return false; // Tìm thấy duplicate
                }
            }
        }

        return true; // Không có duplicate, valid!
    }
}
```

### 🧪 Test Cases:

```csharp
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        // Test 1: Valid Sudoku
        char[][] valid = new char[][]
        {
            new char[] {'5','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}
        };
        Console.WriteLine(solution.IsValidSudoku(valid)); // True

        // Test 2: Invalid - duplicate in column
        char[][] invalid = new char[][]
        {
            new char[] {'8','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'}, // 8 duplicate in col 0
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'}
        };
        Console.WriteLine(solution.IsValidSudoku(invalid)); // False

        // Test 3: Simple valid case
        char[][] simple = new char[][]
        {
            new char[] {'1','2','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'}
        };
        Console.WriteLine(solution.IsValidSudoku(simple)); // True

        // Test 4: Invalid - duplicate in row
        char[][] invalidRow = new char[][]
        {
            new char[] {'1','1','.','.','.','.','.','.', '.'}, // Duplicate 1
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'},
            new char[] {'.','.','.','.','.','.','.','.', '.'}
        };
        Console.WriteLine(solution.IsValidSudoku(invalidRow)); // False
    }
}
```

### ⏱️ Độ phức tạp:
- **Time:** O(81) = O(1) - luôn duyệt 9x9 = 81 ô
- **Space:** O(81) = O(1) - luôn dùng 27 HashSets (9 rows + 9 cols + 9 boxes)

---

## ⭐⭐ Câu 3: Student Grade Management System

### 📝 Đề bài:
Xây dựng hệ thống quản lý điểm sinh viên: đọc CSV, tính điểm, sắp xếp, xuất báo cáo.

### 💡 Giải thích thuật toán:

**Các bước:**
1. **Đọc CSV** → Parse thành List<Student>
2. **Tính điểm TB** và **xếp loại** cho mỗi sinh viên
3. **Sắp xếp** theo điểm TB (giảm dần), nếu bằng nhau thì theo tên (A-Z)
4. **Thống kê phân bố** xếp loại
5. **Xuất báo cáo** ra file

**Thang điểm:**
- EXCELLENT: 8.5 - 10.0
- GOOD: 7.0 - 8.49
- AVERAGE: 5.5 - 6.99
- BELOW AVERAGE: 4.0 - 5.49
- FAIL: 0 - 3.99

### ✅ Code Solution:

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// ==================== STUDENT CLASS ====================
public class Student
{
    public string StudentID { get; set; }
    public string Name { get; set; }
    public double Math { get; set; }
    public double Physics { get; set; }
    public double Chemistry { get; set; }
    public double English { get; set; }

    // Computed properties
    public double Average { get; set; }
    public string Grade { get; set; }

    // Tính điểm trung bình
    public void CalculateAverage()
    {
        Average = (Math + Physics + Chemistry + English) / 4.0;
    }

    // Xếp loại dựa trên điểm TB
    public void DetermineGrade()
    {
        if (Average >= 8.5)
            Grade = "EXCELLENT";
        else if (Average >= 7.0)
            Grade = "GOOD";
        else if (Average >= 5.5)
            Grade = "AVERAGE";
        else if (Average >= 4.0)
            Grade = "BELOW AVERAGE";
        else
            Grade = "FAIL";
    }
}

// ==================== GRADE MANAGEMENT SYSTEM ====================
public class GradeManagementSystem
{
    // Đọc CSV file và parse thành List<Student>
    public List<Student> ReadStudentsFromCSV(string filePath)
    {
        var students = new List<Student>();

        if (!File.Exists(filePath))
            throw new FileNotFoundException($"File not found: {filePath}");

        var lines = File.ReadAllLines(filePath);

        // Bỏ qua header (dòng đầu tiên)
        for (int i = 1; i < lines.Length; i++)
        {
            var parts = lines[i].Split(',');

            if (parts.Length != 6)
                continue; // Bỏ qua dòng format sai

            try
            {
                var student = new Student
                {
                    StudentID = parts[0],
                    Name = parts[1],
                    Math = double.Parse(parts[2]),
                    Physics = double.Parse(parts[3]),
                    Chemistry = double.Parse(parts[4]),
                    English = double.Parse(parts[5])
                };

                student.CalculateAverage();
                student.DetermineGrade();
                students.Add(student);
            }
            catch
            {
                // Bỏ qua dòng có lỗi parse
                continue;
            }
        }

        return students;
    }

    // Tạo báo cáo
    public void GenerateReport(List<Student> students, string outputPath)
    {
        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            writer.WriteLine("=============== STUDENT GRADE REPORT ===============");
            writer.WriteLine($"Total Students: {students.Count}");
            writer.WriteLine();

            if (students.Count == 0)
            {
                writer.WriteLine("No students to report.");
                writer.WriteLine("====================================================");
                return;
            }

            // Sắp xếp: Average giảm dần, nếu bằng thì Name A-Z
            var sortedStudents = students.OrderByDescending(s => s.Average)
                                         .ThenBy(s => s.Name)
                                         .ToList();

            // TOP PERFORMERS (Top 3)
            writer.WriteLine("TOP PERFORMERS:");
            int topCount = Math.Min(3, sortedStudents.Count);
            for (int i = 0; i < topCount; i++)
            {
                var s = sortedStudents[i];
                writer.WriteLine($"Rank {i + 1}: {s.Name} ({s.StudentID}) - Average: {s.Average:F2} - Grade: {s.Grade}");
            }
            writer.WriteLine();

            // GRADE DISTRIBUTION
            var gradeDistribution = students.GroupBy(s => s.Grade)
                                           .ToDictionary(g => g.Key, g => g.Count());

            writer.WriteLine("GRADE DISTRIBUTION:");

            // Đảm bảo hiển thị tất cả các grade (kể cả 0 students)
            string[] allGrades = { "EXCELLENT", "GOOD", "AVERAGE", "BELOW AVERAGE", "FAIL" };
            string[] gradeRanges = { "8.5-10.0", "7.0-8.49", "5.5-6.99", "4.0-5.49", "0-3.99" };

            for (int i = 0; i < allGrades.Length; i++)
            {
                string grade = allGrades[i];
                string range = gradeRanges[i];
                int count = gradeDistribution.ContainsKey(grade) ? gradeDistribution[grade] : 0;
                double percentage = students.Count > 0 ? (count * 100.0) / students.Count : 0;

                string studentText = count == 1 ? "student" : "student(s)";
                writer.WriteLine($"- {grade} ({range}): {count} {studentText} - {percentage:F2}%");
            }
            writer.WriteLine();

            // STUDENTS AT RISK (Average < 5.5)
            var atRiskStudents = students.Where(s => s.Average < 5.5)
                                        .OrderBy(s => s.Average)
                                        .ToList();

            writer.WriteLine("STUDENTS AT RISK (Average < 5.5):");
            if (atRiskStudents.Count > 0)
            {
                foreach (var s in atRiskStudents)
                {
                    writer.WriteLine($"- {s.Name} ({s.StudentID}) - Average: {s.Average:F2} - Grade: {s.Grade}");
                }
            }
            else
            {
                writer.WriteLine("No students at risk.");
            }

            writer.WriteLine();
            writer.WriteLine("====================================================");
        }
    }
}

// ==================== TEST PROGRAM ====================
public class Program
{
    public static void Main()
    {
        Console.WriteLine("========== MOCK TEST 3 - GRADE SYSTEM ==========\n");

        // Tạo file students.csv để test
        string[] csvLines = new string[]
        {
            "StudentID,Name,Math,Physics,Chemistry,English",
            "SV001,Nguyen Van A,8.5,7.0,9.0,8.0",
            "SV002,Tran Thi B,6.5,5.0,7.5,6.0",
            "SV003,Le Van C,9.0,9.5,8.5,9.0",
            "SV004,Pham Thi D,5.0,4.5,6.0,5.5",
            "SV005,Hoang Van E,7.5,8.0,7.0,8.5",
            "SV006,Do Van F,3.5,4.0,3.0,4.5",
            "SV007,Vu Thi G,8.0,8.5,9.0,8.0",
            "SV008,Bui Van H,6.0,6.5,5.5,7.0"
        };
        File.WriteAllLines("students.csv", csvLines);
        Console.WriteLine("✓ File students.csv created\n");

        // Chạy grade management system
        GradeManagementSystem system = new GradeManagementSystem();

        try
        {
            // Đọc students
            var students = system.ReadStudentsFromCSV("students.csv");
            Console.WriteLine($"✓ Read {students.Count} students successfully\n");

            // In danh sách students ra console
            Console.WriteLine("STUDENTS:");
            foreach (var s in students)
            {
                Console.WriteLine($"- {s.Name} ({s.StudentID}): Avg = {s.Average:F2}, Grade = {s.Grade}");
            }
            Console.WriteLine();

            // Tạo report
            system.GenerateReport(students, "report.txt");
            Console.WriteLine("✓ Report generated successfully!\n");

            // In nội dung report
            Console.WriteLine("========== REPORT CONTENT ==========");
            string reportContent = File.ReadAllText("report.txt");
            Console.WriteLine(reportContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
```

### 📊 Expected Output (`report.txt`):

```
=============== STUDENT GRADE REPORT ===============
Total Students: 8

TOP PERFORMERS:
Rank 1: Le Van C (SV003) - Average: 9.00 - Grade: EXCELLENT
Rank 2: Vu Thi G (SV007) - Average: 8.38 - Grade: GOOD
Rank 3: Nguyen Van A (SV001) - Average: 8.13 - Grade: GOOD

GRADE DISTRIBUTION:
- EXCELLENT (8.5-10.0): 1 student(s) - 12.50%
- GOOD (7.0-8.49): 3 student(s) - 37.50%
- AVERAGE (5.5-6.99): 2 student(s) - 25.00%
- BELOW AVERAGE (4.0-5.49): 1 student(s) - 12.50%
- FAIL (0-3.99): 1 student(s) - 12.50%

STUDENTS AT RISK (Average < 5.5):
- Do Van F (SV006) - Average: 3.75 - Grade: FAIL
- Pham Thi D (SV004) - Average: 5.25 - Grade: BELOW AVERAGE

====================================================
```

### ⏱️ Độ phức tạp:
- **Time:** O(n log n) - do sorting
- **Space:** O(n) - lưu trữ students

---

## 🎯 FULL CODE - COPY VÀ CHẠY LUÔN

*(Code đầy đủ đã được cung cấp ở phần Solution trên)*

---

## 📊 TÓM TẮT

| Câu | Độ khó | Thuật toán chính | Time | Space |
|-----|--------|------------------|------|-------|
| 1 | Easy | Two Pointers (merge from end) | O(m+n) | O(1) |
| 2 | Easy-Medium | HashSet for duplicates | O(1) | O(1) |
| 3 | Medium | File I/O + LINQ + Sorting | O(n log n) | O(n) |

---

## 💡 KIẾN THỨC RÚT RA

### Từ Câu 1:
- **Merge in-place** → merge từ cuối về đầu để tránh ghi đè
- **Two Pointers** pattern rất mạnh cho sorted arrays
- Cẩn thận với edge cases: một mảng rỗng

### Từ Câu 2:
- **HashSet** hoàn hảo cho việc check duplicates (O(1))
- **Box index calculation:** `(i / 3) * 3 + (j / 3)`
- Phải check cả 3 điều kiện: row, column, box

### Từ Câu 3:
- **CSV parsing:** `Split(',')` và xử lý header
- **LINQ sorting:** `OrderByDescending().ThenBy()`
- **LINQ grouping:** `GroupBy().ToDictionary()`
- **String formatting:** `{value:F2}` để format 2 chữ số thập phân
- **File I/O:** luôn check `File.Exists()` và dùng try-catch

---

## 🔥 MOCK TEST 3 KHÓ NHẤT - NẾU LÀM ĐƯỢC = BẠN SẴN SÀNG CHO NASHTECH!

**Các kỹ năng đã thực hành:**
- ✅ Two Pointers (Merge Arrays)
- ✅ HashSet (Valid Sudoku)
- ✅ File I/O (CSV Reading/Writing)
- ✅ LINQ (Sorting, Grouping, Filtering)
- ✅ OOP (Class, Properties, Methods)
- ✅ Exception Handling
- ✅ String Formatting

---

**🎯 CHÚC MỪNG BẠN ĐÃ HOÀN THÀNH TẤT CẢ 3 MOCK TESTS!** 💪🚀
