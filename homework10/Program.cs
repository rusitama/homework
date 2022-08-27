string Number(string number){
    if (number.Length == 3){
        number = number[1].ToString();
    }
    else{
        Console.WriteLine("Вы ввели не 3х значное число! Повторите попытку!");
        number = "";
        getConsole(number);
    }
    return number;
}

void getConsole(string number){
    if (number == ""){
       number = Console.ReadLine(); 
       Console.WriteLine(Number(number));
    }
    else{
        Console.WriteLine(Number(number));
    }
}

Console.WriteLine("Введите 3х значное число: ");
string number = Console.ReadLine();
getConsole(number);