/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите положительное число:");
int number = int.Parse(Console.ReadLine());

int sum = 0;


while ( number > 0)
{
    int deg = number % 10;
    sum += deg;
    number = number / 10;
}

Console.Write(sum);

