// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты


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
            matr[i, j] = new Random().Next(2, 10);
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

void Kvadrat(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) matr[i, j] = matr[i, j] * matr[i, j];
        }
    }
}

int[,] matrix = new int[m, n];

Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Kvadrat(matrix);
PrintArray(matrix);
