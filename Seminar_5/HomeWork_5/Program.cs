/*
int[] GetArray(int size, int minValue, int maxValue)

{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}
int[] array = GetArray(4, 100, 999);

int Even(int[] arr)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
count += 1;
}
return count;
}
Console.WriteLine($"Массив: [ {String.Join("; ", array)}]");
Console.WriteLine($"Количество четных чисел: {Even(array)}");
*/
/*
int[] GetArray(int size, int minValue, int maxValue)

{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}
int[] array = GetArray(4, -100, 100);

int Summ(int[] arr)
{
int sumOdd = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 != 0)
sumOdd += array[i];
}
return sumOdd;
}
Console.WriteLine($"Массив: [ {String.Join("; ", array)}]");
Console.WriteLine($"Summ of odd numbers is: {Summ(array)}");
*/


/*
int size = 8;
double[] array = new double[size];
double max = 0;
double min = 100;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round((new Random().NextDouble() * new Random().Next(10, 101)), 2);
}
for (int j = 0; j < array.Length; j++)
{

    if (array[j] > max)
        max = array[j];
    if (array[j] < min)
        min = array[j];

}

double diff = Math.Round((max - min), 2);
Console.WriteLine($"Массив вещественных чисел: [ {String.Join("; ", array)}],");
Console.WriteLine($"Разница: {max},- {min}, = {diff}");
*/