int[] myArray(){
    int[] myArray = new int[4];
    System.Random random = new System.Random();
    for(int i = 1; i < 5; i++){
        myArray[i - 1] = random.Next(-100, 100);
    }
    return myArray;
}

int[] myNumbers = myArray();
int countNum = myNumbers[1] + myNumbers[3];
var strArray = string.Join(", ", myNumbers);
Console.WriteLine("[{0}] -> " + countNum, strArray);