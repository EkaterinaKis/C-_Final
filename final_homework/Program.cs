
string[] array = new string[5];
string[] secondarray = new string[array.Length];
int i = 0;
for (i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент " + (i + 1) + ": ");
    array[i] = Console.ReadLine()!;
}
Console.WriteLine();
Console.WriteLine("Массив из элементов, которые меньше, либо равны 3 символам: ");
Console.WriteLine();
newarray(array, secondarray);
PrintArray(secondarray);


void newarray(string[] array, string[] secondarray)
{
    int count = 0;
    for (int y = 0; y < array.Length; y++)
    {
        if (array[y].Length <= 3)
        {
            secondarray[count] = array[y];
            count++;
        }
    }
    if (count == 0)
    {
        Console.WriteLine("Такие элементы отсутствуют в данном массиве");
    }
}


void PrintArray(string[] array)
{
    for (int z = 0; z < array.Length; z++)
    {
        Console.Write($"{array[z]} ");
    }
    Console.WriteLine();
}

