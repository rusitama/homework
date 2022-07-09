Console.WriteLine("Введите число для вывода всех чётных чисел от 1 до N ");
int number = Convert.ToInt32(Console.ReadLine());

int count = number / 2;

int num = 2;

while (count > 0)
{
    if (num == 2)
    {
        Console.Write(num);
    }
    else
    {
        Console.Write(", " + num);
    }

    num = num + 2;
    count--;
}