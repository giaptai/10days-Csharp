# 🎯 MOCK TEST 2 - ROOKIE SIMULATION (FILE I/O)
**Thời gian: 90 phút | 3 câu hỏi: 2 Easy + 1 Medium (có File I/O)**

---

## ⭐ Câu 1: Tìm số bị thiếu trong dãy (Easy)
**Độ khó:** Easy | **Thời gian gợi ý:** 20 phút

### Đề bài:
Cho một mảng `nums` chứa `n` số phân biệt trong khoảng `[0, n]`.

Hãy trả về số duy nhất trong khoảng đó bị thiếu trong mảng.

### Yêu cầu:
- Time complexity: O(n)
- Space complexity: O(1)
- **Gợi ý:** Sử dụng công thức tổng hoặc XOR

### Input/Output:
```
Input: nums = [3, 0, 1]
Output: 2
Giải thích: n = 3, dãy [0, 1, 2, 3], thiếu số 2

Input: nums = [0, 1]
Output: 2
Giải thích: n = 2, dãy [0, 1, 2], thiếu số 2

Input: nums = [9, 6, 4, 2, 3, 5, 7, 0, 1]
Output: 8
```

### Test cases bổ sung:
```csharp
// Test 1: Thiếu số đầu
nums = [1, 2, 3] → Output: 0

// Test 2: Thiếu số cuối
nums = [0, 1, 2] → Output: 3

// Test 3: Mảng 1 phần tử
nums = [0] → Output: 1
nums = [1] → Output: 0
```

### Approach gợi ý:
1. **Cách 1 - Sum formula:** Tính tổng từ 0 đến n, trừ đi tổng mảng
2. **Cách 2 - XOR:** XOR tất cả số từ 0 đến n, XOR với tất cả phần tử trong mảng

---

## ⭐ Câu 2: Đếm số nguyên tố trong khoảng (Easy)
**Độ khó:** Easy | **Thời gian gợi ý:** 25 phút

### Đề bài:
Cho hai số nguyên `left` và `right`, hãy đếm số lượng số nguyên tố trong khoảng `[left, right]` (bao gồm cả hai đầu).

### Yêu cầu:
- Sử dụng **Sieve of Eratosthenes** để tối ưu
- Xử lý đúng edge cases: số âm, 0, 1

### Input/Output:
```
Input: left = 10, right = 20
Output: 4
Giải thích: Các số nguyên tố trong [10, 20]: 11, 13, 17, 19

Input: left = 1, right = 10
Output: 4
Giải thích: 2, 3, 5, 7

Input: left = 5, right = 5
Output: 1
Giải thích: 5 là số nguyên tố
```

### Test cases bổ sung:
```csharp
// Test 1: Không có số nguyên tố
left = 0, right = 1 → Output: 0

// Test 2: Số âm
left = -10, right = 10 → Output: 4 (2, 3, 5, 7)

// Test 3: Số lớn
left = 1, right = 100 → Output: 25

// Test 4: Range rộng
left = 100, right = 200 → Output: 21
```

### Gợi ý:
```csharp
// Sieve of Eratosthenes pseudocode
1. Tạo mảng boolean isPrime[right+1], set tất cả = true
2. isPrime[0] = isPrime[1] = false
3. Với i từ 2 đến sqrt(right):
   - Nếu isPrime[i] == true:
     - Đánh dấu tất cả bội số của i là false
4. Đếm số lượng isPrime[i] == true trong [left, right]
```

---

## ⭐⭐ Câu 3: Xử lý Log File và thống kê (Medium + File I/O)
**Độ khó:** Medium | **Thời gian gợi ý:** 45 phút

### Đề bài:
Bạn được cho một file log `server.log` chứa các dòng log từ server với format:

```
[TIMESTAMP] [LEVEL] MESSAGE
```

Ví dụ:
```
[2024-10-15 10:23:45] [INFO] User login successful
[2024-10-15 10:24:12] [ERROR] Database connection failed
[2024-10-15 10:25:33] [WARNING] High memory usage detected
[2024-10-15 10:26:01] [INFO] Data saved successfully
[2024-10-15 10:27:15] [ERROR] API timeout
[2024-10-15 10:28:45] [ERROR] File not found
```

### Yêu cầu:
Viết chương trình C# thực hiện các nhiệm vụ sau:

1. **Đọc file `server.log`**
2. **Phân tích và thống kê:**
   - Tổng số log mỗi loại (INFO, WARNING, ERROR)
   - Tìm loại log xuất hiện nhiều nhất
   - Liệt kê tất cả các ERROR messages (chỉ phần MESSAGE)
3. **Xuất kết quả ra file `report.txt`** với format:

```
========== SERVER LOG ANALYSIS ==========
Total Logs: 6

LOG LEVEL STATISTICS:
- INFO: 2 (33.33%)
- WARNING: 1 (16.67%)
- ERROR: 3 (50.00%)

MOST FREQUENT LEVEL: ERROR

ERROR MESSAGES:
1. Database connection failed
2. API timeout
3. File not found
=========================================
```

### Input file mẫu (server.log):
Tạo file `server.log` trong cùng thư mục với nội dung:
```
[2024-10-15 10:23:45] [INFO] User login successful
[2024-10-15 10:24:12] [ERROR] Database connection failed
[2024-10-15 10:25:33] [WARNING] High memory usage detected
[2024-10-15 10:26:01] [INFO] Data saved successfully
[2024-10-15 10:27:15] [ERROR] API timeout
[2024-10-15 10:28:45] [ERROR] File not found
[2024-10-15 10:30:22] [INFO] Backup completed
[2024-10-15 10:31:10] [WARNING] Disk space low
[2024-10-15 10:32:45] [ERROR] Invalid credentials
[2024-10-15 10:33:12] [INFO] Service restarted
```

### Code Structure gợi ý:
```csharp
public class LogAnalyzer
{
    // Class để lưu thông tin một dòng log
    public class LogEntry
    {
        public string Timestamp { get; set; }
        public string Level { get; set; }
        public string Message { get; set; }
    }

    // Đọc và parse log file
    public List<LogEntry> ReadLogFile(string filePath)
    {
        // Your code here
    }

    // Phân tích và tạo report
    public void GenerateReport(List<LogEntry> logs, string outputPath)
    {
        // Your code here
    }
}
```

### Yêu cầu kỹ thuật:
- ✅ Sử dụng `StreamReader` để đọc file
- ✅ Sử dụng `StreamWriter` để ghi file
- ✅ Parse chuỗi đúng format (có thể dùng Regex hoặc string split)
- ✅ Sử dụng Dictionary để đếm tần suất
- ✅ Xử lý exception: file không tồn tại, format sai
- ✅ Format số thập phân đến 2 chữ số (33.33%)

### Test cases bổ sung:
```csharp
// Test 1: File rỗng
Input: empty file
Output: Total Logs: 0

// Test 2: File chỉ có 1 loại log
Input: All INFO logs
Output: MOST FREQUENT LEVEL: INFO

// Test 3: File có dòng format sai
Input: Mixed valid/invalid lines
Output: Bỏ qua dòng invalid, chỉ xử lý dòng hợp lệ
```

---

## 📝 Hướng dẫn nộp bài:

1. Tạo file `MockTest2.cs` trong project
2. Implement cả 3 functions:

```csharp
public class Solution
{
    // Câu 1
    public int MissingNumber(int[] nums)
    {
        // Your code here
    }

    // Câu 2
    public int CountPrimes(int left, int right)
    {
        // Your code here
    }

    // Câu 3
    public class LogAnalyzer
    {
        public class LogEntry
        {
            public string Timestamp { get; set; }
            public string Level { get; set; }
            public string Message { get; set; }
        }

        public List<LogEntry> ReadLogFile(string filePath)
        {
            // Your code here
        }

        public void GenerateReport(List<LogEntry> logs, string outputPath)
        {
            // Your code here
        }
    }
}
```

3. Tạo file test `server.log` và chạy test
4. Kiểm tra file output `report.txt`

---

## ⏰ Chiến thuật làm bài:

- **0-20 phút:** Làm câu 1 (Missing Number - dễ)
- **20-45 phút:** Làm câu 2 (Count Primes - cần implement Sieve)
- **45-90 phút:** Làm câu 3 (Log Analyzer - phức tạp nhất, có File I/O)

---

## 🎯 Tips quan trọng cho câu 3:

1. **Đọc file an toàn:**
```csharp
if (!File.Exists(filePath))
{
    throw new FileNotFoundException($"File not found: {filePath}");
}
```

2. **Parse log line:**
```csharp
// Regex pattern: \[(.+?)\] \[(.+?)\] (.+)
// Hoặc dùng IndexOf và Substring
```

3. **Tính phần trăm:**
```csharp
double percentage = (count * 100.0) / total;
string formatted = percentage.ToString("F2"); // 33.33
```

---

**Đây là bài test sát với thực tế nhất vì có File I/O!** 🔥

**Hãy bắt đầu làm bài và thông báo cho tôi khi hoàn thành!** 🚀
