// // IF ELSE 
// int age = 20;
// if (age < 20)
// {
//     Console.WriteLine("Chưa đử tuổi");
// }
// else if (age < 60)
// {
//     Console.WriteLine("Đủ tuổi lao động");
// }
// else
// {
//     Console.WriteLine("Đã nghỉ hưu");
// }
// // END IF ELSE 

// // SWITCH
// Console.Write("Nhập ngày (1-7): ");
// int day = Convert.ToInt32(Console.ReadLine());
// switch (day)
// {
//     case 1:
//         Console.WriteLine("Thứ Hai");
//         break;
//     case 2: Console.WriteLine("Thứ Ba"); break;
//     case 3: Console.WriteLine("Thứ Tư"); break;
//     case 4: Console.WriteLine("Thứ Năm"); break;
//     case 5: Console.WriteLine("Thứ Sáu"); break;
//     case 6: Console.WriteLine("Thứ Bảy"); break;
//     case 7: Console.WriteLine("Chủ Nhật"); break;
//     default:
//         Console.WriteLine("Ngày không hợp lệ");
//         break;
// }
// // END SWITCH

// // LOOP
// //for
// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine($"Lần thứ {i}");
// }
// // end for

// // while
// int j = 1;
// while (j <= 5)
// {
//     Console.WriteLine($"j = {j}");
//     j++;
// }
// // end while

// // do - while
// int number;
// do
// {
//     Console.Write("Nhập số > 0: ");
//     number = Convert.ToInt32(Console.ReadLine());
// } while (number <= 0);
// // end do - while

// // foreach
// string[] names = { "Lan", "Minh", "Tú" };
// foreach (string n in names)
// {
//     Console.WriteLine($"Xin chào {n}");
// }
// // end foreach
// // END LOOP

// Q1
// Console.Write("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if (n % 2 == 0)
// {
//     Console.WriteLine("Even");
// }
// else
// {
//     Console.WriteLine("Odd");
// }
// END Q1

// Q2
// Console.Write("Input n: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= N; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Tổng từ 1 đến {N} = {sum}");
// //s2
// // ((last num + first num) * addend )/2
// Console.WriteLine($"Tổng từ 1 đến {N} = " + ((N + 1) * N) / 2);
// END Q2

// Q3
// Console.Write("Input n: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 2; i <= N; i++)
// {
//     bool isPrime = true;
//     for (int j = 2; j <= Math.Sqrt(i); j++)
//     {
//         if (i % j == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
//     if (isPrime)
//         Console.WriteLine(i);
// }
// END Q3

// Q4
// for (int i = 2; i <= 9; i++)
// {
//     Console.WriteLine($"\nBảng nhân {i}:");
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
// }
// END Q4

// Q5
// Random rand = new();
// int secret = rand.Next(1, 101);
// int guess;
// do
// {
//     Console.Write("Đoán số (1-100): ");
//     guess = Convert.ToInt32(Console.ReadLine());
//     if (guess > secret)
//     {
//         Console.WriteLine("Nhỏ hơn đi");
//     }
//     else if (guess < secret)
//     {
//         Console.WriteLine("Lớn hơn đi");
//     }
//     else
//     {
//         Console.WriteLine("Chính xác!");
//     }
// } while (guess != secret);
//END Q5

