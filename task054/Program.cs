// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Вариант 1:
Random rnd = new Random();
Console.WriteLine("Например, задан массив 4х5:");
int[,] arr = new int[4, 5];
FillArrayRandom(arr);
PrintArr(arr);

Console.WriteLine();
Console.WriteLine("В итоге получается вот такой массив:");
PrintArr(MaxRows(arr));



int[,] MaxRows(int[,] arry)   // cортировка по убыванию
{

    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            for (int k = 0; k < arry.GetLength(1) - 1; k++)
            {
                if (arry[i, k] < arry[i, k + 1])
                {
                    int temp = arry[i, k + 1];
                    arry[i, k + 1] = arry[i, k];
                    arry[i, k] = temp;
                }
            }
        }
    }
    return arry;
}


void FillArrayRandom(int[,] arry)    // создаем рандомный двумерный массив из целых чисел
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            arry[i, j] = rnd.Next(0, 10);
        }
    }
}

void PrintArr(int[,] arry)  // метод вывода на печать массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j],2}");
        }
        Console.WriteLine();
    }
}




// Вариант 2 (через второй массив):
// Random rnd = new Random();
// Console.WriteLine("Например, задан массив:");
// int[,] arr = new int[rnd.Next(2, 10), rnd.Next(4, 10)];
// FillArrayRandom(arr);
// PrintArr(arr);

// Console.WriteLine();
// Console.WriteLine("В итоге получается вот такой массив:");
// PrintArr(Max2Rows(arr));


// int[,] Max2Rows(int[,] newArry)   // cортировка по убыванию
// {
//     int[,] newArr = new int[newArry.GetLength(0), newArry.GetLength(1)];

//     for (int i = 0; i < newArry.GetLength(0); i++)
//     {
//         int temp = 0;

//         for (int j = 0; j < newArry.GetLength(1) - 1; j++)
//         {
//             if (newArry[i, j] < newArry[i, j + 1])
//             {
//                 temp = newArry[i, j + 1];
//                 newArry[i, j + 1] = newArry[i, j];
//                 newArry[i, j] = temp;
//                 j = 0;
//                 j--;
//             }
//         }
//     }
//     return newArry;
// }

// void FillArrayRandom(int[,] arry)    // создаем рандомный двумерный массив из целых чисел
// {
//     for (int i = 0; i < arry.GetLength(0); i++)
//     {
//         for (int j = 0; j < arry.GetLength(1); j++)
//         {
//             arry[i, j] = rnd.Next(0, 10);
//         }
//     }
// }

// void PrintArr(int[,] arry)  // метод вывода на печать массива
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i, j],2}");
//         }
//         Console.WriteLine();
//     }
// }





/*=========================================
Результат (вариант1):
===========================================

Например, задан массив 4х5:
 8 3 1 4 9
 2 4 5 0 5
 5 6 5 5 0
 0 2 3 3 5

В итоге получается вот такой массив:
 9 8 4 3 1
 5 5 4 2 0
 6 5 5 5 0
 5 3 3 2 0

=========================================
Результат (вариант2):
===========================================

Например, задан массив:
 8 9 3 5 9 0 3 3 1
 9 7 6 7 1 8 1 3 5
 4 2 8 4 2 1 1 2 6
 1 2 7 5 3 5 0 6 9

В итоге получается вот такой массив:
 9 9 8 5 3 3 3 1 0
 9 8 7 7 6 5 3 1 1
 8 6 4 4 2 2 2 1 1
 9 7 6 5 5 3 2 1 0

===========================================*/