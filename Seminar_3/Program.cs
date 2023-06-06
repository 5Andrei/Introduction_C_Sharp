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


/*Задача 21: Напишите программу, которая принимает 
 на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
 A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,2

B = √(x2 - x1)2 + (y2 - y1)2
4 координаты : A(x1,y1); B(x2,y2)//
*/
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
/*Console.WriteLine(Math.Round(1.234, 2));
Console.WriteLine(Math.Round(1.256, 2));
*/