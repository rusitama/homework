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

void GetMinSumArray(int[,] matr){
    int min = 0, field = 0;
    for (int i = 0; i < matr.GetLength(0); i++){
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++){
            sum = sum + matr[i, j];
        }
        if (min == 0){
            min = sum;
            field = i + 1;
        } 
        else{
            if (min > sum){
                min = sum;
                field = i + 1;
            } 
        }           
    }    
    Console.WriteLine("Номер строки с наименьшей суммой элементов: " + field + ", сумма равна " + min);
}
int[,] matrix = new int[3, 4]; //объявляем массив
FillArray(matrix);
PrintMatrix(matrix);
GetMinSumArray(matrix);