// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число:");
// int x = Convert.ToInt32(Console.ReadLine());
// int a1 = x / 10000;
// int b1 = x % 10; 
// int a2 = x / 1000 % 10;
// int b2 = x /10 % 10;

// if (a1 == b1 && a2 == b2)
// {
//     Console.Write(x +" -> " + "Число является палиндромом" );
// }
// else
// {
//     Console.Write(x +" -> " + "Число не является палиндромом" );

// }

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число:");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Таблица кубов от 1 до числа " + num + ":");
// for (int i = 1; i <= num; i++)
// {
//     Console.WriteLine(i + " ^ 3" + " = " + i * i * i);
// }


//  Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A(3,6,8); B(2,1,-7), -> 15.84
// A(7,-5, 0); B(1,-1,9) -> 11.53

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         double CoordSystem3D(int x1, int y1, int z1, int x2, int y2, int z2)
//         {
//             return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
//         }

//         Console.Write("Введите координату x1:");
//         int x1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите координату y1:");
//         int y1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите координату z1:");
//         int z1 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите координату x2:");
//         int x2 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите координату y2:");
//         int y2 = Convert.ToInt32(Console.ReadLine());
//         Console.Write("Введите координату z2:");
//         int z2 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Расстояние между точками: " + CoordSystem3D(x1, y1, z1, x2, y2, z2));
//     }
// }