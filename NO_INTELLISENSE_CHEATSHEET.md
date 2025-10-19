# 🎯 CHEATSHEET C# - TEST (KHÔNG CÓ INTELLISENSE)

> **Mục đích:** Học thuộc lòng các syntax, hàm, và patterns để viết code KHÔNG cần gợi ý IntelliSense
>
> **Liên kết:** Các ví dụ được lấy từ MOCK_TEST_1, MOCK_TEST_2, MOCK_TEST_3

---

## 📌 MỤC LỤC NHANH

1. [Using Statements - Phải Nhớ](#1-using-statements---phải-nhớ)
2. [Data Types & Variables](#2-data-types--variables)
3. [String Operations](#3-string-operations)
4. [Array Operations](#4-array-operations)
5. [List Operations](#5-list-operations)
6. [Dictionary Operations](#6-dictionary-operations)
7. [Stack & Queue](#7-stack--queue)
8. [HashSet](#8-hashset)
9. [LINQ Methods](#9-linq-methods)
10. [Math Functions](#10-math-functions)
11. [Type Conversion](#11-type-conversion)
12. [File I/O (QUAN TRỌNG)](#12-file-io-quan-trọng)
13. [DateTime (QUAN TRỌNG)](#13-datetime-quan-trọng)
14. [Loop Patterns](#14-loop-patterns)
15. [Exception Handling](#15-exception-handling)
16. [Common Patterns từ Mock Tests](#16-common-patterns-từ-mock-tests)

---

## 1️⃣ USING STATEMENTS - PHẢI NHỚ

```csharp
using System;                          // Console, Math, Array, DateTime
using System.Collections.Generic;      // List<T>, Dictionary<K,V>, HashSet<T>, Stack<T>, Queue<T>
using System.Linq;                     // LINQ methods (Where, Select, OrderBy, etc.)
using System.Text;                     // StringBuilder
using System.IO;                       // File, StreamReader, StreamWriter
using System.Text.RegularExpressions;  // Regex (ít dùng hơn)
```

**💡 Tip:** Ghi nhớ thứ tự này, viết luôn vào đầu file khi bắt đầu làm bài!

---

## 2️⃣ DATA TYPES & VARIABLES

### Khai báo biến:
```csharp
// Primitive types
int n = 10;
double d = 3.14;
bool flag = true;
char c = 'A';
string s = "hello";

// Type inference
var num = 5;           // int
var text = "hi";       // string
var list = new List<int>();  // List<int>

// Constants
const int MAX_SIZE = 100;
```

### Default values:
```csharp
int num = 0;           // Default for int
bool flag = false;     // Default for bool
string text = null;    // Default for string (reference type)
```

---

## 3️⃣ STRING OPERATIONS

### Properties & Methods (HỌC THUỘC):

```csharp
// Properties
int len = str.Length;              // Độ dài chuỗi

// Common methods
str.Substring(start, length)       // Cắt chuỗi
str.IndexOf(char/string)           // Tìm vị trí đầu tiên (-1 nếu không tìm thấy)
str.LastIndexOf(char/string)       // Tìm vị trí cuối cùng
str.Contains(string)               // Kiểm tra chứa substring
str.StartsWith(string)             // Kiểm tra bắt đầu
str.EndsWith(string)               // Kiểm tra kết thúc

str.ToUpper()                      // CHỮ HOA
str.ToLower()                      // chữ thường
str.Trim()                         // Xóa khoảng trắng đầu/cuối
str.TrimStart()                    // Xóa khoảng trắng đầu
str.TrimEnd()                      // Xóa khoảng trắng cuối

str.Replace(oldStr, newStr)        // Thay thế
str.Split(char)                    // Tách chuỗi thành mảng
str.Split(new char[] {' ', ','})   // Tách theo nhiều ký tự

// Static methods
string.IsNullOrEmpty(str)          // Kiểm tra null hoặc rỗng
string.IsNullOrWhiteSpace(str)     // Kiểm tra null, rỗng, hoặc toàn khoảng trắng
string.Join(separator, array)      // Nối mảng thành chuỗi
string.Format("{0} {1}", a, b)     // Format chuỗi
```

### Character methods:
```csharp
char c = 'A';
char.IsDigit(c)        // Kiểm tra chữ số
char.IsLetter(c)       // Kiểm tra chữ cái
char.IsLetterOrDigit(c)
char.IsUpper(c)        // Kiểm tra chữ hoa
char.IsLower(c)        // Kiểm tra chữ thường
char.ToUpper(c)        // Chuyển thành chữ hoa
char.ToLower(c)        // Chuyển thành chữ thường
```

### 🎯 MOCK TEST 1 - Câu 2 (Anagram):
```csharp
// Pattern: Kiểm tra anagram bằng Dictionary
public bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length) return false;  // Độ dài phải bằng nhau

    var dict = new Dictionary<char, int>();

    // Đếm frequency của s
    foreach (char c in s)
    {
        if (dict.ContainsKey(c))
            dict[c]++;
        else
            dict[c] = 1;
    }

    // Trừ đi frequency của t
    foreach (char c in t)
    {
        if (!dict.ContainsKey(c))
            return false;
        dict[c]--;
        if (dict[c] < 0)
            return false;
    }

    return true;
}
```

---

## 4️⃣ ARRAY OPERATIONS

### Khai báo & Khởi tạo:
```csharp
// Khai báo
int[] arr = new int[5];                // Mảng 5 phần tử, default = 0
int[] arr = {1, 2, 3, 4, 5};          // Khởi tạo trực tiếp
int[] arr = new int[] {1, 2, 3};      // Cách khác

// 2D Array (Matrix)
int[,] matrix = new int[3, 4];        // 3 hàng, 4 cột
int[,] matrix = {
    {1, 2, 3},
    {4, 5, 6}
};

// Jagged Array (Mảng lởm chởm)
int[][] jagged = new int[3][];
jagged[0] = new int[] {1, 2};
jagged[1] = new int[] {3, 4, 5};
```

### Properties & Methods:
```csharp
int len = arr.Length;              // Độ dài mảng

// Static methods (Array class)
Array.Sort(arr);                   // Sắp xếp tăng dần
Array.Reverse(arr);                // Đảo ngược mảng
Array.IndexOf(arr, value);         // Tìm index (-1 nếu không có)
Array.Resize(ref arr, newSize);    // Thay đổi kích thước
Array.Copy(src, dest, length);     // Copy mảng
Array.Clear(arr, 0, arr.Length);   // Xóa hết (set = 0/null)

// Array.ConvertAll - QUAN TRỌNG cho đọc input
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
```

### 🎯 MOCK TEST 1 - Câu 1 (XOR Trick):
```csharp
// Pattern: Tìm số xuất hiện lẻ lần bằng XOR
public int FindSingleNumber(int[] nums)
{
    int result = 0;
    foreach (int num in nums)
    {
        result ^= num;  // XOR operator
    }
    return result;
}
```

### 🎯 MOCK TEST 2 - Câu 1 (Missing Number):
```csharp
// Pattern: Tìm số thiếu bằng Sum Formula
public int MissingNumber(int[] nums)
{
    int n = nums.Length;
    int expectedSum = n * (n + 1) / 2;  // Tổng từ 0 đến n
    int actualSum = 0;
    foreach (int num in nums)
    {
        actualSum += num;
    }
    return expectedSum - actualSum;
}

// Hoặc dùng XOR
public int MissingNumberXOR(int[] nums)
{
    int result = nums.Length;
    for (int i = 0; i < nums.Length; i++)
    {
        result ^= i ^ nums[i];
    }
    return result;
}
```

---

## 5️⃣ LIST OPERATIONS

### Khai báo & Khởi tạo:
```csharp
// Khai báo
List<int> list = new List<int>();
List<string> names = new List<string>();

// Khởi tạo với giá trị
List<int> list = new List<int> {1, 2, 3, 4, 5};

// Khởi tạo với capacity
List<int> list = new List<int>(100);  // Tối ưu performance
```

### Methods (HỌC THUỘC):
```csharp
list.Add(item);                   // Thêm 1 phần tử
list.AddRange(collection);        // Thêm nhiều phần tử
list.Remove(item);                // Xóa phần tử đầu tiên tìm thấy
list.RemoveAt(index);             // Xóa tại index
list.Insert(index, item);         // Chèn tại index
list.Clear();                     // Xóa hết

int count = list.Count;           // Số lượng phần tử (KHÔNG PHẢI .Length!)
bool contains = list.Contains(item);
int index = list.IndexOf(item);   // -1 nếu không tìm thấy
list.Sort();                      // Sắp xếp tăng dần
list.Reverse();                   // Đảo ngược

// Chuyển đổi
int[] arr = list.ToArray();       // List → Array
List<int> list = arr.ToList();    // Array → List
```

### 🎯 MOCK TEST 1 - Câu 3 (Spiral Matrix):
```csharp
// Pattern: Spiral traversal với boundaries
public List<int> SpiralOrder(int[][] matrix)
{
    List<int> result = new List<int>();
    if (matrix.Length == 0) return result;

    int top = 0, bottom = matrix.Length - 1;
    int left = 0, right = matrix[0].Length - 1;

    while (top <= bottom && left <= right)
    {
        // Đi từ trái sang phải (top row)
        for (int i = left; i <= right; i++)
            result.Add(matrix[top][i]);
        top++;

        // Đi từ trên xuống dưới (right column)
        for (int i = top; i <= bottom; i++)
            result.Add(matrix[i][right]);
        right--;

        // Đi từ phải sang trái (bottom row)
        if (top <= bottom)
        {
            for (int i = right; i >= left; i--)
                result.Add(matrix[bottom][i]);
            bottom--;
        }

        // Đi từ dưới lên trên (left column)
        if (left <= right)
        {
            for (int i = bottom; i >= top; i--)
                result.Add(matrix[i][left]);
            left++;
        }
    }

    return result;
}
```

---

## 6️⃣ DICTIONARY OPERATIONS

### Khai báo & Khởi tạo:
```csharp
// Khai báo
Dictionary<string, int> dict = new Dictionary<string, int>();

// Khởi tạo với giá trị
Dictionary<string, int> dict = new Dictionary<string, int>
{
    {"apple", 5},
    {"banana", 3}
};
```

### Methods (HỌC THUỘC):
```csharp
dict.Add(key, value);             // Thêm (throw exception nếu key đã tồn tại)
dict[key] = value;                // Thêm hoặc cập nhật
dict.Remove(key);                 // Xóa theo key
dict.Clear();                     // Xóa hết

int count = dict.Count;
bool hasKey = dict.ContainsKey(key);
bool hasValue = dict.ContainsValue(value);

// TryGetValue - An toàn hơn dict[key]
if (dict.TryGetValue(key, out int value))
{
    // Sử dụng value
}

// Duyệt Dictionary
foreach (var pair in dict)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

foreach (var key in dict.Keys)
{
    Console.WriteLine(key);
}

foreach (var value in dict.Values)
{
    Console.WriteLine(value);
}
```

### 🎯 Pattern: Frequency Counter (MOCK TEST 1 - Anagram):
```csharp
// Đếm tần suất xuất hiện
var freq = new Dictionary<char, int>();
foreach (char c in text)
{
    if (freq.ContainsKey(c))
        freq[c]++;
    else
        freq[c] = 1;
}

// Hoặc dùng TryGetValue (ngắn gọn hơn)
foreach (char c in text)
{
    if (!freq.TryGetValue(c, out int count))
        count = 0;
    freq[c] = count + 1;
}
```

---

## 7️⃣ STACK & QUEUE

### Stack (LIFO - Last In First Out):
```csharp
Stack<int> stack = new Stack<int>();

stack.Push(item);         // Thêm vào đỉnh
int top = stack.Pop();    // Lấy ra và xóa khỏi đỉnh
int peek = stack.Peek();  // Xem đỉnh (không xóa)
int count = stack.Count;
bool empty = stack.Count == 0;
stack.Clear();            // Xóa hết

// Duyệt Stack (không khuyến khích - mất thứ tự LIFO)
foreach (var item in stack)
{
    Console.WriteLine(item);
}
```

### Queue (FIFO - First In First Out):
```csharp
Queue<int> queue = new Queue<int>();

queue.Enqueue(item);      // Thêm vào cuối
int front = queue.Dequeue();  // Lấy ra và xóa khỏi đầu
int peek = queue.Peek();  // Xem đầu (không xóa)
int count = queue.Count;
bool empty = queue.Count == 0;
queue.Clear();            // Xóa hết
```

### 🎯 Pattern: Valid Parentheses (Stack):
```csharp
public bool IsValidParentheses(string s)
{
    Stack<char> stack = new Stack<char>();

    foreach (char c in s)
    {
        if (c == '(' || c == '[' || c == '{')
        {
            stack.Push(c);
        }
        else
        {
            if (stack.Count == 0) return false;
            char top = stack.Pop();
            if (c == ')' && top != '(') return false;
            if (c == ']' && top != '[') return false;
            if (c == '}' && top != '{') return false;
        }
    }

    return stack.Count == 0;
}
```

---

## 8️⃣ HASHSET

### Khai báo & Operations:
```csharp
HashSet<int> set = new HashSet<int>();

set.Add(item);            // Thêm (return false nếu đã tồn tại)
set.Remove(item);         // Xóa
set.Contains(item);       // Kiểm tra tồn tại - O(1)
int count = set.Count;
set.Clear();              // Xóa hết

// Set operations
set.UnionWith(other);         // Hợp
set.IntersectWith(other);     // Giao
set.ExceptWith(other);        // Trừ
```

### 🎯 MOCK TEST 3 - Câu 2 (Valid Sudoku):
```csharp
// Pattern: Kiểm tra duplicate bằng HashSet
public bool IsValidSudoku(char[][] board)
{
    // Tạo HashSet cho từng hàng, cột, box
    HashSet<char>[] rows = new HashSet<char>[9];
    HashSet<char>[] cols = new HashSet<char>[9];
    HashSet<char>[] boxes = new HashSet<char>[9];

    for (int i = 0; i < 9; i++)
    {
        rows[i] = new HashSet<char>();
        cols[i] = new HashSet<char>();
        boxes[i] = new HashSet<char>();
    }

    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            char c = board[i][j];
            if (c == '.') continue;

            // Tính box index
            int boxIndex = (i / 3) * 3 + (j / 3);

            // Kiểm tra duplicate
            if (!rows[i].Add(c) || !cols[j].Add(c) || !boxes[boxIndex].Add(c))
            {
                return false;
            }
        }
    }

    return true;
}
```

---

## 9️⃣ LINQ METHODS

### Basic LINQ (HỌC THUỘC):
```csharp
using System.Linq;  // BẮT BUỘC!

// Where - Lọc
var filtered = list.Where(x => x > 5).ToList();

// Select - Chuyển đổi
var doubled = list.Select(x => x * 2).ToList();

// OrderBy / OrderByDescending
var sorted = list.OrderBy(x => x).ToList();
var sortedDesc = list.OrderByDescending(x => x).ToList();

// ThenBy - Sắp xếp thứ cấp
var sorted = students.OrderBy(s => s.Grade)
                     .ThenByDescending(s => s.Score)
                     .ToList();

// Take / Skip
var top5 = list.OrderByDescending(x => x).Take(5).ToList();
var skipFirst10 = list.Skip(10).ToList();

// First / FirstOrDefault
int first = list.First();             // Throw exception nếu rỗng
int firstOrDefault = list.FirstOrDefault();  // Return default(T) nếu rỗng

// Last / LastOrDefault
int last = list.Last();
int lastOrDefault = list.LastOrDefault();

// Any / All
bool hasPositive = list.Any(x => x > 0);
bool allPositive = list.All(x => x > 0);

// Count
int count = list.Count(x => x > 5);

// Sum / Min / Max / Average
int sum = list.Sum();
int min = list.Min();
int max = list.Max();
double avg = list.Average();

// Distinct - Loại bỏ trùng lặp
var unique = list.Distinct().ToList();

// GroupBy
var grouped = students.GroupBy(s => s.Grade);
foreach (var group in grouped)
{
    Console.WriteLine($"Grade {group.Key}: {group.Count()} students");
}

// Contains
bool contains = list.Contains(5);

// Reverse
var reversed = list.Reverse().ToList();
```

### 🎯 MOCK TEST 3 - Câu 3 (Grade System):
```csharp
// Pattern: Sort với nhiều điều kiện
var sortedStudents = students.OrderByDescending(s => s.Average)
                             .ThenBy(s => s.Name)
                             .ToList();

// Pattern: GroupBy để đếm phân bố
var gradeDistribution = students.GroupBy(s => s.Grade)
                                .ToDictionary(g => g.Key, g => g.Count());

// Pattern: Filter và count
int atRiskCount = students.Count(s => s.Average < 5.5);
var atRiskStudents = students.Where(s => s.Average < 5.5).ToList();
```

---

## 🔟 MATH FUNCTIONS

```csharp
Math.Max(a, b)            // Giá trị lớn nhất
Math.Min(a, b)            // Giá trị nhỏ nhất
Math.Abs(x)               // Giá trị tuyệt đối
Math.Pow(x, y)            // x^y
Math.Sqrt(x)              // Căn bậc 2
Math.Floor(x)             // Làm tròn xuống
Math.Ceiling(x)           // Làm tròn lên
Math.Round(x)             // Làm tròn gần nhất
Math.Round(x, 2)          // Làm tròn đến 2 chữ số thập phân

// Constants
Math.PI                   // 3.14159...
Math.E                    // 2.71828...
```

### 🎯 MOCK TEST 2 - Câu 2 (Count Primes):
```csharp
// Pattern: Sieve of Eratosthenes
public int CountPrimes(int left, int right)
{
    if (right < 2) return 0;

    bool[] isPrime = new bool[right + 1];
    for (int i = 2; i <= right; i++)
        isPrime[i] = true;

    for (int i = 2; i * i <= right; i++)  // Math.Sqrt không cần thiết
    {
        if (isPrime[i])
        {
            for (int j = i * i; j <= right; j += i)
                isPrime[j] = false;
        }
    }

    int count = 0;
    for (int i = Math.Max(2, left); i <= right; i++)
    {
        if (isPrime[i]) count++;
    }

    return count;
}
```

---

## 1️⃣1️⃣ TYPE CONVERSION

### Parse vs TryParse:
```csharp
// Parse - Throw exception nếu fail
int num = int.Parse("123");
double d = double.Parse("3.14");
bool b = bool.Parse("true");

// TryParse - An toàn hơn (KHUYÊN DÙNG)
if (int.TryParse(input, out int result))
{
    // Success - sử dụng result
}
else
{
    // Fail - xử lý lỗi
}

if (double.TryParse(input, out double d))
{
    // ...
}
```

### Convert class:
```csharp
int num = Convert.ToInt32("123");
double d = Convert.ToDouble("3.14");
string s = Convert.ToString(123);
```

### Casting:
```csharp
double d = 3.14;
int num = (int)d;  // Explicit cast - mất phần thập phân

object obj = "hello";
string s = (string)obj;  // Cast từ object
```

---

## 1️⃣2️⃣ FILE I/O (QUAN TRỌNG)

### 📖 Xem chi tiết: [FILE_IO_CHEATSHEET.md](FILE_IO_CHEATSHEET.md)

### Quick Reference:

#### Đọc file:
```csharp
using System.IO;  // BẮT BUỘC!

// Cách 1: ReadAllLines (đọc hết vào memory)
string[] lines = File.ReadAllLines("input.txt");

// Cách 2: StreamReader (KHUYÊN DÙNG - tiết kiệm memory)
using (StreamReader reader = new StreamReader("input.txt"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        // Xử lý từng dòng
    }
}

// Kiểm tra file tồn tại
if (File.Exists("input.txt"))
{
    // ...
}
```

#### Ghi file:
```csharp
// Cách 1: WriteAllLines (ghi mảng)
File.WriteAllLines("output.txt", lines);

// Cách 2: StreamWriter (KHUYÊN DÙNG)
using (StreamWriter writer = new StreamWriter("output.txt"))
{
    writer.WriteLine("Line 1");
    writer.WriteLine("Line 2");
}

// Append (ghi thêm)
using (StreamWriter writer = new StreamWriter("output.txt", true))  // true = append mode
{
    writer.WriteLine("Appended line");
}
```

### 🎯 MOCK TEST 2 - Câu 3 (Log Analyzer):
```csharp
// Pattern: Đọc và parse file log
public class LogEntry
{
    public string Timestamp { get; set; }
    public string Level { get; set; }
    public string Message { get; set; }
}

public List<LogEntry> ReadLogFile(string filePath)
{
    var logs = new List<LogEntry>();

    if (!File.Exists(filePath))
        throw new FileNotFoundException($"File not found: {filePath}");

    using (StreamReader reader = new StreamReader(filePath))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            // Parse: [2024-10-15 10:23:45] [INFO] User login successful
            int firstClose = line.IndexOf(']');
            int secondOpen = line.IndexOf('[', firstClose);
            int secondClose = line.IndexOf(']', secondOpen);

            if (firstClose == -1 || secondClose == -1) continue;

            string timestamp = line.Substring(1, firstClose - 1);
            string level = line.Substring(secondOpen + 1, secondClose - secondOpen - 1);
            string message = line.Substring(secondClose + 2).Trim();

            logs.Add(new LogEntry
            {
                Timestamp = timestamp,
                Level = level,
                Message = message
            });
        }
    }

    return logs;
}

// Pattern: Ghi report
public void GenerateReport(List<LogEntry> logs, string outputPath)
{
    using (StreamWriter writer = new StreamWriter(outputPath))
    {
        writer.WriteLine("========== SERVER LOG ANALYSIS ==========");
        writer.WriteLine($"Total Logs: {logs.Count}");
        writer.WriteLine();

        // Đếm frequency
        var levelCounts = new Dictionary<string, int>();
        foreach (var log in logs)
        {
            if (!levelCounts.ContainsKey(log.Level))
                levelCounts[log.Level] = 0;
            levelCounts[log.Level]++;
        }

        writer.WriteLine("LOG LEVEL STATISTICS:");
        foreach (var pair in levelCounts.OrderBy(p => p.Key))
        {
            double percentage = (pair.Value * 100.0) / logs.Count;
            writer.WriteLine($"- {pair.Key}: {pair.Value} ({percentage:F2}%)");
        }

        // Tìm most frequent
        var mostFrequent = levelCounts.OrderByDescending(p => p.Value).First();
        writer.WriteLine();
        writer.WriteLine($"MOST FREQUENT LEVEL: {mostFrequent.Key}");

        // List ERROR messages
        var errors = logs.Where(l => l.Level == "ERROR").ToList();
        if (errors.Count > 0)
        {
            writer.WriteLine();
            writer.WriteLine("ERROR MESSAGES:");
            for (int i = 0; i < errors.Count; i++)
            {
                writer.WriteLine($"{i + 1}. {errors[i].Message}");
            }
        }

        writer.WriteLine("=========================================");
    }
}
```

---

## 1️⃣3️⃣ DATETIME (QUAN TRỌNG)

### 📖 Xem chi tiết: [DATETIME_CHEATSHEET.md](DATETIME_CHEATSHEET.md)

### Quick Reference:

```csharp
// Current date/time
DateTime now = DateTime.Now;        // Local time
DateTime utcNow = DateTime.UtcNow;  // UTC time
DateTime today = DateTime.Today;    // Chỉ ngày (00:00:00)

// Properties
int year = now.Year;
int month = now.Month;        // 1-12
int day = now.Day;
int hour = now.Hour;          // 0-23
int minute = now.Minute;
int second = now.Second;
DayOfWeek dayOfWeek = now.DayOfWeek;  // Sunday, Monday, etc.

// Parse
DateTime dt = DateTime.Parse("2024-10-15");
DateTime dt = DateTime.Parse("15/10/2024");

// TryParse (AN TOÀN HƠN)
if (DateTime.TryParse(input, out DateTime result))
{
    // Success
}

// Format
string formatted = dt.ToString("yyyy-MM-dd");        // 2024-10-15
string formatted = dt.ToString("dd/MM/yyyy");        // 15/10/2024
string formatted = dt.ToString("HH:mm:ss");          // 14:30:45
string formatted = dt.ToString("yyyy-MM-dd HH:mm"); // 2024-10-15 14:30

// Calculations
DateTime tomorrow = now.AddDays(1);
DateTime nextMonth = now.AddMonths(1);
DateTime nextYear = now.AddYears(1);
DateTime twoHoursLater = now.AddHours(2);

// TimeSpan - Khoảng cách giữa 2 dates
TimeSpan diff = dt2 - dt1;
int days = diff.Days;
double totalDays = diff.TotalDays;
double totalHours = diff.TotalHours;

// Tính tuổi
int CalculateAge(DateTime birthDate)
{
    int age = DateTime.Today.Year - birthDate.Year;
    if (birthDate.Date > DateTime.Today.AddYears(-age))
        age--;
    return age;
}

// Năm nhuận
bool isLeapYear = DateTime.IsLeapYear(2024);
```

---

## 1️⃣4️⃣ LOOP PATTERNS

### For loop:
```csharp
// Standard for
for (int i = 0; i < n; i++)
{
    // ...
}

// Reverse for
for (int i = n - 1; i >= 0; i--)
{
    // ...
}

// Step by 2
for (int i = 0; i < n; i += 2)
{
    // ...
}

// Nested for (2D array)
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}
```

### Foreach loop:
```csharp
// Array
foreach (int num in arr)
{
    Console.WriteLine(num);
}

// List
foreach (string name in names)
{
    Console.WriteLine(name);
}

// Dictionary
foreach (var pair in dict)
{
    Console.WriteLine($"{pair.Key}: {pair.Value}");
}

// String (duyệt từng ký tự)
foreach (char c in str)
{
    Console.WriteLine(c);
}
```

### While loop:
```csharp
while (condition)
{
    // ...
}

// Do-while (chạy ít nhất 1 lần)
do
{
    // ...
} while (condition);
```

### 🎯 MOCK TEST 3 - Câu 1 (Merge Arrays):
```csharp
// Pattern: Two Pointers (merge từ cuối về đầu)
public void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int p1 = m - 1;      // Pointer cuối nums1
    int p2 = n - 1;      // Pointer cuối nums2
    int p = m + n - 1;   // Pointer cuối result

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
}
```

---

## 1️⃣5️⃣ EXCEPTION HANDLING

```csharp
// Try-catch
try
{
    int result = int.Parse(input);
    int division = 10 / result;
}
catch (FormatException ex)
{
    Console.WriteLine("Invalid number format");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Cannot divide by zero");
}
catch (Exception ex)  // Catch all
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    // Luôn chạy, dù có lỗi hay không
    Console.WriteLine("Cleanup");
}

// Throw exception
if (value < 0)
    throw new ArgumentException("Value must be positive");

// File I/O với exception handling
try
{
    using (StreamReader reader = new StreamReader("file.txt"))
    {
        // Read file
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"File not found: {ex.Message}");
}
catch (IOException ex)
{
    Console.WriteLine($"I/O error: {ex.Message}");
}
```

---

## 1️⃣6️⃣ COMMON PATTERNS TỪ MOCK TESTS

### Pattern 1: XOR Trick (Tìm số xuất hiện lẻ lần)
```csharp
// MOCK TEST 1 - Câu 1
int result = 0;
foreach (int num in nums)
    result ^= num;
return result;
```

### Pattern 2: Two Pointers
```csharp
// Palindrome check
int left = 0, right = s.Length - 1;
while (left < right)
{
    if (s[left] != s[right]) return false;
    left++;
    right--;
}

// Merge sorted arrays (MOCK TEST 3 - Câu 1)
// Đã có ở phần Loop Patterns
```

### Pattern 3: HashMap/Dictionary Frequency Counter
```csharp
// MOCK TEST 1 - Câu 2 (Anagram)
// Đã có ở phần String Operations
```

### Pattern 4: HashSet for Duplicates
```csharp
// MOCK TEST 3 - Câu 2 (Valid Sudoku)
// Đã có ở phần HashSet
```

### Pattern 5: Sieve of Eratosthenes
```csharp
// MOCK TEST 2 - Câu 2 (Count Primes)
// Đã có ở phần Math Functions
```

### Pattern 6: Spiral Matrix Traversal
```csharp
// MOCK TEST 1 - Câu 3
// Đã có ở phần List Operations
```

### Pattern 7: File I/O + Parsing
```csharp
// MOCK TEST 2 - Câu 3 (Log Analyzer)
// MOCK TEST 3 - Câu 3 (Grade System)
// Đã có ở phần File I/O
```

---

## 🎯 TEMPLATE CODE - COPY VÀO ĐẦU MỖI BÀI

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

public class Solution
{
    public static void Main(string[] args)
    {
        // Test code here
    }

    // Your methods here
}
```

---

## ⚡ TIPS QUAN TRỌNG KHI KHÔNG CÓ INTELLISENSE

### 1. Các lỗi thường gặp:
```csharp
// ❌ SAI
list.Length           // List không có .Length
array.Count           // Array không có .Count

// ✅ ĐÚNG
list.Count            // List dùng .Count
array.Length          // Array dùng .Length
```

### 2. Nhớ syntax chính xác:
```csharp
// Dictionary
if (dict.ContainsKey(key))  // KHÔNG PHẢI Contains!

// Array conversion
int[] arr = Array.ConvertAll(input.Split(), int.Parse);  // KHÔNG PHẢI Convert!

// LINQ
list.Where(x => x > 5).ToList();  // PHẢI có ToList() nếu muốn List
```

### 3. Các từ khóa viết hoa/thường:
```csharp
// ✅ ĐÚNG (viết thường)
int, double, bool, string, char, void, new, if, else, for, foreach, while

// ✅ ĐÚNG (viết hoa)
Int32, Double, Boolean, String, Char
Console, Math, Array, List, Dictionary, File, DateTime
```

### 4. Namespace phải nhớ:
```csharp
System.Collections.Generic   // KHÔNG PHẢI System.Collections!
System.Linq                  // Cho LINQ methods
System.IO                    // Cho File operations
```

---

## 📝 PRACTICE STRATEGY

### Tuần 1-2: Viết tay
1. In cheatsheet này ra giấy
2. Viết code trên giấy/notepad (không IDE)
3. Ghi nhớ các method signature

### Tuần 3: Tắt IntelliSense
1. Trong VS Code: Settings → "Editor: Quick Suggestions" → Off
2. Trong Visual Studio: Tools → Options → Text Editor → All Languages → IntelliSense → Disable
3. Làm lại các bài MOCK_TEST_1, 2, 3

### Tuần 4: Mock Test
1. Làm 3 mock tests KHÔNG xem cheatsheet
2. Chỉ xem khi thực sự cần
3. Ghi nhớ những gì còn quên

---

## 🔥 NGÀY THI - CHECKLIST

### Mở đầu:
1. ✅ Viết using statements đầy đủ
2. ✅ Viết template Main method
3. ✅ Đọc kỹ đề, xác định pattern

### Trong khi làm:
1. ✅ Viết comments giải thích logic
2. ✅ Test với edge cases
3. ✅ Kiểm tra lỗi compile thường gặp (Length vs Count, etc.)

### Trước khi submit:
1. ✅ Test với tất cả test cases trong đề
2. ✅ Kiểm tra xử lý edge cases (null, empty, single element)
3. ✅ Đảm bảo code compile không lỗi

---

**🎯 HỌC THUỘC CHEATSHEET NÀY = TỰ TIN 100% KHI THI!**

**🔗 Liên kết:**
- [FILE_IO_CHEATSHEET.md](FILE_IO_CHEATSHEET.md)
- [DATETIME_CHEATSHEET.md](DATETIME_CHEATSHEET.md)
- [MOCK_TEST_1.md](MOCK_TEST_1.md)
- [MOCK_TEST_2.md](MOCK_TEST_2.md)
- [MOCK_TEST_3.md](MOCK_TEST_3.md)

---

💪 **CHÚC BẠN THÀNH CÔNG!** 🚀
