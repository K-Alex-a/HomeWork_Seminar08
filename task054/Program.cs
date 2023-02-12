// Урок 8. Двумерные массивы. Продолжение
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


Random rnd = new Random();
Console.WriteLine("Например, задан массив:");
int[,] arr = new int[rnd.Next(5, 10), rnd.Next(5, 10)];

FillArrayRandom(arr);
PrintArr(arr);
// Console.Write("В итоге получается вот такой массив:: ");







void FillArrayRandom(int[,] arr)    // создаем рандомный двумерный массив из целых чисел
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
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