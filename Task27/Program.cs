// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int DataEntry(string str)
{
    Console.WriteLine(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int Sum(int number)
{
    int sum = 0;
    int result1 = 0;
    for (int i = number; i > 0; i++)
    {
        result1 = number - number % 10;
        sum = sum + (number - result1);
        number = number / 10;
    }
    return sum;
}
int number = DataEntry("Insert number : ");
int result = Sum(number);
Console.WriteLine(result);