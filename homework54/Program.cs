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

void SortMatrix(int[,] matr)
{
    int temp;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        { //сортировка
            for (int h = j + 1; h < matr.GetLength(1); h++)
            {
                if (matr[i, j] > matr[i, h])
                {
                    temp = matr[i, j];
                    matr[i, j] = matr[i, h];
                    matr[i, h] = temp;
                }
            }
        }
    }
}


int[,] matrix = new int[3, 4]; //объявляем массив

FillArray(matrix);
PrintMatrix(matrix);
SortMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);