// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.WriteLine("Введите m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите n: ");
int n = int.Parse(Console.ReadLine() ?? "0");

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
}

void PrintArray(int[,] matr)
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

int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);