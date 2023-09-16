/*Задайте двумерный массив, напишите программу, которая поменяет
 местами первую и последнюю строку массива*/


// int InpupNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// for (int j = 0; j < array.GetLength(1); j++)
// array[i, j] = i + j;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();

//     }
// }


// void ChangeArrray(int[,] array)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int s = array[0, j];
//         array[0, j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = s;
//         {

//         }
//     }
// }

// int rows = InpupNum("Введите количество строк: ");
// int columns = InpupNum("Введите колтчество столбцов: ");
// int[,] myArray = Create2DArray(rows, columns);

// Fill2DArray(myArray);
// PrintArray(myArray);
// ChangeArrray(myArray);
// Console.WriteLine();
// PrintArray(myArray);

// Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно,
//  программа должна вывести сообщение для пользователя.
//ПРОВЕРИТЬ КОД
// int InpupNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// for (int j = 0; j < array.GetLength(1); j++)
// array[i, j] = i + j;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();

//     }
// }


// int ReverseArrray(int[,] array)
// {
// int rowsCount = array.GetLength(0);
// int colsCount = array.GetLength(1);

// int[,] result = new int[rowsCount, colsCount];
// for (int j = 0; j < rowsCount; j++)
// {
//     for (int i = 0; i < colsCount; i++)
//     {
//         result[i, j] = array[i, j];
//     }
// }
// return result;
// }

// int rows = InpupNum("Введите количество строк: ");
// int columns = InpupNum("Введите колтчество столбцов: ");
// int[,] myArray = Create2DArray(rows, columns);

// bool IsValidDataMatrix(int rowsCount, int colsCount)
// {
// return rowsCount == colsCount;
// }

// int rows = InputNum("Введите количество строк: ");
// int columns = InputNum("Введите количество столбцов: ");

// if (IsValidDataMatrix(rows, columns))
// {
// int[,] myArray = Create2DArray(rows, columns);

// Fill2DArray(myArray);
// Print2DArray(myArray);
// int[,] array = ReverseArray(myArray);
// Console.WriteLine();
// Print2DArray(array);
// }
// else
// {
// Console.Write("Не возможно развернуть матрицу");
// }

// Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.
//  Набор данных
// Частотный массив
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза


// int InpupNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = 2 * i + j;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();

//     }
// }


// int[] CopyArray(int[,] array)
// {
//     int[] copyArray = new int[array.Length];
//     int index = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             copyArray[index] = array[i, j];
//             index++;
//         }
//     }
//     return copyArray;
// }


// void SortArray(int[] copyArray)
// {
//     for (int i = 0; i < copyArray.GetLength(0); i++)
//     {
//         for (int j = i + 1; j < copyArray.GetLength(0); j++)
//         {
//             if (copyArray[i] > copyArray[j])
//             {
//                 int temp = copyArray[i];
//                 copyArray[i] = copyArray[j];
//                 copyArray[j] = temp;
//             }
//         }
//     }

// }


// void Frequency(int[] array)
// {
//     int count = 1;
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         if (array[i] == array[i + 1])
//         {
//             count++;
//         }
//         else
//         {
//             Console.WriteLine($"Число {array[i]} встречается {count} раз");
//             count = 1;
//         }
//     }
//     Console.WriteLine($"Число {array[array.Length - 1]} встречается {count} раз");

// }

// int rows = InpupNum("Введите количество строк: ");
// int columns = InpupNum("Введите количество столбцов: ");

// int [,] myArray = Create2DArray(rows, columns);


// Fill2DArray(myArray);
// PrintArray(myArray);
// int[] sortArray = CopyArray(myArray);
// SortArray(sortArray);
// Frequency(sortArray);


// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// int InpupNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// int[,] Create2DArray(int rows, int columns)
// {
//     return new int[rows, columns];
// }

// void Fill2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = 2 * i + j;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();

//     }
// }

// int[] Minimal(int[,] array)
// {
//     int[] indexes = new int[2];
//     int min = array[0, 0];
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 indexes[0] = i;
//                 indexes[1] = j;
//             }

//         }
//     return indexes;
// }

// int[,] DeleteRowCol(int[,] array, int[] index)
// {
//     int[,] res = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
//     int row = 0;
//     int col = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (i == index[0])
//         {
//             continue;
//         }
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (j == index[1])
//             {
//                 continue;
//             }
//             res [row, col] = array[i, j];
//             col++;
//         }
//         row++;
//         col = 0;
//     }
//     return res;
// }


// int rows = InpupNum("Введите количество строк: ");
// int columns = InpupNum("Введите колтчество столбцов: ");

// int[,] myArray = Create2DArray(rows, columns);

// Fill2DArray(myArray);
// PrintArray(myArray);
// int[] minimal = Minimal(myArray);
// Console.WriteLine();
// int[,] myyArray = DeleteRowCol(myArray, minimal);
// PrintArray(myyArray);



// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

using System;

public class Answer {

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



    static public void Main(string[] args) {
        
 // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

    //  int[,] myArray = Create2DArray(4, 5);
    //  Fill2DArray(myArray);
    //  PrintArray(myArray);
    //  Console.WriteLine();
    //  Sort2DArrayToDecreese(myArray);
    //  PrintArray(myArray);
       


 //  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    //  int[,] myArray = Create2DArray(5, 4);
    //  Fill2DArray(myArray);
    //  PrintArray(myArray);
    //  Console.WriteLine();
    //  FindRawWithMinimalSumOfElements(myArray);





    }
}

