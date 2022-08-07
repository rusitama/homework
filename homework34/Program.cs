int[] myArray(){
    int[] myArray = new int[4];
    System.Random random = new System.Random();
    for(int i = 1; i < 5; i++){
        myArray[i - 1] = random.Next(100, 999);
    }
    return myArray;
}

int[] myNumbers = myArray();
int i = myNumbers.Length;
int index = 0, countNum = 0;
while (i > 0){
    if ((myNumbers[index] % 2) == 0){
        countNum++;
    }
    i--;
    index++;
}
var strArray = string.Join(", ", myNumbers);
Console.WriteLine("[{0}] -> " + countNum, strArray);