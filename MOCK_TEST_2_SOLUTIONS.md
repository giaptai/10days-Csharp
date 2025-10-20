# 🎯 MOCK TEST 2 - ĐÁP ÁN CHI TIẾT (FILE I/O)

---

## ⭐ Câu 1: Tìm số bị thiếu trong dãy

### 📝 Đề bài:
Cho mảng `nums` chứa `n` số phân biệt trong khoảng `[0, n]`. Tìm số duy nhất bị thiếu.

### 💡 Giải thích thuật toán:

**Approach 1: Sum Formula (Dễ hiểu nhất)**
- Tổng từ 0 đến n: `sum = n × (n + 1) / 2`
- Tổng các số trong mảng: `actualSum`
- Số thiếu = `expectedSum - actualSum`

**Ví dụ:** `nums = [3, 0, 1]` (n = 3)
```
Expected: 0 + 1 + 2 + 3 = 6
Actual: 3 + 0 + 1 = 4
Missing: 6 - 4 = 2 ✓
```

**Approach 2: XOR (Tối ưu hơn, tránh overflow)**
- XOR tất cả số từ 0 đến n
- XOR với tất cả số trong mảng
- Kết quả chính là số thiếu

### ✅ Code Solution 1: Sum Formula

```csharp
using System;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;

        // Tính tổng từ 0 đến n
        int expectedSum = n * (n + 1) / 2;

        // Tính tổng các phần tử trong mảng
        int actualSum = 0;
        foreach (int num in nums)
        {
            actualSum += num;
        }

        // Số thiếu = hiệu 2 tổng
        return expectedSum - actualSum;
    }
}
```

### ✅ Code Solution 2: XOR (Tối ưu nhất)

```csharp
using System;

public class Solution
{
    public int MissingNumberXOR(int[] nums)
    {
        int n = nums.Length;
        int result = n; // Bắt đầu với n

        for (int i = 0; i < n; i++)
        {
            result ^= i ^ nums[i]; // XOR với cả index và value
        }

        return result;
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

        // Test 1: Thiếu số giữa
        Console.WriteLine(solution.MissingNumber(new int[] {3, 0, 1})); // 2

        // Test 2: Thiếu số cuối
        Console.WriteLine(solution.MissingNumber(new int[] {0, 1})); // 2

        // Test 3: Dãy dài
        Console.WriteLine(solution.MissingNumber(new int[] {9, 6, 4, 2, 3, 5, 7, 0, 1})); // 8

        // Test 4: Thiếu số đầu
        Console.WriteLine(solution.MissingNumber(new int[] {1, 2, 3})); // 0

        // Test 5: Mảng 1 phần tử (thiếu 0)
        Console.WriteLine(solution.MissingNumber(new int[] {1})); // 0

        // Test 6: Mảng 1 phần tử (thiếu 1)
        Console.WriteLine(solution.MissingNumber(new int[] {0})); // 1
    }
}
```

### ⏱️ Độ phức tạp:
- **Time:** O(n) - duyệt mảng 1 lần
- **Space:** O(1) - chỉ dùng biến tạm

---

## ⭐ Câu 2: Đếm số nguyên tố trong khoảng

### 📝 Đề bài:
Đếm số lượng số nguyên tố trong khoảng `[left, right]`.

### 💡 Giải thích thuật toán:

**Sieve of Eratosthenes (Sàng Eratosthenes)**

Đây là thuật toán tối ưu nhất để tìm tất cả số nguyên tố ≤ n.

**Các bước:**
1. Tạo mảng `isPrime[0..right]`, khởi tạo tất cả = `true`
2. Đánh dấu `isPrime[0] = isPrime[1] = false`
3. Với mỗi số `i` từ 2 đến √right:
   - Nếu `isPrime[i] == true`:
     - Đánh dấu tất cả bội số của `i` là `false`
4. Đếm số lượng `isPrime[i] == true` trong khoảng `[left, right]`

**Ví dụ:** Tìm số nguyên tố từ 1 đến 20

```
Bước 1: [2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20]
Bước 2: Loại bội của 2 → [2, 3, 5, 7, 9, 11, 13, 15, 17, 19]
Bước 3: Loại bội của 3 → [2, 3, 5, 7, 11, 13, 17, 19]
Kết quả: 8 số nguyên tố
```

### ✅ Code Solution:

```csharp
using System;

public class Solution
{
    public int CountPrimes(int left, int right)
    {
        // Edge case: không có số nguyên tố nào < 2
        if (right < 2)
            return 0;

        // Nếu left < 2, điều chỉnh về 2 (số nguyên tố nhỏ nhất)
        if (left < 2)
            left = 2;

        // Tạo mảng isPrime
        bool[] isPrime = new bool[right + 1];

        // Khởi tạo tất cả = true
        for (int i = 2; i <= right; i++)
        {
            isPrime[i] = true;
        }

        // Sieve of Eratosthenes
        for (int i = 2; i * i <= right; i++)
        {
            if (isPrime[i])
            {
                // Đánh dấu tất cả bội số của i
                for (int j = i * i; j <= right; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        // Đếm số nguyên tố trong khoảng [left, right]
        int count = 0;
        for (int i = left; i <= right; i++)
        {
            if (isPrime[i])
                count++;
        }

        return count;
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

        // Test 1: Khoảng cơ bản
        Console.WriteLine(solution.CountPrimes(10, 20)); // 4 (11, 13, 17, 19)

        // Test 2: Từ 1 đến 10
        Console.WriteLine(solution.CountPrimes(1, 10)); // 4 (2, 3, 5, 7)

        // Test 3: Một số duy nhất (nguyên tố)
        Console.WriteLine(solution.CountPrimes(5, 5)); // 1

        // Test 4: Không có số nguyên tố
        Console.WriteLine(solution.CountPrimes(0, 1)); // 0

        // Test 5: Số âm đến số dương
        Console.WriteLine(solution.CountPrimes(-10, 10)); // 4 (2, 3, 5, 7)

        // Test 6: Khoảng lớn
        Console.WriteLine(solution.CountPrimes(1, 100)); // 25

        // Test 7: Khoảng 100-200
        Console.WriteLine(solution.CountPrimes(100, 200)); // 21
    }
}
```

### ⏱️ Độ phức tạp:
- **Time:** O(n log log n) - độ phức tạp của Sieve of Eratosthenes
- **Space:** O(n) - mảng isPrime

---

## ⭐⭐ Câu 3: Xử lý Log File và thống kê

### 📝 Đề bài:
Đọc file log, phân tích thống kê, và xuất báo cáo.

### 💡 Giải thích thuật toán:

**Các bước:**
1. **Đọc file** bằng `StreamReader`
2. **Parse từng dòng** để tách Timestamp, Level, Message
3. **Đếm frequency** mỗi log level bằng Dictionary
4. **Tìm most frequent** level
5. **Filter ERROR messages**
6. **Ghi report** bằng `StreamWriter`

**Format log:** `[TIMESTAMP] [LEVEL] MESSAGE`

**Cách parse:**
- Tìm `]` đầu tiên → Timestamp
- Tìm `[` và `]` thứ 2 → Level
- Phần còn lại → Message

### ✅ Code Solution:

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
        var logs = new List<LogEntry>();

        // Kiểm tra file tồn tại
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"File not found: {filePath}");
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Bỏ qua dòng trống
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                try
                {
                    // Parse: [2024-10-15 10:23:45] [INFO] User login successful
                    int firstClose = line.IndexOf(']');
                    if (firstClose == -1) continue; // Format sai, bỏ qua

                    int secondOpen = line.IndexOf('[', firstClose);
                    if (secondOpen == -1) continue;

                    int secondClose = line.IndexOf(']', secondOpen);
                    if (secondClose == -1) continue;

                    // Tách các phần
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
                catch
                {
                    // Bỏ qua dòng format sai
                    continue;
                }
            }
        }

        return logs;
    }

    // Phân tích và tạo report
    public void GenerateReport(List<LogEntry> logs, string outputPath)
    {
        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            writer.WriteLine("========== SERVER LOG ANALYSIS ==========");
            writer.WriteLine($"Total Logs: {logs.Count}");
            writer.WriteLine();

            if (logs.Count == 0)
            {
                writer.WriteLine("No logs to analyze.");
                writer.WriteLine("=========================================");
                return;
            }

            // Đếm frequency của mỗi level
            var levelCounts = new Dictionary<string, int>();
            foreach (var log in logs)
            {
                if (!levelCounts.ContainsKey(log.Level))
                    levelCounts[log.Level] = 0;
                levelCounts[log.Level]++;
            }

            // LOG LEVEL STATISTICS
            writer.WriteLine("LOG LEVEL STATISTICS:");
            foreach (var pair in levelCounts.OrderBy(p => p.Key))
            {
                double percentage = (pair.Value * 100.0) / logs.Count;
                writer.WriteLine($"- {pair.Key}: {pair.Value} ({percentage:F2}%)");
            }
            writer.WriteLine();

            // MOST FREQUENT LEVEL
            var mostFrequent = levelCounts.OrderByDescending(p => p.Value).First();
            writer.WriteLine($"MOST FREQUENT LEVEL: {mostFrequent.Key}");
            writer.WriteLine();

            // ERROR MESSAGES
            var errorLogs = logs.Where(l => l.Level == "ERROR").ToList();
            if (errorLogs.Count > 0)
            {
                writer.WriteLine("ERROR MESSAGES:");
                for (int i = 0; i < errorLogs.Count; i++)
                {
                    writer.WriteLine($"{i + 1}. {errorLogs[i].Message}");
                }
            }
            else
            {
                writer.WriteLine("ERROR MESSAGES:");
                writer.WriteLine("No errors found.");
            }

            writer.WriteLine("=========================================");
        }
    }
}

// ==================== TEST ====================
public class Program
{
    public static void Main()
    {
        Console.WriteLine("========== MOCK TEST 2 - FILE I/O ==========\n");

        // Tạo file server.log để test
        string[] logLines = new string[]
        {
            "[2024-10-15 10:23:45] [INFO] User login successful",
            "[2024-10-15 10:24:12] [ERROR] Database connection failed",
            "[2024-10-15 10:25:33] [WARNING] High memory usage detected",
            "[2024-10-15 10:26:01] [INFO] Data saved successfully",
            "[2024-10-15 10:27:15] [ERROR] API timeout",
            "[2024-10-15 10:28:45] [ERROR] File not found"
        };
        File.WriteAllLines("server.log", logLines);
        Console.WriteLine("✓ File server.log created\n");

        // Chạy log analyzer
        LogAnalyzer analyzer = new LogAnalyzer();

        try
        {
            // Đọc log file
            var logs = analyzer.ReadLogFile("server.log");
            Console.WriteLine($"✓ Read {logs.Count} logs successfully\n");

            // Tạo report
            analyzer.GenerateReport(logs, "report.txt");
            Console.WriteLine("✓ Report generated successfully!\n");

            // In nội dung report ra console
            Console.WriteLine("========== REPORT CONTENT ==========");
            string[] reportLines = File.ReadAllLines("report.txt");
            foreach (string line in reportLines)
            {
                Console.WriteLine(line);
            }
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
========== SERVER LOG ANALYSIS ==========
Total Logs: 6

LOG LEVEL STATISTICS:
- ERROR: 3 (50.00%)
- INFO: 2 (33.33%)
- WARNING: 1 (16.67%)

MOST FREQUENT LEVEL: ERROR

ERROR MESSAGES:
1. Database connection failed
2. API timeout
3. File not found
=========================================
```

### ⏱️ Độ phức tạp:
- **Time:** O(n) - đọc và xử lý mỗi dòng 1 lần
- **Space:** O(n) - lưu trữ logs trong memory

---

## 🎯 FULL CODE - COPY VÀ CHẠY LUÔN

```csharp
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Solution
{
    // ==================== CÂU 1 ====================
    // Sum Formula
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int expectedSum = n * (n + 1) / 2;
        int actualSum = 0;
        foreach (int num in nums)
            actualSum += num;
        return expectedSum - actualSum;
    }

    // ==================== CÂU 2 ====================
    public int CountPrimes(int left, int right)
    {
        if (right < 2) return 0;
        if (left < 2) left = 2;

        bool[] isPrime = new bool[right + 1];
        for (int i = 2; i <= right; i++)
            isPrime[i] = true;

        for (int i = 2; i * i <= right; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= right; j += i)
                    isPrime[j] = false;
            }
        }

        int count = 0;
        for (int i = left; i <= right; i++)
        {
            if (isPrime[i]) count++;
        }
        return count;
    }
}

// ==================== CÂU 3 ====================
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
        var logs = new List<LogEntry>();
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"File not found: {filePath}");

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                try
                {
                    int firstClose = line.IndexOf(']');
                    if (firstClose == -1) continue;
                    int secondOpen = line.IndexOf('[', firstClose);
                    if (secondOpen == -1) continue;
                    int secondClose = line.IndexOf(']', secondOpen);
                    if (secondClose == -1) continue;

                    string timestamp = line.Substring(1, firstClose - 1);
                    string level = line.Substring(secondOpen + 1, secondClose - secondOpen - 1);
                    string message = line.Substring(secondClose + 2).Trim();

                    logs.Add(new LogEntry { Timestamp = timestamp, Level = level, Message = message });
                }
                catch { continue; }
            }
        }
        return logs;
    }

    public void GenerateReport(List<LogEntry> logs, string outputPath)
    {
        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            writer.WriteLine("========== SERVER LOG ANALYSIS ==========");
            writer.WriteLine($"Total Logs: {logs.Count}");
            writer.WriteLine();

            if (logs.Count == 0)
            {
                writer.WriteLine("No logs to analyze.");
                writer.WriteLine("=========================================");
                return;
            }

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
            writer.WriteLine();

            var mostFrequent = levelCounts.OrderByDescending(p => p.Value).First();
            writer.WriteLine($"MOST FREQUENT LEVEL: {mostFrequent.Key}");
            writer.WriteLine();

            var errorLogs = logs.Where(l => l.Level == "ERROR").ToList();
            if (errorLogs.Count > 0)
            {
                writer.WriteLine("ERROR MESSAGES:");
                for (int i = 0; i < errorLogs.Count; i++)
                    writer.WriteLine($"{i + 1}. {errorLogs[i].Message}");
            }
            else
            {
                writer.WriteLine("ERROR MESSAGES:");
                writer.WriteLine("No errors found.");
            }

            writer.WriteLine("=========================================");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("========== CÂU 1: MISSING NUMBER ==========");
        Solution solution = new Solution();
        Console.WriteLine(solution.MissingNumber(new int[] {3, 0, 1})); // 2
        Console.WriteLine(solution.MissingNumber(new int[] {0, 1})); // 2

        Console.WriteLine("\n========== CÂU 2: COUNT PRIMES ==========");
        Console.WriteLine(solution.CountPrimes(10, 20)); // 4
        Console.WriteLine(solution.CountPrimes(1, 10)); // 4

        Console.WriteLine("\n========== CÂU 3: LOG ANALYZER ==========");
        File.WriteAllLines("server.log", new string[]
        {
            "[2024-10-15 10:23:45] [INFO] User login successful",
            "[2024-10-15 10:24:12] [ERROR] Database connection failed",
            "[2024-10-15 10:27:15] [ERROR] API timeout"
        });

        LogAnalyzer analyzer = new LogAnalyzer();
        var logs = analyzer.ReadLogFile("server.log");
        analyzer.GenerateReport(logs, "report.txt");
        Console.WriteLine(File.ReadAllText("report.txt"));
    }
}
```

---

## 📊 TÓM TẮT

| Câu | Độ khó | Thuật toán chính | Time | Space |
|-----|--------|------------------|------|-------|
| 1 | Easy | Sum/XOR | O(n) | O(1) |
| 2 | Easy | Sieve of Eratosthenes | O(n log log n) | O(n) |
| 3 | Medium | File I/O + Dictionary | O(n) | O(n) |

---

**🎯 MOCK TEST 2 TẬP TRUNG VÀO FILE I/O - KỸ NĂNG QUAN TRỌNG CHO NASHTECH!** 💪
