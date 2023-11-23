// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

int Ackermanns_function(int M, int N)
{
  if (M == 0) return N + 1;
  else if (M > 0 && N == 0) return Ackermanns_function(M - 1, 1);
  else return Ackermanns_function(M - 1, Ackermanns_function(M, N - 1));
}

int m = ReadInt("Введите первое положительное число:");
int n = ReadInt("Введите второе положительное число:");

Console.Write(Ackermanns_function(m, n));