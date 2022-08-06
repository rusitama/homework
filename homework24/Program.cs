int Number(string number){
    number = number.Replace(" ", string.Empty);
    int A = 0, B = 0, C = 0;
    int count = number.Length;
    int index = 0;
    string str = "";
    while (count > 0){
        if (number[index].ToString() == ","){
            A = Convert.ToInt32(str);
            str = "";
        }
        else{
            str = str + number[index].ToString();
        }
        count--;
        index++;
        if (count == 0){
            B = Convert.ToInt32(str);
        }
    }
    while (B > 0){
        if (C == 0){
            C = A * A;
        }
        else{
            C = C * A;
        }
        
        B--; 
    }
    return C;
}
Console.WriteLine("Введите два числа (А и В) для возведения в А степень В");
string number = Console.ReadLine();
Console.WriteLine(Number(number));
