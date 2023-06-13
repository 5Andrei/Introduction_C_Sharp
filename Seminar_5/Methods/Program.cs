/*Готовить_кофе(жидкость,кофе, typeof_ beverage)
{
    кофе = измельчить_зерна();

    кофе = .... ;

    return кофе;
}
Готовить кофе(200 воды, 50 грамм кофе, раф с кокосом)

Готовить кофе(200 воды, 20 грамм кофе, американо)

Готовить кофе(200 воды, 30 грамм кофе, латте)
*/

// void - будет дальше (после двумерных массивов)

// тип_возр_значения ИмяМетода (параметы)
// PascalCase
// calculate - переменная, Calculate - имя метода
/*int Calculate(int a, int b, char sign)
// a - число 1, b - число; char - 1 символ - '+'
{
    int result = 0;
    if (sign == '+')
    {
        result = a + b;
    }
    else if (sign == '-')
    {
        result = a - b;
    }
    else
    {
        Console.WriteLine("Такого знака еще нет :(");
    }
    return result;
}
// Вызов метода
Console.WriteLine(Calculate(100,25,'-')); // 100 - 25 
Console.WriteLine(Calculate(100,400,'+')); // 100 + 400 
Console.WriteLine(Calculate(100,400,'*')); // 100 * 400  -> 0
*/
/*
int[] GetArray(int size, int minValue, int maxValue)
// size = 12, minValue = -9, maxValue = 9
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++) // i < resultArray.Length = i < size
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] array = GetArray(12, -9, 9);
// Интерполяция ($)
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

int positiveSum = 0; // +
int negativeSum = 0; // -

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        positiveSum += array[i]; // positiveSum = positiveSum + array[i]
    }
    else // <=0
    {
        negativeSum += array[i]; // negativeSum = negativeSum + array[i] 
    }
}
Console.WriteLine($"Сумма пол: {positiveSum}, отрц.: {negativeSum}");
*/

/*
//Тернарный Оператор
int[] GetArray(int size, int minValue, int maxValue)
// size = 12, minValue = -9, maxValue = 9
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++) // i < resultArray.Length = i < size
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] array = GetArray(12, -9, 9);
// Интерполяция ($)
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

int positiveSum = 0; // +
int negativeSum = 0; // -

for (int i = 0; i < array.Length; i++)
{
    // Тернарный оператор
    // условие ? значение_ист : значение_ложное
    positiveSum += array[i] > 0 ? array[i] : 0; // Если число поло-е, то прибавляю array[i] 
    // иначе - прибавляю 0
    negativeSum += array[i] < 0 ? array[i] : 0;
}
Console.WriteLine($"Сумма пол: {positiveSum}, отрц.: {negativeSum}");
*/
/*
int[] GetArray(int size, int minValue, int maxValue)
// size = 12, minValue = -9, maxValue = 9
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++) // i < resultArray.Length = i < size
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}
int[] ReverseArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= (-1); //  arr[i] =  arr[i] * (-1)
    }
    return arr;
}

int[] array = GetArray(12, -9, 9);
// Интерполяция ($)
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");
Console.WriteLine($"Перевернутый массив: [ {String.Join("; ", ReverseArray(array))} ]");
*/
/*
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

bool FindElement(int[] arr, int number)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
        {
            return true; // true - элемент найден
        }
    }
    return false;// false - элемент НЕ найден
}

int numberForSearch = new Random().Next(11); // [0-10]
Console.WriteLine($"Рандомное число для поиска: {numberForSearch}");
if (FindElement(array, numberForSearch)) // FindElement(array,numberForSearch) == true
{
    Console.WriteLine($"Число {numberForSearch} в массиве присутствует");
}
else // FindElement(array,numberForSearch) == false
{
    // $"Текст {переменная} текчст {переменная}"
    Console.WriteLine($"Число {numberForSearch} в массиве ОТСУТСТВУЕТ");
}
*/

