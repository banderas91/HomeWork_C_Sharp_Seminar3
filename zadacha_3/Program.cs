﻿//Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.


Console.Write("Введите число   ");
int N =Convert.ToInt32(Console.ReadLine());

int[] array = new int [N];

int index = 0;
int num = 1;
while(index < N)
{
    
    Console.WriteLine((Math.Pow(num, 3)));
    num++;
    index++;
}