/*
Console.Write("enter a three-digit number: ");
int Tdn = int.Parse(Console.ReadLine());
int thirdDigit = Tdn / 10 % 10;
Console.Write(thirdDigit);
*/
/*
int number = ReadInt("Enter digits: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("No third digit : ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}
*/











/*
Console.Write("enter a digit number from 1 to 7: ");
int DayNum = int.Parse(Console.ReadLine());
if (DayNum == 6 || DayNum == 7)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}
*/