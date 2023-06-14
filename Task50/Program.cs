// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(100);
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}, ", 3);
        }
        System.Console.WriteLine();
    }

}

void Search(double[,] arr, int num)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num)
            {
                Console.WriteLine($"Введенное число находится на позиции {i}, {j}.");
                count++;
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine($"Такого числа нет.");
    }
}



double[,] arr = new double[4, 4];
Console.WriteLine($"Введите число, позицию которого нужно найти:");
int num = Convert.ToInt32(Console.ReadLine());
FillArray(arr);
PrintArray(arr);
Search(arr, num);