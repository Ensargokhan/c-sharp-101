//sort 

/*int[] numArray = {23,12,4,86,72,3,11,17};
foreach (var num in numArray)
{
    Console.WriteLine(num);
}
Console.WriteLine("*********************Sıralanmış arrray*********************");
Array.Sort(numArray);
foreach (var num in numArray)
{
    Console.WriteLine(num); 
}
*/

// Clear
/*
int[] numArray = {23,12,4,86,72,3,11,17};
Array.Clear(numArray, 2,2); // sayı dizsinde 2. indexten başlayarak 2 tane indexi temizler.
foreach (var num in numArray)
{
    Console.WriteLine(num);
}
*/

// Reverse
/*
int[] numArray = {23,12,4,86,72,3,11,17};
Array.Reverse(numArray);
foreach (var num in numArray)
{
    Console.WriteLine(num);
}
*/

// indexOf
/*
int[] numArray = {23,12,4,86,72,3,11,17};
Console.WriteLine(Array.IndexOf(numArray,11)); // verilen sayının index numarasını döndürür.
*/

// Resize

int[] numArray = {23,12,4,86,72,3,11,17};
Array.Resize<int>(ref numArray,9);
numArray[8] = 99;
foreach (var num in numArray)
{
    Console.WriteLine(num);
}