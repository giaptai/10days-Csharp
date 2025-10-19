/*
Đề thi thuật toán (thi chiều T5 16/1/2025)
2.1: Vấn đề A
Trong công ty Nashtech Việt Nam có các nhân viên mang 2 loại mã:
Mã 1 có dạng PMXXXX
Mã 2 có dạng DEVXXXX
X là chữ số từ 0 – 9, biết rằng các nhân viên công ty đều có mã như vậy và đều không giống nhau.
Viết thuật toán đếm xem có bao nhiêu nhân viên có mã tương ứng như vậy
Test case 1:
Input: PM0123, PM1222, DEV1217, DEV9872, DEV1112
Output: PM 2, DEV 3
Test case 2:
Input: PM0123, PM1222, DEV1217, DEV9872, DEV1112, PM111, DEV121, PM1231
Output: PM 3, DEV 3


2.2 Vấn đề B
Nhập 1 chuỗi bất kỳ từ bàn phím, đếm xem trong chuỗi đó có những ký tự nào với số lượng bao nhiêu
Quy định: Ký tự “ ” (dấu cách) được gọi là space, không nhập ký tự nào được gọi là empty
Test case 1:
Input: AAA BCD@#
Output: A 3, B 1, C 1, D 1, @ 1, # 1, space 1

2.3 Vấn đề C
Giả định trong trường ĐH Nashtech, sinh viên được tính điểm tổng kết học phần theo các mức như sau:
A: Từ 90% trở lên
B: Dưới 90%
C: Dưới 80%
D: Dưới 50%
F: Dưới 30%
Nhập dữ liệu cho bàn phím: Dòng 1 là số sinh viên cần tra cứu điểm, dòng 2 là mức đạt được tương ứng(trong khoảng từ 0 – 100). Hiển thị lên màn hình mức đạt được tương ứng của mỗi sinh viên và số sinh viên đạt được mức đó.
Test case 1:
Input: 
3
70, 92.5, 100
Output:
Case 1: C
Case 2: A
Case 3: A
Summary A 2, C 1
Test case 2
Input: 
4
71, 90.5, 11, 150
Output:
Case 1: C
Case 2: A
Case 3: F
Case 4: Internal Error
Summary A 1, C 1, F 1, Internal Error 1
*/

// using System.Text;

// void CountDict(string[] str)
// {
//     Dictionary<string, int> dict = new Dictionary<string, int>() { };
//     dict["PM"] = 0;
//     dict["DEV"] = 0;

//     foreach (string s in str)
//     {
//         if (s.Length == 6 && s.StartsWith("PM"))
//         {
//             string digits = s.Substring(2);
//             if (digits.All(char.IsDigit))
//             {
//                 dict["PM"] += 1;
//             }
//         }
//         else if (s.Length == 7 && s.StartsWith("DEV"))
//         {
//             string digits = s.Substring(3);
//             if (digits.All(char.IsDigit))
//             {
//                 dict["DEV"] += 1;
//             }
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


// void CharacterFrequency(string str)
// {
//     if (str.Length == 0)
//     {
//         Console.WriteLine("empty");
//         return;
//     }
//     Dictionary<string, int> freq = new Dictionary<string, int>();
//     freq["space"] = 0;
//     for (int i = 0; i < str.Length; i++)
//     {
//         string temp = Convert.ToString(str[i]);
//         if (freq.ContainsKey(temp))
//         {
//             freq[temp] += 1;
//         }
//         else if (char.IsWhiteSpace(str[i]))
//         {
//             freq["space"] += 1;
//         }
//         else
//         {
//             freq[temp] = 1;
//         }
//     }
//     int count = 0;
//     foreach (KeyValuePair<string, int> c in freq)
//     {
//         if (count == freq.Count - 1)
//         {
//             Console.Write($"{c.Key} {c.Value}");
//         }
//         else
//         {
//             Console.Write($"{c.Key} {c.Value}, ");
//         }
//         count++;
//     }
//     Console.WriteLine();
// }

// void GradingSystem(double[] scores)
// {
//     List<string> grades = new();
//     Dictionary<string, int> freq = new Dictionary<string, int>();
//     foreach (double score in scores)
//     {
//         string grade = "";
//         if (score >= 90 && score <= 100)
//         {
//             grade = "A";
//             if (freq.ContainsKey("A"))
//             {
//                 freq["A"] += 1;
//             }
//             else
//             {
//                 freq["A"] = 1;
//             }
//         }
//         else if (score >= 80 && score < 90)
//         {
//             grade = "B";
//             if (freq.ContainsKey("B"))
//             {
//                 freq["B"] += 1;
//             }
//             else
//             {
//                 freq["B"] = 1;
//             }
//         }
//         else if (score >= 50 && score < 80)
//         {
//             grade = "C";
//             if (freq.ContainsKey("C"))
//             {
//                 freq["C"] += 1;
//             }
//             else
//             {
//                 freq["C"] = 1;
//             }
//         }
//         else if (score >= 30 && score < 50)
//         {
//             grade = "D";
//             if (freq.ContainsKey("D"))
//             {
//                 freq["D"] += 1;
//             }
//             else
//             {
//                 freq["D"] = 1;
//             }
//         }
//         else if (score >= 0 && score < 30)
//         {
//             grade = "F";
//             if (freq.ContainsKey("F"))
//             {
//                 freq["F"] += 1;
//             }
//             else
//             {
//                 freq["F"] = 1;
//             }
//         }
//         else
//         {
//             grade = "Internal Error";
//             if (freq.ContainsKey("Internal Error"))
//             {
//                 freq["Internal Error"] += 1;
//             }
//             else
//             {
//                 freq["Internal Error"] = 1;
//             }
//         }
//         grades.Add(grade);
//     }

//     // store order output nếu Dictionary không giữ order
//     for (int i = 0; i < grades.Count; i++)
//     {
//         Console.WriteLine($"Case {i + 1}: {grades[i]}");
//     }

//     int cc = 0;
//     StringBuilder sb = new StringBuilder("Summary ");
//     foreach (KeyValuePair<string, int> score in freq)
//     {
//         if (cc == freq.Count - 1)
//         {
//             sb.Append($"{score.Key} {score.Value}");
//         }
//         else
//         {
//             sb.Append($"{score.Key} {score.Value}, ");
//         }
//         cc++;
//     }
//     Console.WriteLine(sb.ToString());
// }

// CountDict(["PM111", "PM0123", "PM1222", "DEV1217", "DEV9872", "DEV1112"]);
// CharacterFrequency("AAA  BCD@# ");
// GradingSystem([71, 90.5, 11, 150]);
// GradingSystem([70, 92.5, 100]);
