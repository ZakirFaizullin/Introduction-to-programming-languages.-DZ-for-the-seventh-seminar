// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble() * 100;
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}, ",30);
        }
        System.Console.WriteLine();
    }

}



System.Console.WriteLine($"Введите количество строк:");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите количество столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m, n];
FillArray(arr);
PrintArray(arr);