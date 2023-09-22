
// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.


int n = InputNumbers("Введите число: ");

PrintNumbers(n);


int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintNumbers(int n)
{
    if (n >= 1)
    {
        Console.Write(n);
        Console.WriteLine();
        n--;
        PrintNumbers(n);

    }
    else
    {
        return;
    }

}


//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в 
//промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int M = InputNumbers("Введите  число M: ");
int N = InputNumbers("Введите число N: ");
int temp = M;

if (M > N)
{
    M = N;
    N = temp;
}

PrintSumm(M, N, temp = 0);
Console.WriteLine();

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}


// Задача 68
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m (используется переменная K)= 2, n используется переменная j = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
int k = InputNumbers("Введите M: ");
int j = InputNumbers("Введите N: ");

int functionAkkerman = Ack(k, j);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ack(m - 1, 1);
    else return Ack(m - 1, Ack(m, n - 1));
}
