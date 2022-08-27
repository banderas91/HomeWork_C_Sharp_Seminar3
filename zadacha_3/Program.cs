//Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. Полученный массив вывести на экран.


Console.Write("ведите число   ");
int N =Convert.ToInt32(Console.ReadLine());
if (N == 0)
{
    Console.WriteLine("Введите число отличное от 0");
}

int[] array = new int [N];

 int index = 0;
 int num = 1;

 while(index < N)
 {
    Console.Write("Куб числа "+num+"----> " );
    array[index] = Convert.ToInt32(Math.Pow(num, 3));
    Console.WriteLine(array[index]);
    num++;
    index++;
}