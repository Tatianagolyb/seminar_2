//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine()!);
int a1= num%10;
int a2=num%100;
int result=(a2-a1)/10;
Console.WriteLine($"Вторая цифра числа {num} -> {result}");



