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

void FillArray(int[,] matr){
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           matr[i, j] = new Random().Next(1, 10); 
        }
    }
}

void GetAvarage(int[,] matr){
    string mass = "Среднее арифметическое каждого столбца: ";
    for (int i = 0; i < matr.GetLength(0); i++){
        double sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++){
            sum = sum + Convert.ToDouble(matr[i, j]);
        }
        mass = mass + (sum / matr.GetLength(1)) + "; ";            
    }
    Console.WriteLine(mass);
}


int[,] matrix = new int[3, 4]; //объявляем массив

FillArray(matrix);
PrintMatrix(matrix);
GetAvarage(matrix);