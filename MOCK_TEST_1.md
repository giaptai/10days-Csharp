# 🎯 MOCK TEST 1 - ROOKIE SIMULATION
**Thời gian: 90 phút | 3 câu hỏi: 2 Easy + 1 Medium**

---

## ⭐ Câu 1: Tìm phần tử xuất hiện lẻ lần (Easy)
**Độ khó:** Easy | **Thời gian gợi ý:** 20 phút

### Đề bài:
Cho một mảng số nguyên `nums` trong đó mọi phần tử xuất hiện **2 lần** ngoại trừ **1 phần tử** xuất hiện **1 lần duy nhất**.

Hãy tìm phần tử đó.

### Yêu cầu:
- Phải giải quyết trong **O(n)** time complexity
- Sử dụng **O(1)** space complexity (không dùng Dictionary/HashMap)
- **Gợi ý:** Sử dụng toán tử XOR (^)

### Input/Output:
```
Input: nums = [2, 3, 2, 4, 4]
Output: 3

Input: nums = [1]
Output: 1

Input: nums = [4, 1, 2, 1, 2]
Output: 4
```

### Test cases bổ sung:
```csharp
// Test 1: Mảng nhỏ
nums = [7, 7, 9] → Output: 9

// Test 2: Số âm
nums = [-1, -1, 5] → Output: 5

// Test 3: Số 0
nums = [0, 1, 0] → Output: 1
```

---

## ⭐ Câu 2: Kiểm tra Anagram (Easy)
**Độ khó:** Easy | **Thời gian gợi ý:** 25 phút

### Đề bài:
Cho hai chuỗi `s` và `t`, hãy kiểm tra xem `t` có phải là anagram của `s` hay không.

**Anagram** là một từ được tạo thành bằng cách sắp xếp lại các chữ cái của một từ khác, sử dụng tất cả các chữ cái ban đầu chính xác một lần.

### Yêu cầu:
- Phân biệt chữ hoa chữ thường (case-sensitive)
- Không bỏ qua khoảng trắng
- Giải pháp tối ưu: O(n) time, O(1) space (nếu chỉ xét 26 chữ cái)

### Input/Output:
```
Input: s = "anagram", t = "nagaram"
Output: true

Input: s = "rat", t = "car"
Output: false

Input: s = "listen", t = "silent"
Output: true
```

### Test cases bổ sung:
```csharp
// Test 1: Độ dài khác nhau
s = "abc", t = "abcd" → Output: false

// Test 2: Chuỗi rỗng
s = "", t = "" → Output: true

// Test 3: Có khoảng trắng
s = "a gentleman", t = "elegant man" → Output: true

// Test 4: Case-sensitive
s = "Anagram", t = "nagaram" → Output: false
```

---

## ⭐⭐ Câu 3: Ma trận xoắn ốc (Spiral Matrix) (Medium)
**Độ khó:** Medium | **Thời gian gợi ý:** 45 phút

### Đề bài:
Cho một ma trận `m x n`, hãy trả về tất cả các phần tử của ma trận theo thứ tự **xoắn ốc** (spiral order).

**Xoắn ốc** nghĩa là: đi từ trái sang phải → trên xuống dưới → phải sang trái → dưới lên trên, và lặp lại cho đến hết.

### Input/Output:
```
Input: matrix = [
  [1, 2, 3],
  [4, 5, 6],
  [7, 8, 9]
]
Output: [1, 2, 3, 6, 9, 8, 7, 4, 5]

Giải thích:
1 → 2 → 3
        ↓
4 → 5   6
↑       ↓
7 ← 8 ← 9
```

```
Input: matrix = [
  [1, 2, 3, 4],
  [5, 6, 7, 8],
  [9, 10, 11, 12]
]
Output: [1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7]
```

### Test cases bổ sung:
```csharp
// Test 1: Ma trận 1 hàng
matrix = [[1, 2, 3, 4]]
Output: [1, 2, 3, 4]

// Test 2: Ma trận 1 cột
matrix = [[1], [2], [3]]
Output: [1, 2, 3]

// Test 3: Ma trận 1x1
matrix = [[5]]
Output: [5]

// Test 4: Ma trận vuông 4x4
matrix = [
  [1,  2,  3,  4],
  [5,  6,  7,  8],
  [9,  10, 11, 12],
  [13, 14, 15, 16]
]
Output: [1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10]
```

### Yêu cầu:
- Xử lý đúng các edge cases (ma trận 1 hàng, 1 cột, 1x1)
- Code phải clean và dễ hiểu
- Giải thích approach của bạn bằng comments

### Gợi ý:
- Sử dụng 4 biến: `top`, `bottom`, `left`, `right` để track boundaries
- Sau mỗi vòng lặp, cập nhật boundaries
- Dừng khi `top > bottom` hoặc `left > right`

---

## 📝 Hướng dẫn nộp bài:

1. Tạo file `MockTest1.cs` trong project
2. Implement cả 3 functions với signature sau:

```csharp
public class Solution
{
    // Câu 1
    public int FindSingleNumber(int[] nums)
    {
        // Your code here
    }

    // Câu 2
    public bool IsAnagram(string s, string t)
    {
        // Your code here
    }

    // Câu 3
    public List<int> SpiralOrder(int[][] matrix)
    {
        // Your code here
    }
}
```

3. Test với tất cả test cases đã cho
4. Đảm bảo code chạy không lỗi

---

## ⏰ Chiến thuật làm bài:

- **0-20 phút:** Làm câu 1 (XOR trick)
- **20-45 phút:** Làm câu 2 (Anagram - dùng Dictionary hoặc array counting)
- **45-90 phút:** Làm câu 3 (Spiral Matrix - khó nhất, cần cẩn thận với boundaries)

---

## 🎯 Tiêu chí đánh giá:

1. **Correctness (60%):** Code chạy đúng với tất cả test cases
2. **Code Quality (20%):** Clean code, naming conventions, comments
3. **Time Complexity (10%):** Solution tối ưu
4. **Edge Cases (10%):** Xử lý các trường hợp đặc biệt

---

**Chúc bạn may mắn! Hãy bắt đầu làm bài và cho tôi biết khi nào bạn hoàn thành!** 🚀
