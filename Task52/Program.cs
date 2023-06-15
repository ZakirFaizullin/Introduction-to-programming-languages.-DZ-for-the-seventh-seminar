// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}, ", 2);
        }
        Console.WriteLine();
    }

}

void Average(int[,] arr)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        avarage = (avarage + arr[i, j]);
    }
    avarage = avarage / arr.GetLength(0);
    Console.Write(avarage + "; ");
}
}

System.Console.WriteLine($"Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
FillArray(arr);
PrintArray(arr);
Average(arr);