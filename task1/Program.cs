/* 
Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B. Сделать в функции, сделать проверку на отрицательность.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.Write("Введите положительное число:");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите положительную степень, в которую хотите возвести число:");
int number2 = int.Parse(Console.ReadLine());
int result = 1;

if (number1 < 0 && number2 < 0)
{
    Console.Write("Ошибка! Введите положительные числа!");
}

else if ( number2 == 0)
{
    Console.Write("1");
}

else
{
    for (int i = 1; i <= number2; i++)
    {
        result *= number1;
        //Console.Write(i);
        //Console.Write(result);
    }
    Console.Write(result);
}
