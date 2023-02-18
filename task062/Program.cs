// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Write("Введите число (оно же размер будующего массива): ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, n];
int num = 1;

Console.WriteLine();
PrintArr(PrintArr2(arr, num));



int[,] PrintArr2(int[,] arry, int num)    // метод закручивания спирали квадратного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            while (num <= arr.GetLength(0) * arr.GetLength(1))
            {
                arr[i, j] = num;
                num++;
                if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= arr.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > arr.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }
        }
    }
    return arry;
}

void PrintArr(int[,] arry)  // метод вывода на печать массива
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            if (arry[i, j] / 10 <= 0)
                Console.Write($"0{arry[i, j]} ");    // добавление нолика
            else Console.Write($"{arry[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




/*=========================================
Результат:
===========================================

Введите число (оно же размер будующего массива): 5

01 02 03 04 05 
16 17 18 19 06 
15 24 25 20 07 
14 23 22 21 08 
13 12 11 10 09 

===========================================*/