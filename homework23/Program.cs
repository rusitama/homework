void getConsole(string number)
{
    int count = Convert.ToInt32(number);

    int num = 1;

    while (count > 0)
    {
        if (num == 1)
        {
            Console.Write(num * num * num);
        }
        else
        {
            Console.Write(", " + num * num * num);
        }

        num = num + 1;
        count--;
    }
}

Console.WriteLine("Введите число для вывода которая выдаёт таблицу кубов чисел от 1 до N ");
string number = Console.ReadLine();
getConsole(number);




