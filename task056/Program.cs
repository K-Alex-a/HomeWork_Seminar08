// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка


Random rnd = new Random();
Console.WriteLine("Например, задан массив:");
int[,] arr = new int[4, 5];
FillArrayRandom(arr);
PrintArr(arr);
Console.Write($"Строка с наименьшей суммой элементов: {MinSumRows(arr)} строка");


int MinSumRows(int[,] arry)    // вычисление суммы каждой строки и минимального ее значения
{
    int minSum = int.MaxValue;
    int count = -1;

    for (int i = 0; i < arry.GetLength(0); i++)
    {
        int sum = 0;    // обнуляет сумму после каждой строки

        for (int j = 0; j < arry.GetLength(1); j++)    // суммирует все значения столбцов у одной строки, пока кол-во столбцов не закончится
        {
            sum += arr[i, j];
        }
        Console.WriteLine($"Cумма {i} строки : {sum}");


        if (sum < minSum)   // ищем минималку в сумме
        {
            minSum = sum;
            count++;
        }
    }
    return count;
}

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

