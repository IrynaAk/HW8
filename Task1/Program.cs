// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Результат: 1-строка

using System;
using static System.Console;
using MyLib;

Clear();

int[,] myArray = GetRandomArray(5,6);
PrintArray(myArray);
WriteLine();
int[] rowSums = GetRowsSum(myArray);
WriteLine($"{String.Join(", ",rowSums)}");
WriteLine();
WriteLine($"Result: row {MinSum(rowSums)} (numbering of rows starts from 0)"); 




void PrintArray(int[,] arrayForPrint)
    {
        for (int i = 0; i < arrayForPrint.GetLength(0); i++)
        {
            for (int j = 0; j < arrayForPrint.GetLength(1); j++)
            {
                Write($"{arrayForPrint[i,j]} ");
            }
            WriteLine();
        }
    }


int[] GetRowsSum(int[,] initialArray)
{
    int[] result = new int[initialArray.GetLength(0)];
    for (int i = 0; i < initialArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < initialArray.GetLength(1); j++)
        {
            sum += initialArray[i,j];
        }
        result[i] = sum;
    }
    return result;
}

int MinSum (int[] arr)

{
    int minIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < arr[minIndex])  minIndex = i; 
    }
    return minIndex;
}

   int[,] GetRandomArray(int rows, int columns)
    {
        int[,] result = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i,j] = new Random().Next(0,10);
            }
        }
        return result;
    }



