// 16. Напишите программу, которая принимает на вход 
// два числа и проверяет, является ли одно число 
// квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет


Console.WriteLine("Введите первое число: ");
int number = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine() ?? "");
int a = number * number;
int b = number2 * number2;

if (number == b)
    Console.WriteLine("Первое число является квадратом второго");
else if (number2 == a)
    Console.WriteLine("Второе число является квадратом первого");
else
{
    int a2 = number % number2;
    Console.WriteLine($"Ни одно число не является квадратом другого");
}

