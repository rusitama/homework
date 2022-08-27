void PrintNumber(int n, int m){
    string result = string.Empty;
    for (int i = n; i <= m; i++){
        if (i == m)
        result += $"{i}";
        else
        result += $"{i}, ";
    }    
    Console.WriteLine(result);
}

Console.WriteLine("Введите два натуральных числа для вывода всех чисел в промежутке");
Console.WriteLine("Первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
PrintNumber(n, m);
