
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


// ДЗ по четвертой лекции.

// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Clear();

// Console.Write("enter number:");
// int A = int.Parse(Console.ReadLine());
// Console.Write("enter number:");
// int B = int.Parse(Console.ReadLine());

// Console.WriteLine($"{A} extent {B} = {Pow(A,B)}");

// int Pow(int num, int rank)
// {
//     if(rank==0) return 1;
//     int result = num;
//     for (int i = 2; i <= rank; i++)
//     {
//         result *= num; 
//     }
//     return result;
// }


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// void sumDigits(int number);
// {
//     Console.WriteLine($"sum сумма всех чисел {number} = ");
//     int sum = 0;
//     while(number > 0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     Console.WriteLine($"{sum}");
// }
// sumDigits(numbers);



// ДЗ по пятой лекции.

// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Наш массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Console.Clear();
// Console.WriteLine($" Сумма элементов, стоящих на нечётных позициях:");
// Console.Write($" Введи количество элементов массива:");
// int numberElements = Convert.ToInt32(Console.ReadLine()); 

// int RandomNumbers(int numberElements, int min, int max)
//   {
//   int[] randomNumbers = new int[numberElements];
//   int sumElements = 0;
//   Console.Write("массив: ");

//     for (int i = 0; i <randomNumbers.Length; i++ ){
//       randomNumbers[i] = new Random().Next(min, max);

//       Console.Write(randomNumbers[i] + " ");

//       if (i % 2 != 1)
//       {
//         sumElements = sumElements + randomNumbers[i];
//       }
//     }
//   return sumElements;
//   }

// int randomNumbers =  RandomNumbers(numberElements, 1, 10);

// Console.WriteLine($" Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Console.WriteLine($" Задайте массив вещественных чисел:");

// double[] arrayRealNumbers = new double[10];
//   for (int i = 0; i < arrayRealNumbers.Length; i++ )
//   {
//     arrayRealNumbers[i] = new Random().Next(1, 10);
//     Console.Write(arrayRealNumbers[i] + " ");
//   }

// double maxNumber = arrayRealNumbers[0];
// double minNumber = arrayRealNumbers[0];

//   for (int i = 1; i < arrayRealNumbers.Length; i++)
//   {
//     if (maxNumber < arrayRealNumbers[i])
//     {
//       maxNumber = arrayRealNumbers[i];
//     }
//         if (minNumber > arrayRealNumbers[i])
//     {
//       minNumber = arrayRealNumbers[i];
//     }
//   }

//   double decision = maxNumber - minNumber;

//   Console.WriteLine($"({maxNumber}) ({minNumber}) {decision}");


// ДЗ по шестой лекции.


// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Clear();
// Console.Write("ввести числа через пробел: ");
// Console.WriteLine($"Количество чисел больше ноля 0 -> {GetCountPositiveElements(numbers)}");
// Console.WriteLine();

// int[] GetArrayFromString(string stringArray)
// {
// string[] numS = stringArray.Split('', StringSplitOptions.RemoveEmptyEntries);
// int[] result = new int[numS.Length];
// for (int i = 0; i < result.Length; i++)
// {
//     result[i] = int.Parse(numS[i]);
// }
// return result;
// }

// int GetCountPositiveElements(int[] array)
// {
//     int count = 0;
//     foreach (var item in array)
//     {
//         if(item>0) count++;
//     }
//     return count;
// }


// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.Clear();
// Console.Write("Введите k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());
 
 
// var x = -(b1 - b2) / (k1 - k2);
// var y = k1 * x + b1;
 
// x = Math.Round(x, 3);
// y = Math.Round(y, 3);
 
// Console.WriteLine($"Пересечение в точке: ({x};{y})");
