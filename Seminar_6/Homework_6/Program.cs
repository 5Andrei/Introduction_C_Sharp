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