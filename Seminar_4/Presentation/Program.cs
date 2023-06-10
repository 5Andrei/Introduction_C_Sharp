//Задача 24: Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// A = 4: 1+2+3+4 = 3 + 3 + 4 = 6 + 4 = 10
/*
Console.Write("Введите число А: ");

int limit = Convert.ToInt32(Console.ReadLine());

int sum = 0; // Изначально суммы нет
// for (точка входа; условие цикла; увел.счетчика)
for (int i = 1; i <= limit; i++)
{
sum += i; // sum = sum + i
}

Console.WriteLine($"Сумма чисел от 1 до {limit} = {sum}");
*/

/*Console.Write("Введите число А: ");
//string? inp = Console.ReadLine();
//Console.WriteLine($"Pieces digits in number is: {inp.Length}");

bool isNumber = int.TryParse(Console.ReadLine(), out int result);
if (isNumber) 
{
    int count = 1;
    while (result > 10)
    {
        result /= 10;
        count += 1;
    }
    Console.WriteLine($"Pieces digits in number is {count}");
}
else
{
    Console.WriteLine("Sorry you entered an incorrect number");
}
*/
/*
int size = 8;
int[] massiv = new int[size]; // Массив из 8 элементов: в массиве изначально 8 нулей
Random random = new Random();
for (int i = 0; i < size; i++)
{
    // array[i] = new Random().Next(0, 2)
    massiv[i] = random.Next(1, 20);
    // Console.Write(array[i] + " ");
}

Console.WriteLine($"Массив: [ {String.Join(";  ", massiv)} ]");
*/