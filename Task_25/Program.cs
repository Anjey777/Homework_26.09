/*
Задача 25. 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
*/

Console.Write("Введите число   : ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите степень : ");
int degree = int.Parse(Console.ReadLine());
int num_degree = 1;
for (int i = 0; i < degree; i++)
{
    num_degree *= num;
}
Console.WriteLine("{0} ^ {1} = {2}", num, degree, num_degree);
//Console.WriteLine($"Ваше число возведенное в степень:  " +  num_degree);
Console.ReadLine();
return 0;