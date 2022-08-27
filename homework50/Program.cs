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

void GetNumber(int[,] matr, int number){
    for (int i = 0; i < matr.GetLength(0); i++){
        for (int j = 0; j < matr.GetLength(1); j++){
            if (number == matr[i, j]){
                //Console.WriteLine($"-{matr[i, j]}-");
                Console.WriteLine("Такой элемент существует и его индекс " + i + "," + j);
            }            
        }
    }
}

int[,] matrix = new int[3, 4]; //объявляем массив

Console.WriteLine("Задан массив");
FillArray(matrix);
PrintMatrix(matrix);
Console.WriteLine("Введите число для определения существования такого числа в массиве");
int n = Convert.ToInt32(Console.ReadLine());
GetNumber(matrix, n);