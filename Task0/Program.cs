// ** Задача 54.** Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Исходный массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

using System;
using static System.Console;
using MyLib;

Clear();

int[,] myArray =  GetRandomArray(5,7);
PrintArray(myArray);
WriteLine();
SortArray(myArray);
PrintArray(myArray);

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
    int max = j;
    for (int l = j+1; l < array.GetLength(1); l++)
    {
        if (array[i,l]> array[i,max]) {max =l;} 
    }
    int temporary = array[i,j];
    array[i,j] = array[i,max];
    array[i,max] = temporary;
    }
    }
}

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
