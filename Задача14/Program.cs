// 14. Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");
int a = 7;
int b = 23;
int с = (number % a) + (number % b);

if (с == 0)
    Console.WriteLine("Число кратно 7 и 23");
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}