# 🎯 MOCK TEST 3 - ROOKIE SIMULATION (CHALLENGE)
**Thời gian: 90 phút | 3 câu hỏi: 2 Easy + 1 Medium (Đề khó hơn)**

---

## ⭐ Câu 1: Merge Two Sorted Arrays (Easy)
**Độ khó:** Easy | **Thời gian gợi ý:** 20 phút

### Đề bài:
Cho hai mảng đã được sắp xếp tăng dần `nums1` và `nums2`.

Hãy **merge (gộp)** hai mảng này thành một mảng duy nhất được sắp xếp tăng dần.

**Lưu ý:** `nums1` có độ dài `m + n`, trong đó `m` phần tử đầu tiên là các phần tử thực sự, và `n` phần tử cuối là `0` (để chứa các phần tử từ `nums2`).

Bạn phải merge `nums2` vào `nums1` **in-place** (không tạo mảng mới).

### Yêu cầu:
- Space complexity: O(1) - không tạo mảng mới
- Time complexity: O(m + n)
- Merge từ **cuối mảng về đầu** để tối ưu

### Input/Output:
```
Input:
nums1 = [1, 2, 3, 0, 0, 0], m = 3
nums2 = [2, 5, 6], n = 3

Output:
nums1 = [1, 2, 2, 3, 5, 6]

Giải thích:
Merge [1,2,3] và [2,5,6] → [1,2,2,3,5,6]
```

```
Input:
nums1 = [1], m = 1
nums2 = [], n = 0

Output:
nums1 = [1]
```

```
Input:
nums1 = [0], m = 0
nums2 = [1], n = 1

Output:
nums1 = [1]
```

### Test cases bổ sung:
```csharp
// Test 1: nums1 lớn hơn tất cả
nums1 = [4, 5, 6, 0, 0, 0], m = 3
nums2 = [1, 2, 3], n = 3
Output: [1, 2, 3, 4, 5, 6]

// Test 2: nums2 lớn hơn tất cả
nums1 = [1, 2, 3, 0, 0, 0], m = 3
nums2 = [4, 5, 6], n = 3
Output: [1, 2, 3, 4, 5, 6]

// Test 3: Có phần tử trùng
nums1 = [1, 2, 2, 0, 0], m = 3
nums2 = [2, 2], n = 2
Output: [1, 2, 2, 2, 2]
```

### Gợi ý:
```csharp
// Approach: Merge từ cuối về đầu
1. Đặt 3 pointers:
   - p1 = m - 1 (phần tử cuối của nums1 thực sự)
   - p2 = n - 1 (phần tử cuối của nums2)
   - p = m + n - 1 (vị trí cuối của nums1)

2. So sánh nums1[p1] vs nums2[p2]:
   - Nếu nums1[p1] > nums2[p2]: nums1[p] = nums1[p1], p1--, p--
   - Ngược lại: nums1[p] = nums2[p2], p2--, p--

3. Nếu còn phần tử trong nums2: copy hết vào nums1
```

---

## ⭐ Câu 2: Valid Sudoku Checker (Easy-Medium)
**Độ khó:** Easy-Medium | **Thời gian gợi ý:** 25-30 phút

### Đề bài:
Xác định xem một bảng Sudoku 9x9 có hợp lệ hay không. Chỉ cần kiểm tra các ô **đã điền** theo các quy tắc sau:

1. Mỗi **hàng** phải chứa các số từ 1-9 mà **không lặp lại**
2. Mỗi **cột** phải chứa các số từ 1-9 mà **không lặp lại**
3. Mỗi **ô con 3x3** phải chứa các số từ 1-9 mà **không lặp lại**

**Lưu ý:**
- Bảng Sudoku có thể chỉ được điền một phần (các ô trống được biểu diễn bằng `'.'`)
- Chỉ cần kiểm tra các ô **đã điền** có hợp lệ hay không

### Input/Output:
```
Input: board =
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]

Output: true
```

```
Input: board =
[["8","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]

Output: false

Giải thích: Giống với ví dụ trước, ngoại trừ số 8 ở hàng đầu tiên
được lặp lại ở cột đầu tiên (hàng 3, cột 0 cũng là 8)
```

### Test cases bổ sung:
```csharp
// Test 1: Board hợp lệ đơn giản
[["1","2",".",".",".",".",".",".","."]]
Output: true

// Test 2: Duplicate trong cùng hàng
[["1","1",".",".",".",".",".",".","."]]
Output: false

// Test 3: Duplicate trong cùng cột
board[0][0] = "1"
board[1][0] = "1"
Output: false
```

### Yêu cầu:
- Xử lý cả 3 điều kiện: hàng, cột, ô con 3x3
- Sử dụng HashSet để check duplicates hiệu quả
- Code clean, dễ hiểu

### Gợi ý:
```csharp
// Approach: Dùng HashSet cho từng hàng, cột, và box
1. Tạo 3 mảng HashSet:
   - HashSet<char>[] rows = new HashSet<char>[9];
   - HashSet<char>[] cols = new HashSet<char>[9];
   - HashSet<char>[] boxes = new HashSet<char>[9];

2. Duyệt qua từng ô (i, j):
   - Nếu board[i][j] == '.': skip
   - Tính box index: boxIndex = (i / 3) * 3 + (j / 3)
   - Kiểm tra xem char đã tồn tại trong rows[i], cols[j], boxes[boxIndex]
   - Nếu có: return false
   - Nếu không: thêm vào cả 3 sets

3. Return true nếu không có duplicate
```

---

## ⭐⭐ Câu 3: Student Grade Management System (Medium + File I/O)
**Độ khó:** Medium | **Thời gian gợi ý:** 40-45 phút

### Đề bài:
Xây dựng hệ thống quản lý điểm sinh viên với các chức năng:

1. **Đọc dữ liệu** từ file `students.csv`
2. **Tính toán** điểm trung bình và xếp loại
3. **Sắp xếp** sinh viên theo điểm TB giảm dần
4. **Xuất báo cáo** ra file `report.txt`

### Input file format (`students.csv`):
```csv
StudentID,Name,Math,Physics,Chemistry,English
SV001,Nguyen Van A,8.5,7.0,9.0,8.0
SV002,Tran Thi B,6.5,5.0,7.5,6.0
SV003,Le Van C,9.0,9.5,8.5,9.0
SV004,Pham Thi D,5.0,4.5,6.0,5.5
SV005,Hoang Van E,7.5,8.0,7.0,8.5
```

### Output file format (`report.txt`):
```
=============== STUDENT GRADE REPORT ===============
Total Students: 5

TOP PERFORMERS:
Rank 1: Le Van C (SV003) - Average: 9.00 - Grade: EXCELLENT
Rank 2: Hoang Van E (SV005) - Average: 7.75 - Grade: GOOD
Rank 3: Nguyen Van A (SV001) - Average: 8.13 - Grade: GOOD

GRADE DISTRIBUTION:
- EXCELLENT (8.5-10.0): 1 student(s) - 20.00%
- GOOD (7.0-8.49): 2 student(s) - 40.00%
- AVERAGE (5.5-6.99): 1 student(s) - 20.00%
- BELOW AVERAGE (4.0-5.49): 1 student(s) - 20.00%
- FAIL (0-3.99): 0 student(s) - 0.00%

STUDENTS AT RISK (Average < 5.5):
- Pham Thi D (SV004) - Average: 5.25 - Grade: BELOW AVERAGE

====================================================
```

### Yêu cầu chi tiết:

#### 1. Class Structure:
```csharp
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

    public void CalculateAverage()
    {
        // Tính điểm TB của 4 môn
    }

    public void DetermineGrade()
    {
        // Xếp loại dựa trên Average
        // EXCELLENT: 8.5-10.0
        // GOOD: 7.0-8.49
        // AVERAGE: 5.5-6.99
        // BELOW AVERAGE: 4.0-5.49
        // FAIL: 0-3.99
    }
}

public class GradeManagementSystem
{
    public List<Student> ReadStudentsFromCSV(string filePath)
    {
        // Đọc file CSV và parse thành List<Student>
    }

    public void GenerateReport(List<Student> students, string outputPath)
    {
        // Tạo báo cáo theo format yêu cầu
    }
}
```

#### 2. Chức năng cần implement:

**a) Đọc CSV file:**
- Bỏ qua dòng header
- Parse mỗi dòng thành object Student
- Handle exception: file không tồn tại, format sai

**b) Tính toán:**
- Average = (Math + Physics + Chemistry + English) / 4
- Format 2 chữ số thập phân (8.13)
- Xếp loại theo thang điểm

**c) Sắp xếp:**
- Sort students theo Average giảng dần
- Nếu Average bằng nhau: sort theo Name (A-Z)

**d) Báo cáo gồm:**
- Tổng số sinh viên
- Top 3 sinh viên (nếu có)
- Phân bố xếp loại (số lượng + phần trăm)
- Danh sách sinh viên yếu kém (Average < 5.5)

#### 3. Test với file mẫu:

Tạo file `students.csv`:
```csv
StudentID,Name,Math,Physics,Chemistry,English
SV001,Nguyen Van A,8.5,7.0,9.0,8.0
SV002,Tran Thi B,6.5,5.0,7.5,6.0
SV003,Le Van C,9.0,9.5,8.5,9.0
SV004,Pham Thi D,5.0,4.5,6.0,5.5
SV005,Hoang Van E,7.5,8.0,7.0,8.5
SV006,Do Van F,3.5,4.0,3.0,4.5
SV007,Vu Thi G,8.0,8.5,9.0,8.0
SV008,Bui Van H,6.0,6.5,5.5,7.0
```

### Test cases bổ sung:
```csharp
// Test 1: File empty
Input: empty CSV
Output: Total Students: 0, no other sections

// Test 2: File 1 dòng (chỉ header)
Output: Total Students: 0

// Test 3: Sinh viên có điểm bằng nhau
SV009: Average = 7.5
SV010: Average = 7.5
Output: Sort theo Name (Alphabetical)

// Test 4: Tất cả sinh viên đều xuất sắc
All averages >= 8.5
Output: EXCELLENT: 100%
```

### Gợi ý implementation:

```csharp
// 1. Đọc CSV
public List<Student> ReadStudentsFromCSV(string filePath)
{
    var students = new List<Student>();
    var lines = File.ReadAllLines(filePath);

    for (int i = 1; i < lines.Length; i++) // Skip header
    {
        var parts = lines[i].Split(',');
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

    return students;
}

// 2. Sort
students = students.OrderByDescending(s => s.Average)
                   .ThenBy(s => s.Name)
                   .ToList();

// 3. Tính phân bố
var gradeDistribution = students.GroupBy(s => s.Grade)
                                .ToDictionary(g => g.Key, g => g.Count());
```

---

## 📝 Hướng dẫn nộp bài:

1. Tạo file `MockTest3.cs`
2. Implement cả 3 bài:

```csharp
public class Solution
{
    // Câu 1
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        // Your code here
    }

    // Câu 2
    public bool IsValidSudoku(char[][] board)
    {
        // Your code here
    }

    // Câu 3
    public class Student
    {
        // Class implementation
    }

    public class GradeManagementSystem
    {
        // System implementation
    }
}
```

3. Test với các file CSV mẫu
4. Verify output report.txt

---

## ⏰ Chiến thuật làm bài:

- **0-20 phút:** Câu 1 (Merge Arrays - khó hơn dự kiến vì in-place)
- **20-50 phút:** Câu 2 (Valid Sudoku - cần hiểu logic 3 điều kiện)
- **50-90 phút:** Câu 3 (Grade System - phức tạp nhất, nhiều chức năng)

---

## 🎯 Đánh giá độ khó:

**Mock Test 3 khó hơn Test 1 và 2 vì:**
- ✅ Câu 1: In-place merge khó hơn bình thường
- ✅ Câu 2: Valid Sudoku cần hiểu logic 3 chiều (row/col/box)
- ✅ Câu 3: Hệ thống hoàn chỉnh với nhiều chức năng + LINQ

**Nếu làm được Test 3 trong 90 phút → Bạn sẵn sàng cho!** 💪

---

**Hãy thử sức với đề này! Đây là thử thách cuối cùng trước khi thi thật!** 🔥🚀
