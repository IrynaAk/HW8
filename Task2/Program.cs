// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Массив A:
// 6 0 2
// 0 4 8
// 0 7 9

// Массив В:
// 0 0 3
// 5 0 4
// 8 2 0

// Результат
// 16 4 18
// 84 16 16
// 107 18 28

using System;
using static System.Console;
using MyLib;

Clear();

int[,] myArray =  GetRandomArray(3,3, 0, 3);
int[,] anotherArray =  GetRandomArray(3,3, 0, 4);
PrintArray(myArray);
WriteLine();
PrintArray(anotherArray);
WriteLine();
int[,] matrixResult = MatrixMult(myArray, anotherArray);
PrintArray(matrixResult);


int[,] MatrixMult(int[,] firstArr, int[,] secondArr)
{
    int row = Math.Min(firstArr.GetLength(0),secondArr.GetLength(0));
    int column = Math.Min(firstArr.GetLength(1),secondArr.GetLength(1));
    int[,] result = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int l = 0; l < column; l++)
            {
            result[i,j] += firstArr[i,j]*secondArr[l,j];
            }
            
        }
    }

    return result;
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

   int[,] GetRandomArray(int rows, int columns, int min, int max)
    {
        int[,] result = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                result[i,j] = new Random().Next(min,max+1);
            }
        }
        return result;
    }
