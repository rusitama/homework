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
    //Console.ReadLine();
    if (number == ""){
       number = Console.ReadLine(); 
       Console.WriteLine(Number(number));
    }
    else{
        Console.WriteLine(Number(number));
    }
}

Console.WriteLine("Vvedite 3x znachnoe chislo ");
string number = Console.ReadLine();
getConsole(number);