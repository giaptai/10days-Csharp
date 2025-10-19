# 📅 TỔNG HỢP KIẾN THỨC DATETIME TRONG C#

---

## 🎯 Tại sao cần học DateTime?

thường có **1 câu xử lý chuỗi + DateTime**, ví dụ:
- Tính số ngày giữa 2 ngày
- Parse date string từ file
- Kiểm tra năm nhuận
- Format date theo định dạng khác
- Tìm ngày trong tuần
- Tính tuổi từ ngày sinh

---

## 📖 1. TẠO DATETIME

### **A. DateTime hiện tại**
```csharp
DateTime now = DateTime.Now;  // Ngày giờ hiện tại (local time)
Console.WriteLine(now);
// Output: 10/16/2024 3:45:30 PM

DateTime utcNow = DateTime.UtcNow;  // UTC time
Console.WriteLine(utcNow);
// Output: 10/16/2024 8:45:30 AM

DateTime today = DateTime.Today;  // Chỉ ngày (0:00:00)
Console.WriteLine(today);
// Output: 10/16/2024 12:00:00 AM
```

---

### **B. Tạo DateTime từ giá trị cụ thể**
```csharp
// Constructor: year, month, day
DateTime date1 = new DateTime(2024, 10, 16);
Console.WriteLine(date1);
// Output: 10/16/2024 12:00:00 AM

// Constructor: year, month, day, hour, minute, second
DateTime date2 = new DateTime(2024, 10, 16, 14, 30, 0);
Console.WriteLine(date2);
// Output: 10/16/2024 2:30:00 PM

// Constructor: year, month, day, hour, minute, second, millisecond
DateTime date3 = new DateTime(2024, 10, 16, 14, 30, 0, 500);
```

---

### **C. Parse DateTime từ string**
```csharp
// Parse - Ném exception nếu không hợp lệ
DateTime date1 = DateTime.Parse("10/16/2024");
DateTime date2 = DateTime.Parse("2024-10-16");
DateTime date3 = DateTime.Parse("October 16, 2024");

// TryParse - Trả về bool, không ném exception (AN TOÀN HƠN)
string input = "10/16/2024";
if (DateTime.TryParse(input, out DateTime result))
{
    Console.WriteLine($"Valid date: {result}");
}
else
{
    Console.WriteLine("Invalid date format");
}
```

---

### **D. ParseExact - Parse với format cụ thể**
```csharp
// Format: dd/MM/yyyy
string dateStr = "16/10/2024";
DateTime date = DateTime.ParseExact(dateStr, "dd/MM/yyyy", null);
Console.WriteLine(date);
// Output: 10/16/2024 12:00:00 AM

// Format: yyyy-MM-dd HH:mm:ss
string dateStr2 = "2024-10-16 14:30:00";
DateTime date2 = DateTime.ParseExact(dateStr2, "yyyy-MM-dd HH:mm:ss", null);

// TryParseExact - An toàn hơn
if (DateTime.TryParseExact("16/10/2024", "dd/MM/yyyy", null,
    System.Globalization.DateTimeStyles.None, out DateTime parsed))
{
    Console.WriteLine($"Parsed: {parsed}");
}
```

---

## 📊 2. CÁC THUỘC TÍNH (PROPERTIES)

### **A. Lấy thành phần của DateTime**
```csharp
DateTime now = DateTime.Now;

int year = now.Year;          // 2024
int month = now.Month;        // 10
int day = now.Day;            // 16
int hour = now.Hour;          // 14
int minute = now.Minute;      // 30
int second = now.Second;      // 45
int millisecond = now.Millisecond;  // 123

// Ngày trong tuần
DayOfWeek dayOfWeek = now.DayOfWeek;  // Tuesday
Console.WriteLine(dayOfWeek);         // Output: Tuesday

// Ngày trong năm (1-366)
int dayOfYear = now.DayOfYear;  // 290
```

---

### **B. Kiểm tra thời gian**
```csharp
DateTime now = DateTime.Now;

// Kiểm tra các thành phần
Console.WriteLine($"Year: {now.Year}");
Console.WriteLine($"Month: {now.Month}");
Console.WriteLine($"Day: {now.Day}");
Console.WriteLine($"Day of Week: {now.DayOfWeek}");
Console.WriteLine($"Day of Year: {now.DayOfYear}");

// Lấy chỉ date (bỏ time)
DateTime dateOnly = now.Date;
Console.WriteLine(dateOnly);
// Output: 10/16/2024 12:00:00 AM

// Lấy chỉ time
TimeSpan timeOnly = now.TimeOfDay;
Console.WriteLine(timeOnly);
// Output: 14:30:45.1234567
```

---

## 🔧 3. THAO TÁC VỚI DATETIME

### **A. Cộng trừ thời gian**
```csharp
DateTime now = DateTime.Now;

// Cộng thêm
DateTime tomorrow = now.AddDays(1);
DateTime nextWeek = now.AddDays(7);
DateTime nextMonth = now.AddMonths(1);
DateTime nextYear = now.AddYears(1);
DateTime later = now.AddHours(2).AddMinutes(30);

// Trừ đi
DateTime yesterday = now.AddDays(-1);
DateTime lastWeek = now.AddDays(-7);
DateTime lastMonth = now.AddMonths(-1);
DateTime lastYear = now.AddYears(-1);

Console.WriteLine($"Now: {now}");
Console.WriteLine($"Tomorrow: {tomorrow}");
Console.WriteLine($"Yesterday: {yesterday}");
```

---

### **B. Tính khoảng cách giữa 2 DateTime (TimeSpan)**
```csharp
DateTime start = new DateTime(2024, 10, 1);
DateTime end = new DateTime(2024, 10, 16);

// Trừ 2 DateTime → TimeSpan
TimeSpan difference = end - start;

Console.WriteLine($"Days: {difference.Days}");           // 15
Console.WriteLine($"Hours: {difference.Hours}");         // 0
Console.WriteLine($"Total Days: {difference.TotalDays}"); // 15.0
Console.WriteLine($"Total Hours: {difference.TotalHours}"); // 360.0
```

---

### **C. So sánh DateTime**
```csharp
DateTime date1 = new DateTime(2024, 10, 16);
DateTime date2 = new DateTime(2024, 10, 20);

// So sánh với toán tử
if (date1 < date2)
{
    Console.WriteLine("date1 is earlier than date2");
}

if (date1 == date2)
{
    Console.WriteLine("Same date");
}

// So sánh với method
int result = DateTime.Compare(date1, date2);
// result < 0: date1 < date2
// result = 0: date1 = date2
// result > 0: date1 > date2

if (result < 0)
{
    Console.WriteLine("date1 is earlier");
}
```

---

## 📝 4. FORMAT DATETIME (CHUYỂN THÀNH STRING)

### **A. ToString() với format chuẩn**
```csharp
DateTime now = DateTime.Now;

// Short date: 10/16/2024
Console.WriteLine(now.ToString("d"));

// Long date: Tuesday, October 16, 2024
Console.WriteLine(now.ToString("D"));

// Full date/time: Tuesday, October 16, 2024 2:30:45 PM
Console.WriteLine(now.ToString("F"));

// Short time: 2:30 PM
Console.WriteLine(now.ToString("t"));

// Long time: 2:30:45 PM
Console.WriteLine(now.ToString("T"));

// ISO 8601: 2024-10-16T14:30:45
Console.WriteLine(now.ToString("s"));
```

---

### **B. ToString() với custom format**
```csharp
DateTime now = DateTime.Now;

// dd/MM/yyyy → 16/10/2024
Console.WriteLine(now.ToString("dd/MM/yyyy"));

// yyyy-MM-dd → 2024-10-16
Console.WriteLine(now.ToString("yyyy-MM-dd"));

// dd-MMM-yyyy → 16-Oct-2024
Console.WriteLine(now.ToString("dd-MMM-yyyy"));

// dddd, MMMM dd, yyyy → Tuesday, October 16, 2024
Console.WriteLine(now.ToString("dddd, MMMM dd, yyyy"));

// HH:mm:ss → 14:30:45 (24-hour)
Console.WriteLine(now.ToString("HH:mm:ss"));

// hh:mm:ss tt → 02:30:45 PM (12-hour)
Console.WriteLine(now.ToString("hh:mm:ss tt"));

// dd/MM/yyyy HH:mm:ss → 16/10/2024 14:30:45
Console.WriteLine(now.ToString("dd/MM/yyyy HH:mm:ss"));
```

---

### **C. Format specifiers**
| Specifier | Meaning | Example |
|-----------|---------|---------|
| `yyyy` | Year (4 digits) | 2024 |
| `yy` | Year (2 digits) | 24 |
| `MM` | Month (2 digits) | 10 |
| `M` | Month (1-2 digits) | 10 |
| `MMM` | Month (short name) | Oct |
| `MMMM` | Month (full name) | October |
| `dd` | Day (2 digits) | 16 |
| `d` | Day (1-2 digits) | 16 |
| `ddd` | Day of week (short) | Tue |
| `dddd` | Day of week (full) | Tuesday |
| `HH` | Hour (24h, 2 digits) | 14 |
| `hh` | Hour (12h, 2 digits) | 02 |
| `mm` | Minute (2 digits) | 30 |
| `ss` | Second (2 digits) | 45 |
| `tt` | AM/PM | PM |

---

## ⏱️ 5. TIMESPAN

### **A. Tạo TimeSpan**
```csharp
// Constructor: hours, minutes, seconds
TimeSpan ts1 = new TimeSpan(2, 30, 0);  // 2h 30m
Console.WriteLine(ts1);  // 02:30:00

// Constructor: days, hours, minutes, seconds
TimeSpan ts2 = new TimeSpan(5, 2, 30, 0);  // 5 days 2h 30m
Console.WriteLine(ts2);  // 5.02:30:00

// Static methods
TimeSpan ts3 = TimeSpan.FromDays(7);      // 7 days
TimeSpan ts4 = TimeSpan.FromHours(24);    // 24 hours
TimeSpan ts5 = TimeSpan.FromMinutes(90);  // 90 minutes
TimeSpan ts6 = TimeSpan.FromSeconds(3600); // 3600 seconds
```

---

### **B. Thuộc tính TimeSpan**
```csharp
TimeSpan ts = new TimeSpan(5, 2, 30, 45);  // 5 days 2h 30m 45s

Console.WriteLine($"Days: {ts.Days}");           // 5
Console.WriteLine($"Hours: {ts.Hours}");         // 2
Console.WriteLine($"Minutes: {ts.Minutes}");     // 30
Console.WriteLine($"Seconds: {ts.Seconds}");     // 45

Console.WriteLine($"Total Days: {ts.TotalDays}");       // 5.10...
Console.WriteLine($"Total Hours: {ts.TotalHours}");     // 122.5125
Console.WriteLine($"Total Minutes: {ts.TotalMinutes}"); // 7350.75
Console.WriteLine($"Total Seconds: {ts.TotalSeconds}"); // 441045
```

---

### **C. Thao tác với TimeSpan**
```csharp
TimeSpan ts1 = TimeSpan.FromHours(2);
TimeSpan ts2 = TimeSpan.FromMinutes(30);

// Cộng
TimeSpan total = ts1 + ts2;  // 2h 30m
Console.WriteLine(total);

// Trừ
TimeSpan diff = ts1 - ts2;  // 1h 30m
Console.WriteLine(diff);

// So sánh
if (ts1 > ts2)
{
    Console.WriteLine("ts1 is longer");
}
```

---

## 🔥 6. PATTERNS THƯỜNG DÙNG TRONG TEST

### **Pattern 1: Tính tuổi từ ngày sinh**
```csharp
int CalculateAge(DateTime birthDate)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthDate.Year;

    // Nếu chưa qua sinh nhật năm nay, trừ 1
    if (birthDate.Date > today.AddYears(-age))
    {
        age--;
    }

    return age;
}

// Test
DateTime birthDate = new DateTime(2000, 5, 15);
int age = CalculateAge(birthDate);
Console.WriteLine($"Age: {age}");  // 24
```

---

### **Pattern 2: Kiểm tra năm nhuận**
```csharp
bool IsLeapYear(int year)
{
    return DateTime.IsLeapYear(year);
}

// Test
Console.WriteLine(IsLeapYear(2024));  // True
Console.WriteLine(IsLeapYear(2023));  // False
Console.WriteLine(IsLeapYear(2000));  // True
Console.WriteLine(IsLeapYear(1900));  // False
```

---

### **Pattern 3: Tính số ngày giữa 2 ngày**
```csharp
int DaysBetween(DateTime date1, DateTime date2)
{
    TimeSpan diff = date2 - date1;
    return Math.Abs(diff.Days);
}

// Test
DateTime start = new DateTime(2024, 10, 1);
DateTime end = new DateTime(2024, 10, 16);
int days = DaysBetween(start, end);
Console.WriteLine($"Days: {days}");  // 15
```

---

### **Pattern 4: Parse date từ string với nhiều formats**
```csharp
DateTime ParseFlexibleDate(string dateStr)
{
    string[] formats = {
        "dd/MM/yyyy",
        "MM/dd/yyyy",
        "yyyy-MM-dd",
        "dd-MM-yyyy",
        "yyyy/MM/dd"
    };

    foreach (string format in formats)
    {
        if (DateTime.TryParseExact(dateStr, format, null,
            System.Globalization.DateTimeStyles.None, out DateTime result))
        {
            return result;
        }
    }

    throw new FormatException($"Invalid date format: {dateStr}");
}

// Test
DateTime date1 = ParseFlexibleDate("16/10/2024");  // ✅
DateTime date2 = ParseFlexibleDate("2024-10-16");  // ✅
DateTime date3 = ParseFlexibleDate("10/16/2024");  // ✅
```

---

### **Pattern 5: Lấy ngày đầu/cuối tháng**
```csharp
DateTime GetFirstDayOfMonth(DateTime date)
{
    return new DateTime(date.Year, date.Month, 1);
}

DateTime GetLastDayOfMonth(DateTime date)
{
    return new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1);
}

// Test
DateTime now = DateTime.Now;
DateTime firstDay = GetFirstDayOfMonth(now);
DateTime lastDay = GetLastDayOfMonth(now);

Console.WriteLine($"First day: {firstDay:dd/MM/yyyy}");  // 01/10/2024
Console.WriteLine($"Last day: {lastDay:dd/MM/yyyy}");    // 31/10/2024
```

---

### **Pattern 6: Tính ngày làm việc (bỏ cuối tuần)**
```csharp
int CountBusinessDays(DateTime start, DateTime end)
{
    int count = 0;
    DateTime current = start;

    while (current <= end)
    {
        // Không phải Saturday (6) hoặc Sunday (0)
        if (current.DayOfWeek != DayOfWeek.Saturday &&
            current.DayOfWeek != DayOfWeek.Sunday)
        {
            count++;
        }
        current = current.AddDays(1);
    }

    return count;
}

// Test
DateTime start = new DateTime(2024, 10, 14);  // Monday
DateTime end = new DateTime(2024, 10, 20);    // Sunday
int businessDays = CountBusinessDays(start, end);
Console.WriteLine($"Business days: {businessDays}");  // 5
```

---

### **Pattern 7: Format date theo tiếng Việt**
```csharp
string FormatDateVietnamese(DateTime date)
{
    string[] daysVN = { "Chủ Nhật", "Thứ Hai", "Thứ Ba", "Thứ Tư",
                        "Thứ Năm", "Thứ Sáu", "Thứ Bảy" };

    string dayOfWeek = daysVN[(int)date.DayOfWeek];
    string formatted = $"{dayOfWeek}, ngày {date.Day:D2} tháng {date.Month:D2} năm {date.Year}";

    return formatted;
}

// Test
DateTime now = DateTime.Now;
Console.WriteLine(FormatDateVietnamese(now));
// Output: Thứ Tư, ngày 16 tháng 10 năm 2024
```

---

### **Pattern 8: Đọc dates từ file và sort**
```csharp
void SortDatesInFile(string inputFile, string outputFile)
{
    var dates = new List<DateTime>();

    // Đọc file và parse dates
    foreach (string line in File.ReadLines(inputFile))
    {
        if (DateTime.TryParse(line.Trim(), out DateTime date))
        {
            dates.Add(date);
        }
    }

    // Sort tăng dần
    dates.Sort();

    // Ghi ra file
    using (StreamWriter writer = new StreamWriter(outputFile))
    {
        foreach (DateTime date in dates)
        {
            writer.WriteLine(date.ToString("yyyy-MM-dd"));
        }
    }
}
```

---

## 🎯 7. BÀI TẬP THỰC HÀNH

### **Bài 1: Kiểm tra ngày hợp lệ**
```csharp
bool IsValidDate(int year, int month, int day)
{
    try
    {
        DateTime date = new DateTime(year, month, day);
        return true;
    }
    catch
    {
        return false;
    }
}

// Test
Console.WriteLine(IsValidDate(2024, 2, 29));   // True (leap year)
Console.WriteLine(IsValidDate(2023, 2, 29));   // False
Console.WriteLine(IsValidDate(2024, 13, 1));   // False
```

---

### **Bài 2: Tìm ngày gần nhất**
```csharp
DateTime FindClosestDate(DateTime target, List<DateTime> dates)
{
    DateTime closest = dates[0];
    TimeSpan minDiff = TimeSpan.MaxValue;

    foreach (DateTime date in dates)
    {
        TimeSpan diff = (date - target).Duration();
        if (diff < minDiff)
        {
            minDiff = diff;
            closest = date;
        }
    }

    return closest;
}
```

---

### **Bài 3: Tính số tuần giữa 2 ngày**
```csharp
int WeeksBetween(DateTime date1, DateTime date2)
{
    TimeSpan diff = date2 - date1;
    return (int)(diff.TotalDays / 7);
}

// Test
DateTime start = new DateTime(2024, 10, 1);
DateTime end = new DateTime(2024, 10, 16);
Console.WriteLine($"Weeks: {WeeksBetween(start, end)}");  // 2
```

---

### **Bài 4: Tìm tất cả Monday trong tháng**
```csharp
List<DateTime> GetAllMondays(int year, int month)
{
    var mondays = new List<DateTime>();
    DateTime firstDay = new DateTime(year, month, 1);
    DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

    for (DateTime date = firstDay; date <= lastDay; date = date.AddDays(1))
    {
        if (date.DayOfWeek == DayOfWeek.Monday)
        {
            mondays.Add(date);
        }
    }

    return mondays;
}

// Test
var mondays = GetAllMondays(2024, 10);
foreach (var monday in mondays)
{
    Console.WriteLine(monday.ToString("yyyy-MM-dd"));
}
```

---

### **Bài 5: Parse date từ format tùy chỉnh**
```csharp
// Input: "16-Oct-2024"
// Output: DateTime object

DateTime ParseCustomDate(string dateStr)
{
    return DateTime.ParseExact(dateStr, "dd-MMM-yyyy", null);
}

// Test
DateTime date = ParseCustomDate("16-Oct-2024");
Console.WriteLine(date);  // 10/16/2024 12:00:00 AM
```

---

## 🚨 8. LỖI THƯỜNG GẶP

### **Lỗi 1: Parse date sai format**
```csharp
// ❌ SAI: Parse "16/10/2024" với culture US
DateTime date = DateTime.Parse("16/10/2024");  // Lỗi: Month = 16?

// ✅ ĐÚNG: Dùng ParseExact
DateTime date = DateTime.ParseExact("16/10/2024", "dd/MM/yyyy", null);
```

---

### **Lỗi 2: Quên kiểm tra năm nhuận**
```csharp
// ❌ SAI: Hardcode 28 days
int febDays = 28;

// ✅ ĐÚNG: Check leap year
int febDays = DateTime.IsLeapYear(year) ? 29 : 28;
```

---

### **Lỗi 3: So sánh DateTime có time component**
```csharp
DateTime date1 = DateTime.Now;  // 2024-10-16 14:30:45
DateTime date2 = new DateTime(2024, 10, 16);  // 2024-10-16 00:00:00

// ❌ SAI: date1 != date2 vì time khác nhau
if (date1 == date2) { }  // False!

// ✅ ĐÚNG: So sánh chỉ date
if (date1.Date == date2.Date) { }  // True!
```

---

## ✅ 9. CHECKLIST CHO TEST

- [ ] Biết parse date từ string với `TryParse` hoặc `TryParseExact`?
- [ ] Biết format date sang string với `ToString()`?
- [ ] Biết tính khoảng cách giữa 2 dates (TimeSpan)?
- [ ] Biết kiểm tra năm nhuận với `DateTime.IsLeapYear()`?
- [ ] Biết cộng/trừ days, months, years với `AddDays()`, `AddMonths()`, `AddYears()`?
- [ ] Biết so sánh dates với `<`, `>`, `==`?
- [ ] Biết xử lý exception khi parse date?
- [ ] Test với edge cases: năm nhuận, ngày không hợp lệ?

---

## 🎯 10. CODE TEMPLATE CHO

### **Template: Xử lý date từ file**
```csharp
void ProcessDatesFromFile(string inputFile, string outputFile)
{
    try
    {
        if (!File.Exists(inputFile))
        {
            throw new FileNotFoundException($"{inputFile} not found!");
        }

        using (StreamReader reader = new StreamReader(inputFile))
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                if (DateTime.TryParse(line, out DateTime date))
                {
                    // Xử lý date ở đây
                    string result = ProcessDate(date);
                    writer.WriteLine(result);
                }
                else
                {
                    Console.WriteLine($"Invalid date: {line}");
                }
            }
        }

        Console.WriteLine("✅ Success!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Error: {ex.Message}");
    }
}

string ProcessDate(DateTime date)
{
    // Your logic here
    return date.ToString("yyyy-MM-dd");
}
```

---

**DONE! Đây là tất cả kiến thức DateTime bạn cần cho test!** 🚀📅
