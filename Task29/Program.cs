//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int i;
    for (i = 0; i < count; i++)
    {
        Console.WriteLine(col[i] + " ");
    }
}

int numberA = DataEntry("Insert array Length");
int[] array = new int[8];
array = FillArray(array);
PrintArray(array);