void PrintNumber(int n, int m){
    int sum = 0;
    for (int i = n; i <= m; i++){
        sum += i;
    }    
    Console.WriteLine(sum);
}

Console.WriteLine("Введите два натуральных числа для вывода суммы всех чисел в промежутке");
Console.WriteLine("Первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
PrintNumber(n, m);