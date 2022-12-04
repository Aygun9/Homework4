//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int FindAPowB(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.WriteLine("insert number A : ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("insert number B : ");
int numberB = int.Parse(Console.ReadLine());
int result = FindAPowB( numberA, numberB);
Console.WriteLine(result);
