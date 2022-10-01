/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*int degree (int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int degree = degree(numberA, numberB);
Console.WriteLine("Ответ: " + degree);
*/


Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int degree(int umberA, int numberB)
{
   if (numberB==0) return 1;
   if (numberA==1) return numberB;
   return degree(numberA, numberB/2)*degree(numberB, numberA - numberA/2);
}
Console.WriteLine($"Расстояние между точками: {degree}");