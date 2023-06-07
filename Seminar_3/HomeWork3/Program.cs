/*
Console.Write("Please enter digits for cheking:");

string? number = Console.ReadLine();
var fiveDigits = number;

int checkingDigits;

bool digits = int.TryParse(fiveDigits, out checkingDigits);

if (digits)
{
    Console.WriteLine("Checking number for the correct format, please wait...");
}
else
{
    Console.WriteLine("You entered an incorrect number, please try again");

}
int digitsfive = Convert.ToInt32(fiveDigits);
if (digitsfive >= 10000 && digitsfive < 100000)
{
    Console.WriteLine("Value of digit meets verification requirements, please wait...");
}
else
{
    Console.WriteLine("You entered an incorrect number, you must put only five digits, please try again");
}
int firstDi = digitsfive / 10000;
int secDi = digitsfive / 1000 % 10;
int fourthDigit = digitsfive / 10 % 10;
int fifthDigit = digitsfive % 10;
if (firstDi == fifthDigit && secDi == fourthDigit)
{
    Console.WriteLine("Congrad! This number is a palindrome!");
}
else 
{
    Console.WriteLine("Sorry this number isn't a palindrome");
}
*/


/*
Console.Write("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"Расстояние между точками 3d Пространстве А:({x1},{y1},{z1}) и В:({x2},{y2},{z2})  равно: {Math.Round(d, 2)}");
*/



/*
 Console.Write("Введите число N: ");
 int N = Convert.ToInt32(Console.ReadLine());

 for (int i = 1; i <= N; i++)
 {
     Console.Write(Math.Pow(i, 3) + "\t");     
 }
 */
