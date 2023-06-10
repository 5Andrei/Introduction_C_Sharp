
/*
Console.Write("Enter digit A:");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter digit B:");
int secondNum = Convert.ToInt32(Console.ReadLine());

int result = 1;
for(int i = 1; i <= secondNum; i++)
{
result *= firstNum;
}
Console.WriteLine($"Digit {firstNum} in power {secondNum} will be exactly {result}");
*/


/*
int digits = Request("Please enter didits: ");
int Request(string question)
{
    Console.Write(question);
    string? input = Console.ReadLine();
    int sumDigits = Convert.ToInt32(input);
    return sumDigits;
}
int DigitSum(int digits)
{
    int sumDigits = 0;
    while (digits > 0)
    {
        sumDigits += digits % 10;
        digits = digits /10;
    }
    return sumDigits;
}
Console.WriteLine($"Summ of Digits of {digits} is: {DigitSum(digits)}");
*/
int size = 8;
int[] massiv = new int[size];
Random random = new Random();
for (int i = 0; i < size; i++)
{    
    massiv[i] = random.Next(1, 20);
}
Console.WriteLine($"Массив: [ {String.Join(";  ", massiv)} ]");
