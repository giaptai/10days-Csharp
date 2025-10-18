# 📚 TỔNG HỢP KIẾN THỨC FILE I/O TRONG C#

---

## 📖 1. CÁC CÁCH ĐỌC FILE

### **A. File.ReadAllLines() - Đọc toàn bộ file thành mảng**
```csharp
string[] lines = File.ReadAllLines("input.txt");
foreach (string line in lines)
{
    Console.WriteLine(line);
}
```
**Ưu điểm:** Đơn giản, ngắn gọn
**Nhược điểm:** Load toàn bộ file vào RAM

---

### **B. File.ReadAllText() - Đọc toàn bộ file thành 1 string**
```csharp
string content = File.ReadAllText("input.txt");
Console.WriteLine(content);
```
**Ưu điểm:** Nhanh, đơn giản
**Nhược điểm:** Không tách từng dòng

---

### **C. StreamReader - Đọc từng dòng (KHUYÊN DÙNG)**
```csharp
using (StreamReader reader = new StreamReader("input.txt"))
{
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
} // Tự động đóng file nhờ 'using'
```
**Ưu điểm:** Tiết kiệm RAM, đọc từng dòng
**Khi nào dùng:** File lớn, cần xử lý từng dòng

---

### **D. File.ReadLines() - Đọc lazy (IEnumerable)**
```csharp
foreach (string line in File.ReadLines("input.txt"))
{
    Console.WriteLine(line);
}
```
**Ưu điểm:** Lazy loading, tiết kiệm RAM
**Khi nào dùng:** File lớn, foreach đơn giản

---

## ✍️ 2. CÁC CÁCH GHI FILE

### **A. File.WriteAllLines() - Ghi mảng ra file**
```csharp
string[] lines = { "Line 1", "Line 2", "Line 3" };
File.WriteAllLines("output.txt", lines);
```
**Lưu ý:** GHI ĐÈ (overwrite) file cũ

---

### **B. File.WriteAllText() - Ghi 1 string ra file**
```csharp
string content = "Hello\nWorld";
File.WriteAllText("output.txt", content);
```
**Lưu ý:** GHI ĐÈ (overwrite) file cũ

---

### **C. StreamWriter - Ghi từng dòng (KHUYÊN DÙNG)**
```csharp
using (StreamWriter writer = new StreamWriter("output.txt"))
{
    writer.WriteLine("Line 1");
    writer.WriteLine("Line 2");
    writer.Write("No newline"); // Không xuống dòng
} // Tự động flush và đóng file
```
**Ưu điểm:** Linh hoạt, ghi từng dòng
**Khi nào dùng:** Cần ghi từng dòng, file lớn

---

### **D. File.AppendAllText() - Ghi thêm vào cuối file**
```csharp
File.AppendAllText("output.txt", "New line\n");
```
**Lưu ý:** KHÔNG GHI ĐÈ, thêm vào cuối file

---

### **E. File.AppendAllLines() - Ghi thêm nhiều dòng**
```csharp
string[] newLines = { "Line 4", "Line 5" };
File.AppendAllLines("output.txt", newLines);
```

---

## 🔍 3. KIỂM TRA & TẠO FILE

### **A. Kiểm tra file tồn tại**
```csharp
if (File.Exists("input.txt"))
{
    Console.WriteLine("File exists!");
}
else
{
    Console.WriteLine("File not found!");
}
```

---

### **B. Tạo file mới**
```csharp
// Cách 1: Tạo file trống (PHẢI ĐÓNG!)
File.Create("input.txt").Close();

// Cách 2: Tạo file với nội dung trống
File.WriteAllText("input.txt", "");

// Cách 3: Dùng using
using (FileStream fs = File.Create("input.txt"))
{
    // File tự động đóng
}
```

---

### **C. Xóa file**
```csharp
if (File.Exists("file.txt"))
{
    File.Delete("file.txt");
}
```

---

### **D. Copy file**
```csharp
File.Copy("source.txt", "destination.txt", overwrite: true);
```

---

### **E. Di chuyển/Đổi tên file**
```csharp
File.Move("old.txt", "new.txt");
```

---

## 📂 4. THAO TÁC VỚI THƯ MỤC (DIRECTORY)

### **A. Kiểm tra thư mục tồn tại**
```csharp
if (Directory.Exists("MyFolder"))
{
    Console.WriteLine("Directory exists!");
}
```

---

### **B. Tạo thư mục**
```csharp
Directory.CreateDirectory("MyFolder/SubFolder");
```

---

### **C. Lấy tất cả files trong thư mục**
```csharp
string[] files = Directory.GetFiles("MyFolder");
foreach (string file in files)
{
    Console.WriteLine(file);
}
```

---

### **D. Lấy tất cả files với pattern**
```csharp
string[] txtFiles = Directory.GetFiles("MyFolder", "*.txt");
string[] allFiles = Directory.GetFiles("MyFolder", "*.*", SearchOption.AllDirectories);
```

---

## 🚨 5. XỬ LÝ LỖI (EXCEPTION HANDLING)

### **A. Try-Catch cơ bản**
```csharp
try
{
    string content = File.ReadAllText("input.txt");
    Console.WriteLine(content);
}
catch (FileNotFoundException)
{
    Console.WriteLine("File not found!");
}
catch (IOException ex)
{
    Console.WriteLine($"I/O Error: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
```

---

### **B. Template an toàn**
```csharp
void SafeReadFile(string filePath)
{
    try
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"{filePath} not found!");
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
```

---

## 🎯 6. PATTERNS THƯỜNG DÙNG

### **A. Đọc file → Xử lý → Ghi file**
```csharp
using (StreamReader reader = new StreamReader("input.txt"))
using (StreamWriter writer = new StreamWriter("output.txt"))
{
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        string processedLine = ProcessLine(line);
        writer.WriteLine(processedLine);
    }
}
```

---

### **B. Đọc CSV file**
```csharp
var lines = File.ReadAllLines("data.csv");

// Bỏ qua header
for (int i = 1; i < lines.Length; i++)
{
    string[] values = lines[i].Split(',');

    string id = values[0];
    string name = values[1];
    int age = int.Parse(values[2]);

    Console.WriteLine($"{id}: {name}, {age}");
}
```

---

### **C. Ghi CSV file**
```csharp
using (StreamWriter writer = new StreamWriter("output.csv"))
{
    // Header
    writer.WriteLine("ID,Name,Age");

    // Data
    writer.WriteLine("1,John,25");
    writer.WriteLine("2,Jane,30");
}
```

---

### **D. Đọc file theo chunks (file lớn)**
```csharp
const int BUFFER_SIZE = 4096;
using (FileStream fs = new FileStream("large.txt", FileMode.Open))
using (StreamReader reader = new StreamReader(fs, Encoding.UTF8, true, BUFFER_SIZE))
{
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        ProcessLine(line);
    }
}
```

---

## 📊 7. SO SÁNH CÁC PHƯƠNG PHÁP

| Method | RAM Usage | Speed | Best For |
|--------|-----------|-------|----------|
| **File.ReadAllLines()** | Cao | Nhanh | File nhỏ (< 10MB) |
| **File.ReadAllText()** | Cao | Rất nhanh | File nhỏ, không cần tách dòng |
| **StreamReader** | Thấp | Trung bình | File lớn, xử lý từng dòng |
| **File.ReadLines()** | Thấp | Trung bình | File lớn, foreach đơn giản |

---

## 🔥 8. TIPS QUAN TRỌNG

### **✅ Best Practices**
1. **Luôn dùng `using`** với StreamReader/StreamWriter
2. **Kiểm tra file tồn tại** trước khi đọc
3. **Dùng try-catch** để handle errors
4. **Đóng file** sau khi xử lý (hoặc dùng using)
5. **Dùng Path.Combine()** để nối đường dẫn

```csharp
string filePath = Path.Combine("folder", "file.txt");
// Windows: folder\file.txt
// Linux: folder/file.txt
```

---

### **❌ Common Mistakes**
1. Quên đóng file → memory leak
2. Dùng `File.Create()` mà không `.Close()`
3. Không handle `FileNotFoundException`
4. Dùng `\n` thay vì `WriteLine()` (line ending khác Windows/Linux)
5. Không dùng `using` → file không đóng khi có exception

---

## 🛠️ 9. CODE TEMPLATES

### **Template 1: Đọc và xử lý file đơn giản**
```csharp
void ProcessFile(string inputPath, string outputPath)
{
    if (!File.Exists(inputPath))
    {
        Console.WriteLine("File not found!");
        return;
    }

    using (StreamReader reader = new StreamReader(inputPath))
    using (StreamWriter writer = new StreamWriter(outputPath))
    {
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            // Xử lý từng dòng
            string result = ProcessLine(line);
            writer.WriteLine(result);
        }
    }
}
```

---

### **Template 2: Đọc và xử lý file với Exception**
```csharp
void ProcessFileSafe(string inputPath, string outputPath)
{
    try
    {
        if (!File.Exists(inputPath))
        {
            throw new FileNotFoundException($"{inputPath} not found!");
        }

        using (StreamReader reader = new StreamReader(inputPath))
        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                string result = ProcessLine(line);
                writer.WriteLine(result);
            }
        }

        Console.WriteLine("✅ Success!");
    }
    catch (FileNotFoundException ex)
    {
        Console.WriteLine($"❌ File Error: {ex.Message}");
    }
    catch (IOException ex)
    {
        Console.WriteLine($"❌ I/O Error: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Error: {ex.Message}");
    }
}
```

---

### **Template 3: Đọc CSV với class**
```csharp
class Student
{
    public string ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

List<Student> ReadCSV(string filePath)
{
    var students = new List<Student>();
    var lines = File.ReadAllLines(filePath);

    // Bỏ qua header
    for (int i = 1; i < lines.Length; i++)
    {
        var parts = lines[i].Split(',');
        students.Add(new Student
        {
            ID = parts[0],
            Name = parts[1],
            Age = int.Parse(parts[2])
        });
    }

    return students;
}
```

---

## 📝 10. BÀI TẬP THỰC HÀNH

### **Bài 1: Đếm số dòng**
```csharp
int CountLines(string filePath)
{
    return File.ReadAllLines(filePath).Length;
}
```

---

### **Bài 2: Đếm số từ trong file**
```csharp
int CountWords(string filePath)
{
    int count = 0;
    foreach (string line in File.ReadLines(filePath))
    {
        count += line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
    }
    return count;
}
```

---

### **Bài 3: Tìm dòng dài nhất**
```csharp
string FindLongestLine(string filePath)
{
    string longest = "";
    foreach (string line in File.ReadLines(filePath))
    {
        if (line.Length > longest.Length)
        {
            longest = line;
        }
    }
    return longest;
}
```

---

### **Bài 4: Copy file và chuyển UPPERCASE**
```csharp
void CopyToUpper(string input, string output)
{
    using (StreamReader reader = new StreamReader(input))
    using (StreamWriter writer = new StreamWriter(output))
    {
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            writer.WriteLine(line.ToUpper());
        }
    }
}
```

---

### **Bài 5: Filter lines chứa keyword**
```csharp
void FilterLines(string input, string output, string keyword)
{
    using (StreamReader reader = new StreamReader(input))
    using (StreamWriter writer = new StreamWriter(output))
    {
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            if (line.Contains(keyword))
            {
                writer.WriteLine(line);
            }
        }
    }
}
```

---

### **Bài 6: Đảo ngược từng dòng**
```csharp
void ReverseLines(string input, string output)
{
    using (StreamReader reader = new StreamReader(input))
    using (StreamWriter writer = new StreamWriter(output))
    {
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            char[] chars = line.ToCharArray();
            Array.Reverse(chars);
            writer.WriteLine(new string(chars));
        }
    }
}
```

---

### **Bài 7: Đảo ngược thứ tự các từ**
```csharp
void ReverseWords(string input, string output)
{
    using (StreamReader reader = new StreamReader(input))
    using (StreamWriter writer = new StreamWriter(output))
    {
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            string[] words = line.Split(' ');
            Array.Reverse(words);
            writer.WriteLine(string.Join(" ", words));
        }
    }
}
```

---

### **Bài 8: Xóa dòng trống**
```csharp
void RemoveEmptyLines(string input, string output)
{
    var lines = File.ReadAllLines(input)
                    .Where(line => !string.IsNullOrWhiteSpace(line));
    File.WriteAllLines(output, lines);
}
```

---

### **Bài 9: Đếm tần suất từ**
```csharp
void CountWordFrequency(string filePath)
{
    var frequency = new Dictionary<string, int>();

    foreach (string line in File.ReadLines(filePath))
    {
        string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            string lower = word.ToLower();
            if (frequency.ContainsKey(lower))
                frequency[lower]++;
            else
                frequency[lower] = 1;
        }
    }

    foreach (var pair in frequency.OrderByDescending(p => p.Value))
    {
        Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
}
```

---

### **Bài 10: Merge nhiều files**
```csharp
void MergeFiles(string[] inputFiles, string outputFile)
{
    using (StreamWriter writer = new StreamWriter(outputFile))
    {
        foreach (string file in inputFiles)
        {
            foreach (string line in File.ReadLines(file))
            {
                writer.WriteLine(line);
            }
        }
    }
}
```

---

## 🎯 11. CHECKLIST CHO NASHTECH TEST

- [ ] Kiểm tra file tồn tại trước khi đọc?
- [ ] Dùng `using` với StreamReader/StreamWriter?
- [ ] Có try-catch để handle exceptions?
- [ ] Test với file trống?
- [ ] Test với file 1 dòng?
- [ ] Test với file có spaces/empty lines?
- [ ] Đóng tất cả file streams?
- [ ] Code có comments?

---

**DONE! Đây là tất cả kiến thức File I/O bạn cần cho Nashtech test!** 🚀
