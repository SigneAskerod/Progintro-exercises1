int [] array = [-2, 2, -4, 4, -6, 8, -10, -1 ,0];
int LargestNeg = int.MinValue;

foreach(int element in array){ 
    if (LargestNeg < element && element < 0){
        LargestNeg = element;
    }
}
Console.WriteLine("Largest negative value is " + LargestNeg);
