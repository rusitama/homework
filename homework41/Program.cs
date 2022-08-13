Console.WriteLine("Введите числа через запитую числа для подсчета количество чисел больше нуля");
string number = Console.ReadLine();
number = number.Replace(" ", string.Empty);
Console.WriteLine(Number(number));

int Number(string number)
{
    int count = 0;
    string num = "";
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i].ToString() != ",")
        {
            num = num + number[i].ToString();
        }

        if (number[i].ToString() == ",")
        {
            if (Convert.ToInt32(num) > 0) count++;
            num = "";
        };

    }
    if (Convert.ToInt32(num) > 0) count++;
    return count;
}
