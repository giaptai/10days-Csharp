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

First of all, thank to Nashtech give me a chance to join this Open Day 3 to gain new experiences.
What make me different from other candidates is I am happy to learn new things and always try my best.


*/

using System.Text;

void SecondMaxNum(int[] nums)
{
    int f = int.MinValue;
    int s = int.MinValue;

    foreach (int num in nums)
    {
        if (num > f)
        {
            s = f;
            f = num;
        }
        else if (num < f && num > s)
        {
            s = num;
        }
    }
    Console.WriteLine($"Second num: {s}");
}

void ThirdMaxNum(int[] nums)
{
    int f = int.MinValue;
    int s = int.MinValue;
    int t = int.MinValue;

    foreach (int num in nums)
    {
        if (num > f)
        {
            t = s;
            s = f;
            f = num;
        }
        else if (num < f && num > s)
        {
            t = s;
            s = num;
        }
        else if (num > t)
        {
            t = num;
        }
    }
    Console.WriteLine($"Second num: {t}");
}

void ReverseString(string str)
{
    StringBuilder sb = new();
    for (int i = str.Length - 1; i >= 0; i--)
    {
        sb.Append(str[i]);
    }
    Console.WriteLine(sb.ToString());
}

void CheckPrimaryNum(int num)
{
    if (num < 2)
    {
        Console.WriteLine($"{num} is Not primary number");
        return;
    }
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine($"{num} is not primary number");
            return;
        }
    }
    Console.WriteLine($"{num} is primary number");
}

void CheckStringPalindrome(string str)
{
    int l = 0;
    int r = str.Length - 1;
    while (l < r)
    {
        if (str[l] != str[r])
        {
            Console.WriteLine("Not Palindrome");
            return;
        }
        l++;
        r--;
    }
    Console.WriteLine("Palindrome");
}

void CheckNumPalindrome(int num)
{
    if (num < 0)
    {
        num *= -1;
    }

    string str = Convert.ToString(num);
    int l = 0;
    int r = str.Length - 1;
    while (l < r)
    {
        if (str[l] != str[r])
        {
            Console.WriteLine("Not Palindrome");
            return;
        }
        l++;
        r--;
    }
    Console.WriteLine("Palindrome");
}

void Fibonnancci(int n)
{
    int a = 0;
    int b = 1;
    if (n == 0)
    {
        Console.WriteLine($"Fibonnacci thu {n}: {a}");
        return;
    }
    if (n == 1)
    {
        Console.WriteLine($"Fibonnacci thu {n}: {b}");
        return;
    }
    for (int i = 0; i < n - 1; i++)
    {
        int temp = a;
        a = b;
        b += temp;
    }
    Console.WriteLine($"Fibonnacci thu {n}: {b}");
}


void ApperenceMost(int[] nums)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    foreach (int num in nums)
    {
        if (dict.ContainsKey(num))
        {
            dict[num] += 1;
        }
        else
        {
            dict[num] = 1;
        }
    }

    int maxVal = dict.Values.Max();

    foreach (KeyValuePair<int, int> pair in dict)
    {
        if (pair.Value == maxVal)
        {
            Console.WriteLine($"Phần tử {pair.Key}: {pair.Value} lan");
        }
    }
}

void ValidParentheses(string str)
{
    Stack<char> st = new Stack<char>();
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] == '(' || str[i] == '[' || str[i] == '{')
        {
            st.Push(str[i]);
        }
        else if (str[i] == ')' || str[i] == ']' || str[i] == '}')
        {
            if (st.Count == 0)
            {
                Console.WriteLine("Not Valid Parentheses");
                return;
            }

            char top = st.Pop();
            if ((str[i] == ')' && top != '(') ||
            (str[i] == ']' && top != '[') ||
            (str[i] == '}' && top != '{')
            )
            {
                Console.WriteLine("Not Valid Parentheses");
                return;
            }
        }
    }
    Console.WriteLine(st.Count == 0 ? "Valid Parentheses" : "Not Valid Parentheses");
}

void ReverseWordsInFile()
{
    if (!File.Exists("input.txt"))
    {
        File.Create("input.txt");
    }
    if (!File.Exists("output.txt"))
    {
        File.Create("output.txt");
    }
    StreamReader reader = new StreamReader("input.txt");
    StreamWriter writer = new StreamWriter("output.txt");
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        string[] temp = line.Split(" ");
        for (int i = temp.Length - 1; i >= 0; i--)
        {
            if (i != 0)
            {
                writer.Write($"{temp[i]} ");
            }
            else
            {
                writer.Write(temp[i]);
            }
        }
        writer.WriteLine();
    }
    writer.Close();
}

void CountDict(string[] str)
{
    Dictionary<string, int> dict = new Dictionary<string, int>(){};
    dict["PM"] = 0;
    dict["DEV"] = 0;

    foreach (string s in str)
    {
        if (s.Length == 6 && s.StartsWith("PM"))
        {
            dict["PM"] += 1;
        }
        else if (s.Length == 7 && s.StartsWith("DEV"))
        {
            dict["DEV"] += 1;
        }
    }
    int c = 0;
    foreach (KeyValuePair<string, int> i in dict)
    {
        if (c == dict.Count() - 1)
        {
            Console.Write($"{i.Key} {i.Value}");
        }
        else
        {
            Console.Write($"{i.Key} {i.Value}, ");
        }
        c++;
    }
    Console.WriteLine();
}

CountDict(["PM0123", "PM1222", "DEV1217", "DEV9872", "DEV1112"]);
// SecondMaxNum(new int[] { 1, 2, 3, 5, 2, 3, 8 });
// ThirdMaxNum(new int[] { 1, 2, 3, 5, 2, 3, 8 });
// ReverseString("mot con vit Xoe");
// CheckPrimaryNum(6);
// CheckStringPalindrome("raceca1r");
// CheckNumPalindrome(123213);
// Fibonnancci(6);
// ApperenceMost([1, 2, 2, 3, 3, 4]);
// ValidParentheses("((())");
// ReverseWordsInFile();

List<bool> list = new List<bool>();

Dictionary<int, int> dict = new Dictionary<int, int>();
Stack<int> stack = new Stack<int>();
Queue<int> queue = new Queue<int>();
