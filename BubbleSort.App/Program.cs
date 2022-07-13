using BubbleSort.App;

int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
var sorted = arr.BubbleSort();
Console.WriteLine("Sorted array");
printArray(arr);

static void printArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.WriteLine(item + " ");
    }
}