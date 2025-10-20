# 🎯 MOCK TEST 1 - ĐÁP ÁN CHI TIẾT

---

## ⭐ Câu 1: Tìm phần tử xuất hiện lẻ lần

### 📝 Đề bài:
Cho mảng `nums` trong đó mọi phần tử xuất hiện **2 lần** ngoại trừ **1 phần tử** xuất hiện **1 lần duy nhất**.

### 💡 Giải thích thuật toán:

**XOR Trick** là kỹ thuật tối ưu nhất cho bài này:
- Tính chất XOR: `a ^ a = 0` và `a ^ 0 = a`
- Khi XOR tất cả số với nhau, các số xuất hiện 2 lần sẽ triệt tiêu nhau (= 0)
- Chỉ còn lại số xuất hiện 1 lần

**Ví dụ:** `[2, 3, 2, 4, 4]`
```
0 ^ 2 = 2
2 ^ 3 = 1 (binary: 10 ^ 11 = 01)
1 ^ 2 = 3
3 ^ 4 = 7
7 ^ 4 = 3 ← Kết quả
```

### ✅ Code Solution:

```csharp
using System;

public class Solution
{
    public int FindSingleNumber(int[] nums)
    {
        int result = 0;

        // XOR tất cả phần tử
        foreach (int num in nums)
        {
            result ^= num;
        }

        return result;
    }
}

// Test
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        // Test 1
        int[] test1 = {2, 3, 2, 4, 4};
        Console.WriteLine(solution.FindSingleNumber(test1)); // Output: 3

        // Test 2
        int[] test2 = {1};
        Console.WriteLine(solution.FindSingleNumber(test2)); // Output: 1

        // Test 3
        int[] test3 = {4, 1, 2, 1, 2};
        Console.WriteLine(solution.FindSingleNumber(test3)); // Output: 4

        // Test 4
        int[] test4 = {7, 7, 9};
        Console.WriteLine(solution.FindSingleNumber(test4)); // Output: 9

        // Test 5: Số âm
        int[] test5 = {-1, -1, 5};
        Console.WriteLine(solution.FindSingleNumber(test5)); // Output: 5

        // Test 6: Số 0
        int[] test6 = {0, 1, 0};
        Console.WriteLine(solution.FindSingleNumber(test6)); // Output: 1
    }
}
```

### ⏱️ Độ phức tạp:
- **Time:** O(n) - duyệt mảng 1 lần
- **Space:** O(1) - chỉ dùng biến `result`

---

## ⭐ Câu 2: Kiểm tra Anagram

### 📝 Đề bài:
Kiểm tra xem hai chuỗi `s` và `t` có phải là anagram của nhau không.

### 💡 Giải thích thuật toán:

**Approach 1: Dictionary (Hash Map)**
- Đếm tần suất xuất hiện của mỗi ký tự trong chuỗi `s`
- Trừ đi tần suất khi duyệt chuỗi `t`
- Nếu gặp ký tự không tồn tại hoặc count < 0 → return false

**Approach 2: Sort và so sánh**
- Sắp xếp cả 2 chuỗi
- So sánh xem có bằng nhau không

### ✅ Code Solution 1: Dictionary (Tối ưu nhất)

```csharp
using System;
using System.Collections.Generic;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // Nếu độ dài khác nhau → không phải anagram
        if (s.Length != t.Length)
            return false;

        // Đếm tần suất các ký tự trong s
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        // Trừ đi tần suất khi duyệt t
        foreach (char c in t)
        {
            if (!charCount.ContainsKey(c))
                return false;

            charCount[c]--;

            if (charCount[c] < 0)
                return false;
        }

        return true;
    }
}
```

### ✅ Code Solution 2: Sorting

```csharp
using System;
using System.Linq;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        // Nếu độ dài khác nhau → không phải anagram
        if (s.Length != t.Length)
            return false;

        // Chuyển thành mảng, sắp xếp, so sánh
        char[] sArr = s.ToCharArray();
        char[] tArr = t.ToCharArray();

        Array.Sort(sArr);
        Array.Sort(tArr);

        // So sánh từng ký tự
        for (int i = 0; i < sArr.Length; i++)
        {
            if (sArr[i] != tArr[i])
                return false;
        }

        return true;
    }

    // Hoặc dùng LINQ (ngắn gọn hơn)
    public bool IsAnagramLINQ(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        return s.OrderBy(c => c).SequenceEqual(t.OrderBy(c => c));
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

        // Test 1: Anagram đơn giản
        Console.WriteLine(solution.IsAnagram("anagram", "nagaram")); // true

        // Test 2: Không phải anagram
        Console.WriteLine(solution.IsAnagram("rat", "car")); // false

        // Test 3: Anagram khác
        Console.WriteLine(solution.IsAnagram("listen", "silent")); // true

        // Test 4: Độ dài khác nhau
        Console.WriteLine(solution.IsAnagram("abc", "abcd")); // false

        // Test 5: Chuỗi rỗng
        Console.WriteLine(solution.IsAnagram("", "")); // true

        // Test 6: Có khoảng trắng
        Console.WriteLine(solution.IsAnagram("a gentleman", "elegant man")); // true

        // Test 7: Case-sensitive
        Console.WriteLine(solution.IsAnagram("Anagram", "nagaram")); // false
    }
}
```

### ⏱️ Độ phức tạp:

**Solution 1 (Dictionary):**
- **Time:** O(n) - duyệt chuỗi 2 lần
- **Space:** O(k) - k là số ký tự unique (tối đa 26 nếu chỉ có chữ cái)

**Solution 2 (Sorting):**
- **Time:** O(n log n) - do sorting
- **Space:** O(n) - tạo 2 mảng char

**👉 Khuyến nghị: Dùng Solution 1 (Dictionary) vì hiệu quả hơn**

---

## ⭐⭐ Câu 3: Ma trận xoắn ốc (Spiral Matrix)

### 📝 Đề bài:
Cho ma trận `m x n`, trả về các phần tử theo thứ tự **xoắn ốc**.

### 💡 Giải thích thuật toán:

**Ý tưởng:** Sử dụng 4 biên (boundaries) để track vùng chưa duyệt

```
top = 0
┌─────────────┐
│ 1 → 2 → 3  │
│         ↓   │
│ 4 → 5   6  │ left = 0, right = 2
│ ↑       ↓   │
│ 7 ← 8 ← 9  │
└─────────────┘
bottom = 2
```

**Các bước:**
1. Đi từ trái → phải (hàng `top`) → tăng `top`
2. Đi từ trên → dưới (cột `right`) → giảm `right`
3. Đi từ phải → trái (hàng `bottom`) → giảm `bottom`
4. Đi từ dưới → trên (cột `left`) → tăng `left`
5. Lặp lại cho đến khi `top > bottom` hoặc `left > right`

### ✅ Code Solution:

```csharp
using System;
using System.Collections.Generic;

public class Solution
{
    public List<int> SpiralOrder(int[][] matrix)
    {
        List<int> result = new List<int>();

        // Edge case: ma trận rỗng
        if (matrix == null || matrix.Length == 0)
            return result;

        int rows = matrix.Length;
        int cols = matrix[0].Length;

        // Khởi tạo 4 biên
        int top = 0;
        int bottom = rows - 1;
        int left = 0;
        int right = cols - 1;

        while (top <= bottom && left <= right)
        {
            // 1. Đi từ trái sang phải (top row)
            for (int i = left; i <= right; i++)
            {
                result.Add(matrix[top][i]);
            }
            top++; // Di chuyển biên top xuống

            // 2. Đi từ trên xuống dưới (right column)
            for (int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i][right]);
            }
            right--; // Di chuyển biên right sang trái

            // 3. Đi từ phải sang trái (bottom row)
            // Kiểm tra top <= bottom để tránh duplicate khi chỉ còn 1 hàng
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom][i]);
                }
                bottom--; // Di chuyển biên bottom lên
            }

            // 4. Đi từ dưới lên trên (left column)
            // Kiểm tra left <= right để tránh duplicate khi chỉ còn 1 cột
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++; // Di chuyển biên left sang phải
            }
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

        // Test 1: Ma trận 3x3
        int[][] test1 = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };
        PrintList(solution.SpiralOrder(test1));
        // Output: [1, 2, 3, 6, 9, 8, 7, 4, 5]

        // Test 2: Ma trận 3x4
        int[][] test2 = new int[][]
        {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7, 8},
            new int[] {9, 10, 11, 12}
        };
        PrintList(solution.SpiralOrder(test2));
        // Output: [1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7]

        // Test 3: Ma trận 1 hàng
        int[][] test3 = new int[][]
        {
            new int[] {1, 2, 3, 4}
        };
        PrintList(solution.SpiralOrder(test3));
        // Output: [1, 2, 3, 4]

        // Test 4: Ma trận 1 cột
        int[][] test4 = new int[][]
        {
            new int[] {1},
            new int[] {2},
            new int[] {3}
        };
        PrintList(solution.SpiralOrder(test4));
        // Output: [1, 2, 3]

        // Test 5: Ma trận 1x1
        int[][] test5 = new int[][]
        {
            new int[] {5}
        };
        PrintList(solution.SpiralOrder(test5));
        // Output: [5]

        // Test 6: Ma trận 4x4
        int[][] test6 = new int[][]
        {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7, 8},
            new int[] {9, 10, 11, 12},
            new int[] {13, 14, 15, 16}
        };
        PrintList(solution.SpiralOrder(test6));
        // Output: [1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10]
    }

    static void PrintList(List<int> list)
    {
        Console.WriteLine("[" + string.Join(", ", list) + "]");
    }
}
```

### ⏱️ Độ phức tạp:
- **Time:** O(m × n) - duyệt mỗi phần tử đúng 1 lần
- **Space:** O(m × n) - cho list kết quả (không tính output thì O(1))

---

## 🎯 FULL CODE - COPY VÀ CHẠY LUÔN

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    // ==================== CÂU 1 ====================
    public int FindSingleNumber(int[] nums)
    {
        int result = 0;
        foreach (int num in nums)
        {
            result ^= num;
        }
        return result;
    }

    // ==================== CÂU 2 ====================
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        foreach (char c in t)
        {
            if (!charCount.ContainsKey(c))
                return false;

            charCount[c]--;

            if (charCount[c] < 0)
                return false;
        }

        return true;
    }

    // ==================== CÂU 3 ====================
    public List<int> SpiralOrder(int[][] matrix)
    {
        List<int> result = new List<int>();

        if (matrix == null || matrix.Length == 0)
            return result;

        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int top = 0, bottom = rows - 1;
        int left = 0, right = cols - 1;

        while (top <= bottom && left <= right)
        {
            // Trái → Phải
            for (int i = left; i <= right; i++)
                result.Add(matrix[top][i]);
            top++;

            // Trên → Dưới
            for (int i = top; i <= bottom; i++)
                result.Add(matrix[i][right]);
            right--;

            // Phải → Trái
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                    result.Add(matrix[bottom][i]);
                bottom--;
            }

            // Dưới → Trên
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                    result.Add(matrix[i][left]);
                left++;
            }
        }

        return result;
    }
}

// ==================== TEST ====================
public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        Console.WriteLine("========== CÂU 1: XOR TRICK ==========");
        Console.WriteLine(solution.FindSingleNumber(new int[] {2, 3, 2, 4, 4})); // 3
        Console.WriteLine(solution.FindSingleNumber(new int[] {1})); // 1
        Console.WriteLine(solution.FindSingleNumber(new int[] {4, 1, 2, 1, 2})); // 4

        Console.WriteLine("\n========== CÂU 2: ANAGRAM ==========");
        Console.WriteLine(solution.IsAnagram("anagram", "nagaram")); // True
        Console.WriteLine(solution.IsAnagram("rat", "car")); // False
        Console.WriteLine(solution.IsAnagram("listen", "silent")); // True

        Console.WriteLine("\n========== CÂU 3: SPIRAL MATRIX ==========");
        int[][] matrix1 = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };
        PrintList(solution.SpiralOrder(matrix1));

        int[][] matrix2 = new int[][]
        {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7, 8},
            new int[] {9, 10, 11, 12}
        };
        PrintList(solution.SpiralOrder(matrix2));
    }

    static void PrintList(List<int> list)
    {
        Console.WriteLine("[" + string.Join(", ", list) + "]");
    }
}
```

---

## 📊 TÓM TẮT

| Câu | Độ khó | Thuật toán chính | Time | Space |
|-----|--------|------------------|------|-------|
| 1 | Easy | XOR Trick | O(n) | O(1) |
| 2 | Easy | HashMap/Dictionary | O(n) | O(k) |
| 3 | Medium | Boundary Tracking | O(m×n) | O(1) |

---

## 💡 KIẾN THỨC RÚT RA

### Từ Câu 1:
- **XOR Trick** rất mạnh cho bài toán tìm số xuất hiện lẻ lần
- Tính chất: `a ^ a = 0`, `a ^ 0 = a`

### Từ Câu 2:
- **HashMap/Dictionary** là công cụ đắc lực cho frequency counting
- Nhớ check `ContainsKey` trước khi truy cập
- Có thể dùng sorting nhưng kém hiệu quả hơn

### Từ Câu 3:
- **Boundary tracking** là pattern quan trọng cho matrix traversal
- Cẩn thận với edge cases: ma trận 1 hàng, 1 cột
- Nhớ check điều kiện `top <= bottom` và `left <= right` trước khi đi ngược

---

**🎯 CHÚC BẠN LÀM TỐT MOCK TEST 1!** 💪
