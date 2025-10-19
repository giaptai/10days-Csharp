# 📅 Lộ trình 10 ngày học C# (Tối ưu cho Rookie Test)

## **Ngày 1: Làm quen môi trường**
- Cài đặt **Visual Studio / VS Code** + **.NET SDK**  
- Hiểu về **.NET runtime**, **CLR**, **C# compiler**  
- Viết chương trình đầu tiên: `Hello World`  
- Làm quen với **project structure** (solution, project, namespace)

---

## **Ngày 2: Cú pháp cơ bản**
- Kiểu dữ liệu cơ bản: `int`, `string`, `bool`, `double`  
- Biến, hằng số, ép kiểu  
- Toán tử số học, logic, gán  
- Bài tập: nhập 2 số và tính tổng, hiệu, tích, thương

---

## **Ngày 3: Cấu trúc điều khiển**
- Câu lệnh điều kiện: `if/else`, `switch`  
- Vòng lặp: `for`, `while`, `foreach`  
- Bài tập: viết chương trình tính tổng dãy số, kiểm tra số nguyên tố, in bảng cửu chương

---

## **Ngày 4: Làm việc với cấu trúc dữ liệu**
- **List**, **Dictionary (Map)**  
- **Stack**, **Queue**  
- Các thao tác cơ bản: thêm, xóa, tìm kiếm, duyệt phần tử  
- So sánh khi nào nên dùng `List`, `Dictionary`, `Stack`, `Queue`  
- Bài tập:  
  - Quản lý danh sách sinh viên (thêm, xóa, tìm kiếm)  
  - Mô phỏng lịch sử duyệt web (Stack)  
  - Mô phỏng hàng đợi giao dịch (Queue)

---

## **Ngày 5: Lập trình hướng đối tượng (OOP)**
- Class, Object, Constructor  
- Thuộc tính (Properties), Phương thức (Methods)  
- Tính đóng gói (Encapsulation)  
- Bài tập: tạo class `Student` và quản lý danh sách sinh viên bằng List

---

## **Ngày 6: OOP nâng cao**
- Kế thừa (Inheritance)  
- Đa hình (Polymorphism)  
- Interface, Abstract class  
- Ghi đè phương thức (`override`, `virtual`, `abstract`)  
- Bài tập: mô phỏng hệ thống động vật (Animal → Dog, Cat)

---

## **Ngày 7: Xử lý ngoại lệ & DateTime**
- `try/catch/finally` — xử lý lỗi an toàn
- Exception tùy chỉnh
- **DateTime cơ bản:** Parse, Format, TryParse
- **Thao tác DateTime:** AddDays, AddMonths, AddYears
- **TimeSpan:** Tính khoảng cách giữa 2 dates
- **Patterns quan trọng:**
  - Tính tuổi từ ngày sinh
  - Kiểm tra năm nhuận (`DateTime.IsLeapYear`)
  - Tính số ngày giữa 2 dates
  - Parse dates từ nhiều formats
- **Bài tập:**
  - Tính tuổi từ ngày sinh và xếp loại (trẻ em, thanh niên, trung niên)
  - Kiểm tra năm nhuận và tính số ngày trong tháng 2
  - Parse date từ string với nhiều formats (dd/MM/yyyy, yyyy-MM-dd)
  - Tính số ngày làm việc giữa 2 ngày (bỏ cuối tuần)
- 📖 **Tài liệu:** [DATETIME_CHEATSHEET.md](DATETIME_CHEATSHEET.md)

---

## **Ngày 8: LINQ & Array/Matrix Operations**
- **LINQ cơ bản:** Select, Where, OrderBy, GroupBy
- **LINQ với Collections:** List, Dictionary, Array
- **Array 2D (Matrix):**
  - Khai báo và khởi tạo matrix
  - Duyệt matrix (2 vòng for)
  - Tính tổng hàng/cột
  - Tìm max/min trong matrix
  - Ma trận chuyển vị
  - Đường chéo chính/phụ
- **Bài tập:**
  - Lọc danh sách sinh viên theo điểm (LINQ)
  - Tìm top 3 sinh viên điểm cao nhất
  - Cộng/nhân 2 ma trận
  - Spiral Matrix (ma trận xoắn ốc)
  - Valid Sudoku Checker

---

## **Ngày 9: File I/O (QUAN TRỌNG CHO)**
- **Đọc file:**
  - `File.ReadAllLines()` - đọc toàn bộ
  - `File.ReadLines()` - lazy loading
  - `StreamReader` - đọc từng dòng (KHUYÊN DÙNG)
- **Ghi file:**
  - `File.WriteAllLines()` - ghi mảng
  - `File.AppendAllText()` - ghi thêm
  - `StreamWriter` - ghi từng dòng (KHUYÊN DÙNG)
- **Best Practices:**
  - Luôn dùng `using` với StreamReader/StreamWriter
  - Kiểm tra file tồn tại với `File.Exists()`
  - Xử lý exception với try-catch
- **Kết hợp File + DateTime:**
  - Parse dates từ CSV file
  - Filter log files theo timestamp
- **Bài tập:**
  - Đảo ngược thứ tự từ trong file (word-level reverse)
  - Đọc CSV file và parse thành List<Student>
  - Log File Analyzer: đếm ERROR/WARNING/INFO
  - Filter lines chứa keyword và ghi ra file mới
  - Student Grade Management System (đọc CSV → xử lý → ghi report)
- 📖 **Tài liệu:** [FILE_IO_CHEATSHEET.md](FILE_IO_CHEATSHEET.md)

---

## **Ngày 10: Mock Tests & Review (CHO TEST)**
- **Mock Test 1:** 2 Easy + 1 Medium (Algorithms cơ bản)
  - XOR Trick, Anagram, Spiral Matrix
- **Mock Test 2:** 2 Easy + 1 Medium (File I/O + DateTime)
  - Missing Number, Count Primes, Log Analyzer
- **Mock Test 3:** 2 Easy + 1 Medium (Challenge)
  - Merge Arrays, Valid Sudoku, Grade System
- **Review toàn bộ:**
  - Patterns quan trọng (Two Pointers, HashMap, Stack, etc.)
  - File I/O best practices
  - DateTime common tasks
  - Edge cases handling
- 📖 **Mock Tests:**
  - [MOCK_TEST_1.md](MOCK_TEST_1.md)
  - [MOCK_TEST_2.md](MOCK_TEST_2.md)
  - [MOCK_TEST_3.md](MOCK_TEST_3.md)

---

## 🎯 Nguyên tắc học nhanh
- **Code mỗi ngày**: không chỉ xem lý thuyết
- **Chia nhỏ mục tiêu**: mỗi ngày hoàn thành ít nhất 1 bài tập
- **Tập trung vào thực hành**: ưu tiên viết code thay vì học lan man
- **Ghi chú & ôn lại**: cuối ngày dành 15 phút tổng kết

---

## 🔥 KHẨN CẤP: Lộ trình 2 ngày cuối cho Test (18-19/10)

### **🚨 Ngày 18 (HÔM NAY) - 4-5 giờ:**
**BUỔI SÁNG (2-3 giờ):**
- ⏰ **09:00-10:30:** Làm **MOCK_TEST_1** (90 phút) - Đừng xem đáp án!
- ⏰ **10:30-11:00:** Review solutions, hiểu rõ từng pattern
- ⏰ **11:00-12:00:** Làm lại các bài sai trong MOCK_TEST_1

**BUỔI CHIỀU (2 giờ):**
- ⏰ **14:00-15:30:** Làm **MOCK_TEST_2** (90 phút) - có File I/O + DateTime
- ⏰ **15:30-16:00:** Review File I/O patterns từ cheatsheet

**BUỔI TỐI (nếu còn thời gian):**
- ⏰ Review nhanh [DATETIME_CHEATSHEET.md](DATETIME_CHEATSHEET.md)
- ⏰ Review nhanh [FILE_IO_CHEATSHEET.md](FILE_IO_CHEATSHEET.md)

🎯 **Mục tiêu:** Làm xong 2 mock tests, hiểu rõ patterns

---

### **🔥 Ngày 19 (NGÀY MAI) - 3-4 giờ:**
**BUỔI SÁNG (2 giờ):**
- ⏰ **09:00-10:30:** Làm **MOCK_TEST_3** (90 phút) - bài khó nhất
- ⏰ **10:30-11:00:** Review solutions

**BUỔI CHIỀU (1-2 giờ):**
- ⏰ **14:00-15:00:** Speed run: Làm lại 1 trong 3 mock tests (60 phút)
- ⏰ **15:00-16:00:** Review 7 patterns quan trọng (xem bên dưới)

**BUỔI TỐI:**
- ✅ **KHÔNG CODE NỮA!** Nghỉ ngơi, thư giãn
- ✅ Review nhẹ checklist cuối cùng (10 phút)
- ✅ Chuẩn bị đồ dùng cho ngày mai (laptop, sạc, nước uống)
- ✅ Ngủ sớm trước 22:00

🎯 **Mục tiêu:** Hoàn thành tất cả mock tests, tự tin 100%

---

### **⚠️ NẾU KHÔNG ĐỦ THỜI GIAN:**
**Priority 1 (BẮT BUỘC):**
- ✅ Làm **MOCK_TEST_2** (có File I/O - hay ra nhất!)
- ✅ Review [FILE_IO_CHEATSHEET.md](FILE_IO_CHEATSHEET.md)
- ✅ Review [DATETIME_CHEATSHEET.md](DATETIME_CHEATSHEET.md)

**Priority 2 (NÊN LÀM):**
- ✅ Làm **MOCK_TEST_1** (patterns cơ bản)
- ✅ Review code trong [Leetcode/Program.cs](Leetcode/Program.cs)

**Priority 3 (NẾU CÒN THỜI GIAN):**
- ✅ Làm **MOCK_TEST_3** (challenge)

---

## 📚 Tài liệu tham khảo

- **Kiến thức cốt lõi:**
  - [FILE_IO_CHEATSHEET.md](FILE_IO_CHEATSHEET.md) - Đọc ghi file
  - [DATETIME_CHEATSHEET.md](DATETIME_CHEATSHEET.md) - Xử lý DateTime

- **Mock Tests:**
  - [MOCK_TEST_1.md](MOCK_TEST_1.md) - Algorithms cơ bản
  - [MOCK_TEST_2.md](MOCK_TEST_2.md) - File I/O + DateTime
  - [MOCK_TEST_3.md](MOCK_TEST_3.md) - Challenge

- **Code mẫu:**
  - [Leetcode/Program.cs](Leetcode/Program.cs) - Các bài đã làm từ VOZ

---

👉 **Với lộ trình này, bạn sẽ sẵn sàng cho Rookie Test vào ngày 20/10/2024!** 🚀

**7 Patterns quan trọng nhất (HỌC THUỘC LÒNG!):**

### **1️⃣ XOR Trick - Tìm số xuất hiện lẻ lần**
```csharp
int FindSingle(int[] nums) {
    int result = 0;
    foreach (int num in nums) result ^= num;
    return result;
}
```

### **2️⃣ Two Pointers - Merge arrays, Palindrome**
```csharp
// Palindrome check
bool IsPalindrome(string s) {
    int left = 0, right = s.Length - 1;
    while (left < right) {
        if (s[left] != s[right]) return false;
        left++; right--;
    }
    return true;
}
```

### **3️⃣ HashMap/Dictionary - Frequency counting, Anagram**
```csharp
bool IsAnagram(string s, string t) {
    if (s.Length != t.Length) return false;
    var dict = new Dictionary<char, int>();
    foreach (char c in s) {
        if (dict.ContainsKey(c)) dict[c]++;
        else dict[c] = 1;
    }
    foreach (char c in t) {
        if (!dict.ContainsKey(c)) return false;
        dict[c]--;
        if (dict[c] < 0) return false;
    }
    return true;
}
```

### **4️⃣ Stack - Valid Parentheses**
```csharp
bool IsValid(string s) {
    var stack = new Stack<char>();
    foreach (char c in s) {
        if (c == '(' || c == '[' || c == '{') {
            stack.Push(c);
        } else {
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

### **5️⃣ File I/O - StreamReader/StreamWriter**
```csharp
void ProcessFile(string input, string output) {
    using (StreamReader reader = new StreamReader(input))
    using (StreamWriter writer = new StreamWriter(output)) {
        string line;
        while ((line = reader.ReadLine()) != null) {
            // Process line
            writer.WriteLine(ProcessLine(line));
        }
    }
}
```

### **6️⃣ DateTime - Parse và tính toán**
```csharp
// Tính tuổi
int CalculateAge(DateTime birthDate) {
    int age = DateTime.Today.Year - birthDate.Year;
    if (birthDate.Date > DateTime.Today.AddYears(-age)) age--;
    return age;
}

// Parse date an toàn
if (DateTime.TryParse(dateStr, out DateTime date)) {
    // Success
}
```

### **7️⃣ Matrix - 2D Arrays**
```csharp
// Duyệt matrix
for (int i = 0; i < matrix.Length; i++) {
    for (int j = 0; j < matrix[i].Length; j++) {
        Console.Write(matrix[i][j] + " ");
    }
    Console.WriteLine();
}
```

---

## ✅ CHECKLIST CUỐI CÙNG (Đọc trước khi thi!)

### **📝 Kiến thức:**
- [ ] Biết XOR trick để tìm số xuất hiện lẻ lần?
- [ ] Biết Two Pointers pattern?
- [ ] Biết dùng Dictionary để đếm frequency?
- [ ] Biết dùng Stack cho valid parentheses?
- [ ] Biết File I/O với `using` statement?
- [ ] Biết parse DateTime với TryParse?
- [ ] Biết duyệt ma trận 2D?

### **🛠️ Kỹ năng code:**
- [ ] Luôn check edge cases (null, empty, single element)?
- [ ] Luôn dùng `using` với StreamReader/StreamWriter?
- [ ] Luôn dùng `TryParse` thay vì `Parse`?
- [ ] Luôn có try-catch khi làm File I/O?
- [ ] Test code với ít nhất 2-3 test cases?

### **⏰ Chiến thuật thi:**
- [ ] Đọc cả 3 đề trước khi làm?
- [ ] Làm 2 bài Easy trước (45 phút)?
- [ ] Để bài Medium làm sau (45 phút)?
- [ ] Nếu bí: viết brute force trước, optimize sau?
- [ ] Test kỹ trước khi submit?

### **🎒 Chuẩn bị:**
- [ ] Laptop đầy pin / có sạc?
- [ ] Đã cài .NET SDK?
- [ ] Đã test IDE (VS Code/Visual Studio)?
- [ ] Mang nước uống?
- [ ] Tinh thần thoải mái, tự tin?

---

## 🔥 LỜI KHUYÊN CUỐI CÙNG

**TRƯỚC KHI THI (30 phút):**
1. ✅ Đọc lại 7 patterns ở trên
2. ✅ Không học thêm kiến thức mới
3. ✅ Thở sâu, tự tin vào bản thân

**TRONG KHI THI (90 phút):**
1. ✅ Đọc kỹ đề, không vội vàng
2. ✅ Bắt đầu với bài dễ nhất
3. ✅ Comment giải thích logic
4. ✅ Test với edge cases
5. ✅ Nếu bí: next sang bài khác, quay lại sau

**SAU KHI THI:**
1. ✅ Không suy nghĩ về đề nữa
2. ✅ Tin vào những gì mình đã làm
3. ✅ Tự thưởng cho bản thân! 🎉

---

**👉 BẠN ĐÃ HỌC ĐƯỢC 9 NGÀY, ĐÃ LÀM ĐỦ BÀI TẬP, BẠN SẼ LÀM TỐT THÔI!** 💪🔥

**Chúc bạn may mắn trong kỳ thi Rookie ngày 20/10/2024!** 🚀✨