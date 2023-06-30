
/*
Console.Write("Enter quantity rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter quantity columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrixOfRealNumbers = new double [rows, columns];
GetMatrix(matrixOfRealNumbers);
PrintMatrix(matrixOfRealNumbers);

void GetMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
*/

/*
int PositionIntroduction(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
int rowsPosition = PositionIntroduction("Enter position in rows: ");
int columnsPosition = PositionIntroduction("Enter position in columns: ");
int[,] matrix = GetMatrix(4, 4, 0, 10);
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
void ValidationOfPosition(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (rowsPosition == i && columnsPosition == j)
            {                
                Console.Write($"Digit in position is: {array[i, j]}");        
            }      
         }
    }
}
ValidationOfPosition(matrix);
OutOfMatrix (matrix);
void OutOfMatrix (int[,] array)
{
    if (rowsPosition < 0 || rowsPosition > 3 || columnsPosition < 0 || columnsPosition > 3)
    {
        Console.Write($"Out of range no position in this Matrix ((( ");
    }
}
*/

///Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
///элементов в каждом столбце.
/*
int[,] matrix = GetMatrix(3, 4, 0, 9);
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
PrintMatrix(matrix);
void SumOfColumns(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)//свапнули c 132 чтоб пройтись по солбцам
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)//свапнули c 129 чтоб пройтись по солбцам
        {
            sum = sum + array[j, i];
        }
        double arithmetic = Math.Round(sum / array.GetLength(0), 2);
        Console.WriteLine($"Arithmetic mean column N {i + 1} = {arithmetic}");
    }
}
Console.WriteLine();
SumOfColumns(matrix);
*/

/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
/*
Console.Write("Enter quantiy of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter quantiy of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = GetMatrix(rows, columns, 0, 10);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
SumOfDiagonal(matrix);
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // i,j,m,k 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "\t");
        Console.WriteLine();
    }
}
void SumOfDiagonal(int[,] array)
{
    int sumOfElements = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sumOfElements = sumOfElements + array[i, j];
            }
        }           
    }
    Console.Write($"Summ of elements in main diaginal is: {sumOfElements}");
}
*/