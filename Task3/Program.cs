// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(0,1,0) 53(0,1,1)
// 32(1,0,0) 41(1,0,1)
// 66(1,1,0) 88(1,1,1)

// КАК СФОРМИРОВАТЬ МАССИВ ИЗ НЕПОВТОРЯЮЩИХСЯ ЭЛЕМЕНТОВ?

using System;
using static System.Console;

Clear();

int[,,] myArray = GetTreeDementionalArray(2,2,2);
PrintTreeDementionalArray(myArray);

int[,,] GetTreeDementionalArray(int dementionLen1, int dementionLen2, int dementionLen3)
{
    int[,,] result = new int[dementionLen1,dementionLen2,dementionLen3];
    for (int i = 0; i < dementionLen1; i++)
    {
        for (int j = 0; j < dementionLen2; j++)
        {
            for (int l = 0; l < dementionLen3; l++)
            {
                result[i,j,l] = new Random().Next(10, 100);
            }
        }
    }
    return result;
}

void PrintTreeDementionalArray(int[,,] arrForPrint)
{
    for (int i = 0; i < arrForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrForPrint.GetLength(1); j++)
        {
            for (int l = 0; l < arrForPrint.GetLength(2); l++)
            {
                Write($"{arrForPrint[i,j,l]}({i},{j},{l}) ");
            }
            WriteLine();
        }
    }
}
