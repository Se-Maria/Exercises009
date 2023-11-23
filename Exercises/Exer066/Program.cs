// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int sumNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber < 0) firstNumber = 1;
    int sum = firstNumber;
    while (firstNumber < secondNumber)
    {
        sum = sum + (firstNumber + 1);
        firstNumber++;
    }
    return sum;
}

int F = ReadInt("Введите первое число:");
int S = ReadInt("Введите второе число:");

if (S < F) Console.Write("Второе число должно быть больше первого");
else if (F < 0 && S < 0) Console.Write("Второе число должно быть положительным");
else Console.Write(sumNumbers(F, S));