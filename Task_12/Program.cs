// 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.
// 34, 5 → не кратно, остаток 4 
// 16, 4 → кратно

Console.WriteLine("Введите два числа");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
Console.WriteLine(number1);
Console.WriteLine(number2);

int result = number1 % number2;
if (result == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно, остаток {result}");
}
