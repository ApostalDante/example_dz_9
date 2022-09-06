/*Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

/* - решение - */

Console.Clear();

Console.Write("Введите M: ");
int numM = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите N: ");
int numN = int.Parse(Console.ReadLine() ?? "");

void PrintNumber(int m, int n)
{
    if (n < m) return;
    Console.Write(m + " ");
    PrintNumber(m + 1, n);
}
Console.WriteLine("Натуральные числа в промежутке от M до N:");
PrintNumber(numM, numN);

Console.WriteLine();

/*--------------------------------------------------------------------------------------*/

/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/* - решение - */

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine() ?? "");

int summ = 0;

PrintSumm(m, n, summ);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.WriteLine($"Сумма элементов = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

Console.WriteLine();

/*--------------------------------------------------------------------------------------*/

/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/


Console.Write("Введите M: ");
int akkerM = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите N: ");
int akkerN = int.Parse(Console.ReadLine() ?? "");

int functionAkkerman = Ack(akkerM, akkerN);

Console.WriteLine($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}



