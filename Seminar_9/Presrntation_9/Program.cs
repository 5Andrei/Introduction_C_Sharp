/*
int Factorial(int value)
{
// Базовый случай - случай выхода из рекурсии, бесконечный вызов
if (value == 1) return 1;
// Рекурсивный случай - задание рекурсии
return value * Factorial(value - 1);
}
int N = 4;
Console.WriteLine($"Факториал от числа {N} = {Factorial(N)}");
*/

// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

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
    // Базовый случай - выход
    if (start == end) return start.ToString(); // Вернул последнее число N в формате строчки

    // Рекурсивный случай
    return start + ", " + GetStringOfNumbers(start + 1, end);
}
Console.WriteLine($" '{GetStringOfNumbers(1, N)}' "); // start = 1, end = N


/*
// Задача 67: Напишите программу,
// которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Write("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());

int GetDigitsSum(int number)
{
if (number == 0) return 0;

return number % 10 + GetDigitsSum(number / 10);
}


Console.WriteLine($"Сумма цифр в числе: {N} = {GetDigitsSum(N)}" );
*/