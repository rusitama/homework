string Number(string number){
    string a1 = "", a2 = "", a3 = "", a4 = "";
    string otvet = "нет";
    if (number.Length == 5){
        a1 = number[0].ToString();
        a2 = number[1].ToString();
        a3 = number[3].ToString();
        a4 = number[4].ToString();

        if (a1 == a4 & a2 == a3){
            otvet = "да";
        }        
    }
    return otvet;
}

Console.WriteLine("Введите 5ти значное число для проверки на полиндромность числа: ");
string number = Console.ReadLine();
 Console.WriteLine(Number(number));
