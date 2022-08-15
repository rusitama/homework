Console.WriteLine("Введите следующие числа для нахождения точки пересичения двух прямых линии");
Console.Write("Введите число b1 ");
string b1 = Console.ReadLine();

Console.Write("Введите число b2 ");
string b2 = Console.ReadLine();

Console.Write("Введите число k1 ");
string k1 = Console.ReadLine();

Console.Write("Введите число k2 ");
string k2 = Console.ReadLine();

var strArray = string.Join(", ", Coordinate(b1, b2, k1, k2));
Console.WriteLine("[{0}]", strArray);

double[] Coordinate(string b1, string b2, string k1, string k2)
{
    // уровнение y = k1 * x + b1, y = k2 * x + b2
    double t1 = Convert.ToDouble(b1);
    double t2 = Convert.ToDouble(b2);
    double r1 = Convert.ToDouble(k1);
    double r2 = Convert.ToDouble(k2);
    double[] myArray = new double[2];
    double y = 0, x = 0;
    y = ((r1 * t2) - (r2 * t1)) / (r1 - r2);
    //Console.WriteLine((2.0/3.0));
    x = (y - t1) / r1;
    myArray[0] = x;
    myArray[1] = y;
    return myArray;
}