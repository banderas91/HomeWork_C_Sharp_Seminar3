// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Число хранить в типе данных int, решать с помощью арифметических операций (не рассматривая число как тип данных string) a b c d e


int start = 10000;
int stop = 99999;

int value = new Random().Next(start, stop + 1);
int a = value / 10000;
int b = (value % 10000) / 1000;
int d = (value % 100) / 10;
int e = (value % 10);


if (a  == e && b == d )
{
     Console.WriteLine("Число "+ value+" палиндром!");
}
else
{
     Console.WriteLine("Число "+ value+" НЕ палиндром!");
}