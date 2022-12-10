// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату X точки A");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки A");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки A");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X точки B");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки B");
int y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки B");
int z2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)));

// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите пятизначное число:");
string array = Console.ReadLine()!;

int i = 0;

if  (array[0] == '-' ) i = 1;

if (array[i] == array[4+ i ] && array[1 +i]== array[3 +i])
{
    Console.WriteLine("Число является полиндроном");
}
else
{
    Console.WriteLine("Число неявляется полиндроном");
}
*/

// 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.WriteLine("Введите число, ввод знака '-' не учитывается");
int N = Math.Abs(int.Parse(Console.ReadLine()!));

for (int i = 1 ; i <= N ; i ++)
{
    Console.WriteLine(Math.Pow(i,3));
} 
*/