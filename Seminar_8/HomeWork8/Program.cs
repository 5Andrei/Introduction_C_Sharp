///Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
///по убыванию элементы каждой строки двумерного массива.

/*
Console.Write("Enter quantiy of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantiy of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = GetMatrix(rows, columns, 0, 10);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
SortToLower(matrix);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}

void SortToLower(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}
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
Console.WriteLine($"Row with minimal sum of elements is: {FinderOfRowWhithMinSum(matrix)}");
int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}
int FinderOfRowWhithMinSum(int[,] matrix)
{
    int rowWithMinSum = 0;
    int minSum = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minSum = minSum + matrix[0, i];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            rowWithMinSum = i;
        }
    }
    return rowWithMinSum + 1;
}
*/
/*
Console.Write("Enter quantiy of rows: ");
int rowsOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantiy of columns: ");
int columnsOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] matrixOne = GetMatrix(rowsOne, columnsOne, 1, 10);
PrintMatrix(matrixOne);

Console.Write("Enter quantiy of rows: ");
int rowsTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter quantiy of columns: ");
int columnsTwo = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,] matrixTwo = GetMatrix(rowsTwo, columnsTwo, 1, 10);
PrintMatrix(matrixTwo);

Console.WriteLine($"Result of the product of two matrices: ");
PrintMatrix(GetProductMatrix(matrixOne,matrixTwo));



int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + "\t");
        Console.WriteLine();
    }
}
int[,] GetProductMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] resMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                resMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
                
            }
        }
    }
    return resMatrix;
}
*/ 
﻿/*
Console.WriteLine($"Enter size of array X x Y x Z: ");
int x = InputNumbers("Enter X: ");
int y = InputNumbers("Enter Y: ");
int z = InputNumbers("Enter Z: ");
Console.WriteLine($"");

int[,,] matrix3D = new int[x, y, z];
CreateArray(matrix3D);
WriteArray(matrix3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] matrix3D)
{
  for (int i = 0; i < matrix3D.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {      
      for (int k = 0; k < matrix3D.GetLength(2); k++)
      {
        Console.Write( $"{matrix3D[i,j,k]}({i},{j},{k}); ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] matrix3D)
{
  int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matrix3D.GetLength(0); x++)
  {
    for (int y = 0; y < matrix3D.GetLength(1); y++)
    {
      for (int z = 0; z < matrix3D.GetLength(2); z++)
      {
        matrix3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
*/
/*
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/
