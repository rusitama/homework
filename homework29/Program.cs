Console.WriteLine("Введите числа через запитую для вывода их в массив");
string str = Console.ReadLine();
var strArray = string.Join(", ", myArray(str));
Console.WriteLine("[{0}]", strArray);

int[] myArray(string str){
    //очистим строку от пробелов
    str = str.Replace(" ", string.Empty);
    //подсчитаем количество запятых для определения длины массива
    int count = str.Length;
    int index = 0; 
    int lenthArray = 1;
    
    while(count > 0){
        if (str[index].ToString() == ","){
            lenthArray++;
        }
        count--;
        index++;
    }    
    // создадим массив для вывода в консоль
    int[] numberOfArray = new int[lenthArray];
    count = str.Length;
    index = 0;
    int indexNum = 0;
    string strNum = "";
    while (count > 0){
        if (str[index].ToString() != ","){
            strNum = strNum + str[index].ToString();            
        }
        else{
            numberOfArray[indexNum] = Convert.ToInt32(strNum);
            
            indexNum++;            
            strNum = "";
        }
        index++;
        count--;
    }
    numberOfArray[indexNum] = Convert.ToInt32(strNum);
    return numberOfArray;
}
