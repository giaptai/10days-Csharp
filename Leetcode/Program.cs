/*
- tìm số lớn thứ hai trong mảng
- tìm số lớn thứ ba trong mảng
- đảo ngược chuỗi
- kiểm tra số nguyên tố

https://voz.vn/t/xin-%C4%91uoc-anh-chi-%C4%91i-truoc-tu-van-ve-khoa-rookie-nashtech-a.936330/
- kiểm tra đối xứng
- tính trung bình
- xử lý chuỗi

https://voz.vn/t/thac-mac-ve-chuong-trinh-rockies-cua-nashtech.917924/page-3
- 1 câu valid parentheses
- 1 câu tính toán trên matrix
- 1 câu xử lý chuỗi + gợi ý sử dụng lib/package datetime
- mảng stack và xử lý input
- quanh quanh các ctdl cơ bản stack, queue, hashmap, array với xử lý chuỗi thôi bác
- 1 bài palindrome checker
- 1 bài palindrome check nhưng mà với số
- 1 bài fibonnacci
- 1 bài dãy số nguyên tố
- Đề bài là tìm những số có số lần xuất hiện lớn nhất.
    VD: 1-2-2-3-3-4 thì kết quả là 2 và 3.
        1-2-2-3-3-2-4 thì kết quả là 2.

- Bạn có một file text input.txt, mỗi dòng chứa một câu (string).
Viết chương trình đọc file đó, mỗi dòng đảo ngược thứ tự các từ (word-level, không phải ký tự), rồi ghi ra file output.txt.

English test: 40 câu trắc nghiệm và 1 câu viết 70 - 100 từ
-  1 đoạn nói về khác biệt của bản thân so với các ứng viên khác

First of all, thank you to Nashtech for giving me a chance to join this Open Day 3 and gain new experiences. 
What makes me different from other candidates is that I am always happy to learn new things and try my best in every task. 
I am not afraid of challenges because I see them as opportunities to grow. 
I also enjoy working with others and sharing ideas, which helps me improve faster. 
With this attitude, I believe I can contribute positively to the team.

In a competitive job market, I believe the best way to show employers that I am the right candidate is through my attitude and skills. 
I always prepare carefully, demonstrate responsibility, and show respect for teamwork. 
I highlight my strengths with real examples, such as solving problems quickly or supporting colleagues. 
I also keep learning to improve myself. By combining professional knowledge with a positive mindset, I can prove that I will bring value and grow with the company.
*/

// using System.Text;

// void SecondMaxNum(int[] nums)
// {
//     int f = int.MinValue;
//     int s = int.MinValue;

//     foreach (int num in nums)
//     {
//         if (num > f)
//         {
//             s = f;
//             f = num;
//         }
//         else if (num < f && num > s)
//         {
//             s = num;
//         }
//     }
//     Console.WriteLine($"Second num: {s}");
// }

// void ThirdMaxNum(int[] nums)
// {
//     int f = int.MinValue;
//     int s = int.MinValue;
//     int t = int.MinValue;

//     foreach (int num in nums)
//     {
//         if (num > f)
//         {
//             t = s;
//             s = f;
//             f = num;
//         }
//         else if (num < f && num > s)
//         {
//             t = s;
//             s = num;
//         }
//         else if (num > t)
//         {
//             t = num;
//         }
//     }
//     Console.WriteLine($"Second num: {t}");
// }

// void ReverseString(string str)
// {
//     StringBuilder sb = new();
//     for (int i = str.Length - 1; i >= 0; i--)
//     {
//         sb.Append(str[i]);
//     }
//     Console.WriteLine(sb.ToString());
// }

// void CheckPrimaryNum(int num)
// {
//     if (num < 2)
//     {
//         Console.WriteLine($"{num} is Not primary number");
//         return;
//     }
//     for (int i = 2; i <= Math.Sqrt(num); i++)
//     {
//         if (num % i == 0)
//         {
//             Console.WriteLine($"{num} is not primary number");
//             return;
//         }
//     }
//     Console.WriteLine($"{num} is primary number");
// }

// void CheckStringPalindrome(string str)
// {
//     int l = 0;
//     int r = str.Length - 1;
//     while (l < r)
//     {
//         if (str[l] != str[r])
//         {
//             Console.WriteLine("Not Palindrome");
//             return;
//         }
//         l++;
//         r--;
//     }
//     Console.WriteLine("Palindrome");
// }

// void CheckNumPalindrome(int num)
// {
//     if (num < 0)
//     {
//         num *= -1;
//     }

//     string str = Convert.ToString(num);
//     int l = 0;
//     int r = str.Length - 1;
//     while (l < r)
//     {
//         if (str[l] != str[r])
//         {
//             Console.WriteLine("Not Palindrome");
//             return;
//         }
//         l++;
//         r--;
//     }
//     Console.WriteLine("Palindrome");
// }

// void Fibonnancci(int n)
// {
//     int a = 0;
//     int b = 1;
//     if (n == 0)
//     {
//         Console.WriteLine($"Fibonnacci thu {n}: {a}");
//         return;
//     }
//     if (n == 1)
//     {
//         Console.WriteLine($"Fibonnacci thu {n}: {b}");
//         return;
//     }
//     for (int i = 0; i < n - 1; i++)
//     {
//         int temp = a;
//         a = b;
//         b += temp;
//     }
//     Console.WriteLine($"Fibonnacci thu {n}: {b}");
// }


// void ApperenceMost(int[] nums)
// {
//     Dictionary<int, int> dict = new Dictionary<int, int>();
//     foreach (int num in nums)
//     {
//         if (dict.ContainsKey(num))
//         {
//             dict[num] += 1;
//         }
//         else
//         {
//             dict[num] = 1;
//         }
//     }

//     int maxVal = dict.Values.Max();

//     foreach (KeyValuePair<int, int> pair in dict)
//     {
//         if (pair.Value == maxVal)
//         {
//             Console.WriteLine($"Phần tử {pair.Key}: {pair.Value} lan");
//         }
//     }
// }

// void ValidParentheses(string str)
// {
//     Stack<char> st = new Stack<char>();
//     for (int i = 0; i < str.Length; i++)
//     {
//         if (str[i] == '(' || str[i] == '[' || str[i] == '{')
//         {
//             st.Push(str[i]);
//         }
//         else if (str[i] == ')' || str[i] == ']' || str[i] == '}')
//         {
//             if (st.Count == 0)
//             {
//                 Console.WriteLine("Not Valid Parentheses");
//                 return;
//             }

//             char top = st.Pop();
//             if ((str[i] == ')' && top != '(') ||
//             (str[i] == ']' && top != '[') ||
//             (str[i] == '}' && top != '{')
//             )
//             {
//                 Console.WriteLine("Not Valid Parentheses");
//                 return;
//             }
//         }
//     }
//     Console.WriteLine(st.Count == 0 ? "Valid Parentheses" : "Not Valid Parentheses");
// }

// void ReverseWordsInFile()
// {
//     if (!File.Exists("input.txt"))
//     {
//         File.Create("input.txt");
//     }
//     if (!File.Exists("output.txt"))
//     {
//         File.Create("output.txt");
//     }
//     StreamReader reader = new StreamReader("input.txt");
//     StreamWriter writer = new StreamWriter("output.txt");
//     string? line;
//     while ((line = reader.ReadLine()) != null)
//     {
//         string[] temp = line.Split(" ");
//         for (int i = temp.Length - 1; i >= 0; i--)
//         {
//             if (i != 0)
//             {
//                 writer.Write($"{temp[i]} ");
//             }
//             else
//             {
//                 writer.Write(temp[i]);
//             }
//         }
//         writer.WriteLine();
//     }
//     writer.Close();
// }

// void CountDict(string[] str)
// {
//     Dictionary<string, int> dict = new Dictionary<string, int>() { };
//     dict["PM"] = 0;
//     dict["DEV"] = 0;

//     foreach (string s in str)
//     {
//         if (s.Length == 6 && s.StartsWith("PM"))
//         {
//             dict["PM"] += 1;
//         }
//         else if (s.Length == 7 && s.StartsWith("DEV"))
//         {
//             dict["DEV"] += 1;
//         }
//     }
//     int c = 0;
//     foreach (KeyValuePair<string, int> i in dict)
//     {
//         if (c == dict.Count() - 1)
//         {
//             Console.Write($"{i.Key} {i.Value}");
//         }
//         else
//         {
//             Console.Write($"{i.Key} {i.Value}, ");
//         }
//         c++;
//     }
//     Console.WriteLine();
// }


// void SpiralMatrix(int[][] matrix)
// {
//     List<int> result = new List<int>();
//     if (matrix.Length == 0)
//     {
//         Console.WriteLine($"Matrix length is zero");
//     }

//     int r = matrix.Length;
//     int c = matrix[0].Length;

//     int top = 0;
//     int bottom = r - 1;
//     int left = 0;
//     int right = c - 1;

//     while (left <= right && top <= bottom)
//     {
//         // Duyệt từ trái sang phải trên hàng trên cùng
//         for (int i = left; i <= right; i++)
//         {
//             result.Add(matrix[top][i]);
//         }
//         top++;

//         // Duyệt từ trên xuống dưới trên cột phải cùng
//         for (int i = top; i <= bottom; i++)
//         {
//             result.Add(matrix[i][right]);
//         }
//         right--;

//         // Duyệt từ phải sang trái trên hàng dưới cùng
//         if (top <= bottom)
//         {
//             for (int i = right; i >= left; i--)
//             {
//                 result.Add(matrix[bottom][i]);
//             }
//             bottom--;
//         }

//         // Duyệt từ dưới lên trên trên cột trái cùng
//         if (left <= right)
//         {
//             for (int i = bottom; i >= top; i--)
//             {
//                 result.Add(matrix[i][left]);
//             }
//             left++;
//         }
//     }
//     foreach (int num in result)
//     {
//         Console.Write($"{num}, ");
//     }
// }

// void MissingNumber(int[] nums)
// {
//     // Tìm giá trị nhỏ nhất và lớn nhất trong mảng (đã sắp xếp)
//     int minVal = nums[0];
//     int maxVal = nums[nums.Length - 1];

//     // Số phần tử của dãy đầy đủ (ví dụ: {2,3,4,5,6,7,8} có 7 phần tử)
//     int nComplete = maxVal - minVal + 1;

//     // Tính tổng của dãy đầy đủ
//     int expectedSum = nComplete * (minVal + maxVal) / 2;

//     // Tính tổng thực tế của các phần tử trong mảng
//     int realSum = 0;
//     foreach (int num in nums)
//     {
//         realSum += num;
//     }

//     // In ra số bị thiếu
//     Console.WriteLine(expectedSum - realSum);
// }
// void LogFile()
// {
//     string r_path = "server.log";
//     string in_path = "report.txt";
//     Dictionary<string, int> dict = new Dictionary<string, int>();
//     dict["INFO"] = 0;
//     dict["ERROR"] = 0;
//     dict["WARNING"] = 0;
//     List<string> errors = new List<string>();
//     if (!File.Exists(r_path))
//     {
//         throw new FileNotFoundException();
//     }
//     else
//     {
//         using (StreamReader reader = new StreamReader(r_path))
//         {
//             string? line;
//             while ((line = reader.ReadLine()) != null)
//             {
//                 if (line.Contains("[INFO]"))
//                 {
//                     dict["INFO"] += 1;
//                 }
//                 else if (line.Contains("[ERROR]"))
//                 {
//                     dict["ERROR"] += 1;
//                     errors.Add(line.Substring(30));
//                 }
//                 else if (line.Contains("[WARNING]"))
//                 {
//                     dict["WARNING"] += 1;
//                 }
//             }
//         }
//         using (StreamWriter writer = new StreamWriter(in_path, append: false))
//         {
//             int total_logs = dict.Values.Sum();
//             writer.WriteLine("========== SERVER LOG ANALYSIS ==========");
//             writer.WriteLine("Total Logs: " + total_logs);
//             writer.WriteLine();
//             writer.WriteLine("LOG LEVEL STATISTICS:");
//             foreach (KeyValuePair<string, int> log in dict)
//             {
//                 writer.WriteLine($"- {log.Key}: {log.Value} ({log.Value * 1.0F / total_logs * 100:F2}%)");
//             }
//             writer.WriteLine();
//             KeyValuePair<string, int> maxE = dict.OrderByDescending(x => x.Value).First();
//             writer.WriteLine("MOST FREQUENT LEVEL: " + maxE.Key);
//             writer.WriteLine();
//             writer.WriteLine("ERROR MESSAGES:");
//             for (int i = 0; i < errors.Count(); i++)
//             {
//                 writer.WriteLine($"{i + 1}. {errors[i]}");
//             }
//             writer.WriteLine("=========================================");
//         }
//     }
// }
// LogFile();
// // MissingNumber(new int[] { 2, 3, 4, 5, 6, 8 });
// // SpiralMatrix(new int[][] { [1, 2, 3], [4, 5, 6], [7, 8, 9] });
// // CountDict(["PM0123", "PM1222", "DEV1217", "DEV9872", "DEV1112"]);
// // SecondMaxNum(new int[] { 1, 2, 3, 5, 2, 3, 8 });
// // ThirdMaxNum(new int[] { 1, 2, 3, 5, 2, 3, 8 });
// // ReverseString("mot con vit Xoe");
// // CheckPrimaryNum(6);
// // CheckStringPalindrome("raceca1r");
// // CheckNumPalindrome(123213);
// // Fibonnancci(6);
// // ApperenceMost([1, 2, 2, 3, 3, 4]);
// // ValidParentheses("((())");
// // ReverseWordsInFile();

// // List<bool> list = new List<bool>();

// // Dictionary<int, int> dict = new Dictionary<int, int>();
// // Stack<int> stack = new Stack<int>();
// // stack.Push(1);
// // stack.Pop();
// // stack.Peek();
// // Queue<int> queue = new Queue<int>();

DateTime now = DateTime.Now;
Console.WriteLine(now);

DateTime utcNow = DateTime.UtcNow;
Console.WriteLine(utcNow);

DateTime today = DateTime.Today;
Console.WriteLine(today);

DateTime date1 = new DateTime(2024, 10, 16);
Console.WriteLine(date1);

DateTime date2 = new DateTime(2024, 10, 16, 14, 30, 0);
Console.WriteLine(date2);

DateTime date3 = new DateTime(2024, 10, 16, 14, 30, 0, 500);
Console.WriteLine(date3);

bool isLeapYear = DateTime.IsLeapYear(now.Year);
Console.WriteLine(isLeapYear);

TimeSpan times = now - date1;
Console.WriteLine(times.Days);
// Console.WriteLine(times.TotalDays);
// Console.WriteLine(times.TotalHours);
// Console.WriteLine(times.TotalMinutes);

DateTime dateTimeParse = DateTime.Parse("2025/10/20");

DateTime dateOnly = dateTimeParse.Date;
Console.WriteLine(dateOnly);

Console.WriteLine(dateTimeParse.Date.ToString("yyyy-MM-dd"));

Console.WriteLine(now.DayOfWeek);

Console.WriteLine(now.Year - 2001);






