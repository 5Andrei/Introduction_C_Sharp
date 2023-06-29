/*
int lengthOfArray = Requesting("Please enter quantity of elements > ");
int[] massiv;
massiv= ArraysCompletion(lengthOfArray);
PrintingOfMassive(massiv);
Console.WriteLine($"Quantity of digits greater than zero is: {CountingOfPositiveDigits(massiv)}");




int Requesting(string digits)
{
    Console.Write(digits);
    string? reading = Console.ReadLine();
    int resultOfreading = Convert.ToInt32(reading);
    return resultOfreading;
}
int[] ArraysCompletion(int lengthOfArray)
{
    int[] massiv = new int[lengthOfArray];
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = Requesting($"Please enter element № {i + 1} ");
    }
    return massiv;
}
void PrintingOfMassive(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"element[{i}]= {massiv[i]} \t");
    }
}
int CountingOfPositiveDigits(int[] massiv)
{
    int pieces = 0;
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i] > 0)
        {
            pieces++;
        }
    }   return pieces;
}
*/
/*
Console.WriteLine("Enter b1:");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k1:");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b2:");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k2:");
double k2 = Convert.ToInt32(Console.ReadLine());

double axisX = (b2 - b1) / (k1 - k2);
double axisY = k1 * axisX + b1;

Console.WriteLine($"Point of intersection of two straight lines = X: {axisX}, Y: {axisY}");
*/