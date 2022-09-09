// 16. Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
// 5, 25  → да
// -4, 16  →  да
// 25, 5  →  да
// 8, 9  →  нет

Console.WriteLine("Введите два числа");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);

if (number1 > number2)
{
    if (number1 == number2 * number2)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    if (number2 == number1 * number1)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
