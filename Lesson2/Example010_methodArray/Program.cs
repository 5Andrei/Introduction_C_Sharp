int[] array = { 1, 2, 55, 44, 66, 8787, 444, 56, };

int n = array.Length;
int find = 66;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);          
    }
    index++;

}