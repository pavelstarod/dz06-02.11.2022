// Показать двумерный массив размером m×n заполненный вещественными числами


Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

void FillArray(double[,] mart)
{
    for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j < mart.GetLength(1); j++)
        {
            mart[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] matrix = new double[m, n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);