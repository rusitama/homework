string Number(string number){
    string otvet = "";
    int num = Convert.ToInt32(number);
    if (num == 6 | num == 7){
        otvet = "да";
    }
    else{
       otvet = "нет";
    }
    return otvet;
}

Console.WriteLine("Введите день недели: ");
string number = Console.ReadLine();
 Console.WriteLine(Number(number));