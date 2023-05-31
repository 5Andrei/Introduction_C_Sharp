/*Random rnd = new Random();
int rndNum = rnd.Next(10, 100); // 10- 99

int a = rndNum % 10;
int b = rndNum / 10;
if (a > b)
{
    Console.WriteLine(a);
}
else
{ 
    Console.WriteLine(b);
}



void GenNumbers(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(10, 100);
    }
}
int[] arr = new int[10];
GenNumbers(arr);
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
    int a = arr[i] % 10;
    int b = arr[i] / 10;
    if (a > b)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(b);
    }
}
*/

/*
Random rnd = new Random();
int rndNum = rnd.Next(100, 1000);
Console.WriteLine(rndNum);
int a = rndNum / 100;
int c = rndNum % 10;
int result = 10 * a + c;
Console.Write(result);
*/


Random rnd = new Random();
int rndNum = rnd.Next(1, 10);
Console.WriteLine(rndNum);
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (b % a == 0)
{
    Console.WriteLine("Multiple");
}
else
{
    Console.WriteLine(b % a);
}

