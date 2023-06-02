Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1,
    xb = 1, yb = 20,
    xc = 80, yc = 20;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("=");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("=");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("=");

int z = xa, t = xb;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        z = (z + xa) / 2;
        t = (t + ya) / 2;
    }
    if (what == 1)
    {
        z = (z + xb) / 2;
        t = (t + yb) / 2;
    }
    if (what == 2)
    {
        z = (z + xc) / 2;
        t = (t + yc) / 2;        
    }
    Console.SetCursorPosition(z, t);
    Console.WriteLine("=");
    count++;
}
