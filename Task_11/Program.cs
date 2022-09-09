// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 → 46

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int digit1 = number/100;
int digit3 = number%10;

Console.Write(digit1);
Console.Write(digit3);