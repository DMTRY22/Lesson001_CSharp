
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Clear();
// Console.WriteLine("введите два числа:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 > number2)
// {
//     Console.WriteLine("10 больше 20");
// }
// else if (number1 < number2)
// {
//     Console.WriteLine("20 больше 10");
// }
// else
// {
//     Console.WriteLine("10 равно 20");
// }


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.Clear();
// Console.WriteLine("введите три числа:");
// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// int number3 = Convert.ToInt32(Console.ReadLine());

// int max = number1;
// if (max < number2);
// max = number2;
// if (max < number3);
// max = number3;

// Console.WriteLine($"максимальное число = {max}");


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Clear();
// Console.WriteLine("введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number%2 == 0)
// {
//     Console.WriteLine("четное число:");
// }
// else
// {
//     Console.WriteLine("нечетное число:");
// }


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


// Console.Clear();
// Console.WriteLine("Введите число N:");
// int N = Convert.ToInt32(Console.ReadLine());

// int i = 1;
// while (i <= N)

// if  (i % 2 == 0)

// Console.Write($"{i}");
// i++;

// Console.WriteLine();


// ДЗ по второй лекции

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Clear();
// int num = new Random().Next(100, 1000);
// int secondNumber = num / 10 % 10;
// Console.WriteLine($"Вторая цифра в числе {num} -> {secondNumber}");

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// if (num < 100)
// {
//     Console.WriteLine($"Третьей цифры нет");
// return;
// }
// int thirdNumber = num % 10;
// Console.WriteLine($"Третья цифра числа {num} -> {thirdNumber}");

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// if (num > 7 || num < 1)
// {
//     Console.WriteLine("неверный день недели");
// }
// if (num > 5)
// {
//     Console.WriteLine("да");
// }
// else
// {
//     Console.WriteLine("нет");
// }

// ДЗ по третьей лекции

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void palindrome(double a)
// {
//     if (a < 0)
//     {
//         a = Math.Abs(a);
//     }
//     if (a % 1 > 0)
//     {
//     Console.WriteLine("insert not integer");
//     }
//     else if (a < 10000 || a > 99999)
//         {
//     Console.WriteLine("enter not five digit number");
//         }
//     else if (Math.Floor(a / 1000) == a % 10 * 10 + Math.Floor(a % 100 / 10))
//         {
//     Console.WriteLine("yes");
//         }
//     else
//         {
//     Console.WriteLine("no");
//         }
//     }

// Console.Write("enter five digit number:");
// double number = Convert.ToDouble(Console.ReadLine());
// palindrome(number);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// void distance(double a, double b, double c, double d, double e, double f);
// {
//     Console.WriteLine($"расстояние между точками равно {Math.Round(Math.Sqrt(Math.Pow(a - d, 2) + Math.Pow(b - e, 2) + Math.Pow(c - f, 2)), 2)}");

// }
// Console.WriteLine("введите координаты двух точек в 3D");

// Console.WriteLine("x первой точки");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("y первой точки");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("z первой точки");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("x первой точки");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("y первой точки");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("z первой точки");
// double xb = Convert.ToDouble(Console.ReadLine());

// distance(xa, ya, za, xb, yb, zb);
