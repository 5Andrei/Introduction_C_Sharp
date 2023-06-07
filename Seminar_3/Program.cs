/*var stringNumber = "0003"; // var - ключевое слово, определяет тип данных
int number; // Если строчка состоит только из чисел,
// то в переменную попадает наше число
// TryParse (строчка, out переменная) -- out переменная - сохраняем число

bool isNumber = int.TryParse(stringNumber, out number);
// isNumber = true, то строка состоит только из чисел ("2")
// false - присутствуют в строке еще и символы, number = 0
if (isNumber && stringNumber.Length >= 3) // isNumber == true
{
Console.WriteLine("Перевод произошел успешно, в строчке есть ТОЛЬКО цифры");
Console.WriteLine(number);
Console.WriteLine("Третья цифра числа: " + stringNumber[2]);
}
else // isNumber == false
{
Console.WriteLine("Ошибка! В строчке присутсвуют и другие символы");
Console.WriteLine(number);
}
*/
/*
Console.Write("Введите координату по оси oХ: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси oY: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("I четверть");
}

else if (x < 0 && y > 0)
{
    Console.WriteLine("II четверть");
}

else if (x < 0 && y < 0)
{
    Console.WriteLine("III четверть");
}

else if (x > 0 && y < 0)
{
    Console.WriteLine("IV четверть");
}
*/

/*Задача 21: Напишите программу, которая принимает 
 на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
 A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,2

B = √(x2 - x1)2 + (y2 - y1)2
4 координаты : A(x1,y1); B(x2,y2)//
*/

/*
Console.Write("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
// A (3,6); B (2,1) -> 5,09 
Console.Write("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
// Math.Sqrt(число) => Math.Sqrt(25) = 5
//(x2 - x1) * (x2 - x1) => Math.Pow(x2 - x1, 2) => Math.Pow(число, степень)
// Math.Pow(5, 3) => 5*5*5  = 125
double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
// Math.Round(число, кол-во знаков)
// Math.Round(1.234, 2) 
Console.WriteLine($"Расстояние между точками А:({x1},{y1}) и В:({x2},{y2})  равно: {Math.Round(d, 2)}"); 
// Интерполяция
Console.WriteLine(Math.Round(1.234, 2));
Console.WriteLine(Math.Round(1.256, 2));
*/



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

