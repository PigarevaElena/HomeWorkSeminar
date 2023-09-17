using System;

public class Answer {
 // Решение задач в методе Main
    static int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

static void Fill2DArray(int[,] array)

{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(0,100);
}
    

    static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();

    }
}

static void Sort2DArrayToDecreese(int[,] array) 
{
 for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k + 1] > array[i, k])
            {
                int temp = array[i, k + 1];
                array[i, k + 1] = array[i, k];
                array[i, k] = temp;
            }
            }
        }
    }
}


static void FindRawWithMinimalSumOfElements(int[,] array) 
{
int rawNumber = 0;
int minSum = 0;
int temp = 0;

 for (int i = 0; i < array.GetLength(1); i++)
    {
     minSum += array[0,i];
    }
    Console.Write("Посчитали сумму нулевой строки");
    Console.WriteLine();
    Console.Write(minSum);
    Console.WriteLine();
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
    {
         temp += array[i,j];
    }
    Console.Write("Посчитали сумму строки");
    Console.Write(i);
    Console.WriteLine();
    Console.Write(temp);
    Console.WriteLine();
    if(temp < minSum)
    {
        minSum = temp;
        rawNumber = i;
    }
    }
    Console.Write("Номер строки с минимальной суммой элементов(начинаем отсчет строк с нуля) равен ");
    Console.Write(rawNumber);
}

static int[,] MultyplayTwoMatrixes(int[,]first, int[,] second)
{
if (first.GetLength(0) != second.GetLength(1))
{
    Console.WriteLine("Не выполнено условие перемножения матриц");
    return new int[0, 0];
}

int[,] resultArray = new int[first.GetLength(0), second.GetLength(1)];

for (int i = 0; i < first.GetLength(0); i++)
{
    for (int j = 0; j < second.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < first.GetLength(1); k++)
        {
            resultArray[i, j] += first[i, k] * second[k, j];
        }
    }
}
return resultArray;
}

static bool CheckNumberIn3DArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) return true;
            }
        }
    }

    return false;
}


static void Fill3DArray(int[,,] array)
{
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (array[i, j, k] == 0)
                {
                    int number = random.Next(0, 1000);

                    if (CheckNumberIn3DArray(array, number) == false)
                    {
                        array[i, j, k] = number;
                    }
                }

            }
        }
    }
}

static void Print3DArrayWithIdex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k]);
                Console.Write("({0},{1},{2})  ", i, j, k);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}




    static public void Main(string[] args) {
        
 // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

     int[,] myArray = Create2DArray(4, 5);
     Fill2DArray(myArray);
     PrintArray(myArray);
     Console.WriteLine();
     Sort2DArrayToDecreese(myArray);
     PrintArray(myArray);
       


 //  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

     int[,] myyArray = Create2DArray(5, 4);
     Fill2DArray(myyArray);
     PrintArray(myyArray);
     Console.WriteLine();
     FindRawWithMinimalSumOfElements(myyArray);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

     int[,] myArrayy = Create2DArray(5, 4);
     Fill2DArray(myArrayy);
     PrintArray(myArrayy);
     Console.WriteLine();

     int[,] myArray1 = Create2DArray(4, 5);
     Fill2DArray(myArray1);
     PrintArray(myArray1);
     Console.WriteLine();

    int[,] multyArr = MultyplayTwoMatrixes(myArrayy, myArray1);
     PrintArray(multyArr);


    //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных
    // чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

  int [,,] my3dArray = new int [2,2,2];
  Fill3DArray(my3dArray); 
  Print3DArrayWithIdex(my3dArray);
    }
}
