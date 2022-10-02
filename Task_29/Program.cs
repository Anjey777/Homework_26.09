/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split())
*/


Console.Write("Введите число : ");
string mas = Console.ReadLine();
string [] mass = new string [8]; mas.Split(",");
for(int i=0;i<mass.Length;i++);

 Console.WriteLine("[{mas}]"+ mas);