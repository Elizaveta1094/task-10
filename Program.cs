//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите трехзначное число: " );
int number = Convert.ToInt32(Console.ReadLine());

if (number>999 || number<99)
{
    Console.WriteLine("Введите трехзначное число");
}
else
{
    int digital1 = number/10;
    int num = digital1%10;
    Console.WriteLine(num);
}