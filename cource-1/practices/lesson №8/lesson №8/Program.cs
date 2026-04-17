using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

int[] grades = { 1, 3, 2, 4, 5 };
for (int i = 1; i < 6; i++)
{
    Console.WriteLine("Итерация № " + i);
}
int[] grades1 = { 5, 3, 1, 2, 4, 5 };
int sum = grades1.Sum();
int div = sum / 6;
int mod = sum % 6;
Console.WriteLine("Среднее арифметическое ряда =  " + div);
Console.WriteLine("Остаток = " + mod);
int[] grades2 = { 35, 13, 98, 92, 1, 64, 52, 67 };
int max = int.MinValue;
foreach (int a in grades2)
{
    if (a > max)
    {
        max = a;
    }
}
Console.WriteLine("Наибольшее число ряда: " + max);
string[] fruits = { "яблоко", "банан", "груша", "апельсин", "мандарин" };

foreach (string fruit in fruits)
{
    Console.WriteLine("Фрукт: " + fruit);
}
int[,] matrix = new int[3, 3];
int counter = 1;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = counter++;
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
{
string password;

do
{
    Console.Write("Введите пароль: ");
    password = Console.ReadLine();

    if (password != "1234")
    {
        Console.WriteLine("Неверный пароль! Попробуйте еще раз.");
    }

} while (password != "1234");

Console.WriteLine("Доступ разрешен!");
}