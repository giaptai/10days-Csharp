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
- 

English test: 40 câu trắc nghiệm và 1 câu viết 70 - 100 từ
-  1 đoạn nói về khác biệt của bản thân so với các ứng viên khác
- First, thank to Nashtech give me an opportunity to attandance test interview, I am happy to retain new experience
As 
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
        else
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
    for (int i = 2; i < Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine($"{num} is not primary number");
            return;
        }
        Console.WriteLine($"{num} is primary number");
    }
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


SecondMaxNum(new int[] { 1, 2, 3, 5, 2, 3, 8 });
ThirdMaxNum(new int[] { 1, 2, 3, 5, 2, 3, 8 });
ReverseString("mot con vit Xoe");
CheckPrimaryNum(6);
CheckStringPalindrome("raceca1r");
CheckNumPalindrome(123213);
Fibonnancci(6);
