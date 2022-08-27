void PrintMatrix(int[,] matr)
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

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void MultiplierMatrix(int[,] matr1, int[,] matr2){
    for (int i = 0; i < matr1.GetLength(0); i++){
        for (int j = 0; j < matr1.GetLength(1); j++){
            matr1[i, j] = matr1[i, j] * matr2[i, j];
        }           
    }
    PrintMatrix(matr1);
}

int[,] matrix1 = new int[3, 4]; //объявляем первый массив
int[,] matrix2 = new int[3, 4]; //объявляем второй массив

FillArray(matrix1);
FillArray(matrix2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
MultiplierMatrix(matrix1, matrix2);