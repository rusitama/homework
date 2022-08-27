void PrintMatrix(double[,] matr)
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

void FillArray(double[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           matr[i, j] = Math.Round((new Random().NextDouble()) * (new Random().Next(-10, 10)), 2); 
        }
    }
}

Console.WriteLine("Введите чила для вывода двумерного массива");
Console.WriteLine("Введите длину колонок");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n]; //объявляем массив

PrintMatrix(matrix);
FillArray(matrix);
Console.WriteLine();
PrintMatrix(matrix);