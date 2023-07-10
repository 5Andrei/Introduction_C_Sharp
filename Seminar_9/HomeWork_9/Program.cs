/*
Console.Write("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печать чисел от 1 до N
/// </summary>
/// <param name="start"> левая граница (1)</param>
/// <param name="end"> правая граница (N)</param>
/// <returns>строчку с числами от 1 до N</returns>
string GetStringOfNumbers(int start, int end)
{

    if (start == end) return start.ToString();


    return start + ", " + GetStringOfNumbers(start - 1, end);
}
Console.WriteLine($" '{GetStringOfNumbers(N, 1)}' ");
*/
/*
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
/// <summary>
/// Печать чисел от 1 до N
/// </summary>
/// <param name="start"> левая граница (1)</param>
/// <param name="end"> правая граница (N)</param>
/// <returns>строчку с числами от 1 до N</returns>
string GetStringOfNumbers(int start, int end, int sum)
{

    if (start > end)
    {
        Console.WriteLine($"Sum of real numbers from M to N: {sum}");
        return start.ToString(); 
    } 
    sum = sum +(start++);
    return GetStringOfNumbers(start, end, sum);
}
GetStringOfNumbers(M, N, 0);
*/
﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

/*
int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");

int functionAkkerman = FunctionOfAkkerman(m, n);

Console.Write($"Function of Akkerman is= {functionAkkerman} ");

int FunctionOfAkkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionOfAkkerman(m - 1, 1);
  else return FunctionOfAkkerman(m - 1, FunctionOfAkkerman(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
*/