Console.WriteLine("Введите число для проверки является ли она четным ");
int number = Convert.ToInt32(Console.ReadLine());

int num = number % 2;

if (num == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}