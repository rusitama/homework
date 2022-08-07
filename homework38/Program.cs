int[] myArray(){
    int[] myArray = new int[4];
    System.Random random = new System.Random();
    for(int i = 1; i < 5; i++){
        myArray[i - 1] = random.Next(-100, 100);
    }
    return myArray;
}

int[] myNumbers = myArray();
int max = myNumbers[0], min = myNumbers[1];
for (int i = 0; i < 4; i++){
    if(myNumbers[i] > max){
        max = myNumbers[i];
    }
    if (myNumbers[i] < min){
        min = myNumbers[i];
    }
}

var strArray = string.Join(", ", myNumbers);
Console.WriteLine("[{0}] -> max " + max + " min " + min + " разница " + (max - min), strArray);