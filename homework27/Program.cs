Console.WriteLine("Введите число для вывода сумму чисел");
string number = Console.ReadLine();
Console.WriteLine(Number(number));

int Number(string number){
    int count = number.Length;
    int sum = 0, index = 0;
    while (count > 0){
        sum = sum + Convert.ToInt32(number[index].ToString());
        count--;
        index++;
    }
    return sum;
}
