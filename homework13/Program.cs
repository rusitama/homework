string Number(string number){
    if (number.Length >= 3){
        number = number[2].ToString();
    }
    else{
       number = "третьей цифры нет";
    }
    return number;
}

Console.WriteLine("Введите 3х значное число: ");
string number = Console.ReadLine();
 Console.WriteLine(Number(number));

