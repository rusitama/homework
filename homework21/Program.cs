// формула нахождения между точками в пространстве AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
double Number(string number1, string number2)
{
    double koordinate = 0;
    int xa = 0, xb = 0, ya = 0, yb = 0, za = 0, zb = 0;
    int[] x = new int[3];
    int[] y = new int[3];
    x = myArray(xa, ya, za, number1);
    y = myArray(xb, yb, zb, number2);
    koordinate = Math.Sqrt(Math.Pow((y[0] - x[0]), 2) + Math.Pow((y[1] - x[1]), 2) + Math.Pow((y[2] - x[2]), 2));
    return koordinate;
}

int[] myArray(int x, int y, int z, string number){ 
    int[] array = new int[3];  // объявляем массив на три элемента    
    int count = number.Length;
    int index = 0, countCoord = 1;
    string str = "";
    bool newnum = false;
    while (count > 0)
    {
        if (number[index].ToString() == "," | number[index].ToString() == " ") newnum = true;
        else str = str + number[index].ToString();
        if (newnum == true)
        {
            if (countCoord == 1) 
            {
                x = Convert.ToInt32(str); 
                countCoord++;
            }
            else if (countCoord == 2) 
            {
                y = Convert.ToInt32(str);
                countCoord++;
            }
            str = "";
            newnum = false;
        }
        index++;
        count--;
    }
    z = Convert.ToInt32(str);
    array[0] = x;
    array[1] = y;
    array[2] = z;
    return array; 
}


Console.WriteLine("Введите через запитую координаты точки А (например: 12,52,56): ");
string number1 = Console.ReadLine();
Console.WriteLine("Введите через запитую координаты точки B (например: 12,52,56): ");
string number2 = Console.ReadLine();
Console.WriteLine(Number(number1, number2));