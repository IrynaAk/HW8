// Задача 62. Заполните спирально массив 4 на 4
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

// Я ПОНИМАЮ, ЧТО РЕШЕНИЕ ТОПОРНОЕ, НО КАК СМОГЛА))

using System;
using static System.Console;

Clear();

int[,] myArray = GetSpire(4);
PrintArray(myArray);

int[,] GetSpire(int n)
{
    int[,] result = new int[n, n];
    result[0,0] = 1;
        for (int j = 1; j < n; j++) //row 0
        {
            result[0,j] = result[0,j-1]+1;
        }
        for (int i = 1; i < n; i++) // column n-1
        {
            result[i,3] = result[i-1,3]+1;
        }
        for (int j = n-2; j >= 0; j--) // the last row (row 3)
        {
            result[3,j] = result[3,j+1]+1;
        }
        for (int i = n-2; i > 0; i--)
        {
            result[i,0] = result[i+1,0]+1; //the first column
        }
        for (int j = 1; j < n-1; j++)
        {
            result[1,j] = result[1,j-1]+1;
        }

    result[2,2] = result[1,2]+1;
    result[2,1] = result[2,2] +1;

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
