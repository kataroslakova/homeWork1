﻿Console.WriteLine ("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());



int maximal = b;

if (a > maximal) maximal = a;
if (c > maximal) maximal = c;

Console.Write("Максимальное число: ");
Console.Write(maximal);


