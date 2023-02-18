// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
//     j0 - j1 | k0 - k1                  1) ([i0, j0] * [i0, k0]) + ([i0, j1] * [i1, k0])
// i0 - 2   4  |  3   4                   2) ([i0, j1] * [i0, k1]) + ([i0, j1] * [i1, k1])
// i1 - 3   2  |  3   3                   3) ([i1, j0] * [i0, k0]) + ([i1, j1] * [i1, k0])
// Результирующая матрица будет:          4) ([i1, j1] * [i0, k1]) + ([i1, j1] * [i1, k1])
// 18 20
// 15 18



// Вариант 1 (по примеру):
Console.WriteLine("Например, даны 2 матрицы:");
int[,] arr1 = { { 2, 4 }, { 3, 2 } };
int[,] arr2 = { { 3, 4 }, { 3, 3 } };
int[,] arr3 = MultiplicationArrs(arr1, arr2);

PrintArr(arr1);
Console.WriteLine("--");
PrintArr(arr2);
Console.WriteLine("Результирующая матрица будет:");
PrintArr(arr3);



int[,] MultiplicationArrs(int[,] arr1, int[,] arr2)    // метод расчета произведения двух матриц
{
    int[,] multiArr = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); ++i)
        for (int j = 0; j < arr2.GetLength(0); ++j)     // ходим по строкам
            for (int k = 0; k < arr2.GetLength(1); ++k)
                multiArr[i, k] += arr1[i, j] * arr2[j, k];
    return multiArr;
}

void PrintArr(int[,] arry)  // метод вывода на печать массива
{
    for (int i = 0; i < arry.GetLength(0); ++i)
    {
        for (int j = 0; j < arry.GetLength(1); ++j)
        {
            Console.Write(arry[i, j] + " ");
        }
        Console.WriteLine();
    }
}



// Вариант 2 (рандомные):
// Random rnd = new Random();
// Console.WriteLine("Например, даны 2 матрицы:");
// int[,] arrA = new int[rnd.Next(2, 5), rnd.Next(4, 6)];
// int[,] arrB = new int[rnd.Next(2, 5), rnd.Next(4, 6)];
// //
// FillArrayRandom(arrA);
// PrintArr(arrA);
// Console.WriteLine("--");
// FillArrayRandom(arrB);
// PrintArr(arrB);
// Console.WriteLine();

// Console.WriteLine("Результирующая матрица будет:");
// int[,] arrC = MultiplicationArrs(arrA, arrB);
// PrintArr(arrC);


// int[,] MultiplicationArrs(int[,] arr1, int[,] arr2)    // метод расчета произведения двух матриц
// {
//     int[,] multiArr = new int[arr1.GetLength(0), arr2.GetLength(1)];

//     for (int i = 0; i < arr1.GetLength(0); ++i)
//         for (int j = 0; j < arr2.GetLength(0); ++j)
//             for (int k = 0; k < arr2.GetLength(1); ++k)
//                 multiArr[i, k] += arr1[i, j] * arr2[j, k];    
//     return multiArr;
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

// void PrintArr(int[,] arry)    // метод вывода на печать массива
// {
//     for (int i = 0; i < arry.GetLength(0); ++i)
//     {
//         for (int j = 0; j < arry.GetLength(1); ++j)
//         {
//             Console.Write($"{arry[i, j],4}");
//         }
//         Console.WriteLine();
//     }
// }


/*=========================================
Результат (вариант1):
===========================================

Например, даны 2 матрицы:
2 4 
3 2 
--
3 4 
3 3 
Результирующая матрица будет:
18 20
15 18 


===========================================
Результат (вариант2):
===========================================

Например, даны 2 матрицы:
   2   7   3   4
   2   1   3   1
   2   8   0   5
   1   2   2   2
--
   0   7   6   3   1
   5   1   6   4   7
   6   3   2   1   8

Результирующая матрица будет:
  53  30  60  37  75
  23  24  24  13  33
  40  22  60  38  58
  22  15  22  13  31

===========================================*/