//  Console.Write("Enter digit: ");

//  int digit = Convert.ToInt32(Console.ReadLine());
//  int square = digit * digit;

//  double squareSecOpt = Math.Pow(digit, 2);
//  Console.WriteLine("Число " + digit + " В квадрате " + squareSecOpt);
/*
Console.Write("Enter First digit: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Second digit: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit == secondDigit * secondDigit)
{
    Console.WriteLine("Число " + firstDigit + " Является  квадратом числа " + secondDigit);
}
else
{
    Console.WriteLine("Число " + firstDigit + " Не является  квадратом числа " + secondDigit);
}
*/
Console.Write("Enter N digit: ");
int N = Convert.ToInt32(Console.ReadLine());
int negative_N = N * (-1);

while (negative_N <= N)
{
    Console.WriteLine(negative_N);

    negative_N++;
}