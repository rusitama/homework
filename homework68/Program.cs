int Akk(int m, int n){
     if (m == 0) return (n + 1);
     if (m != 0 && n == 0) return Akk(m - 1, 1);
     return Akk(m - 1, Akk(m, n - 1));
}

Console.WriteLine("Введите число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akk(m, n));
