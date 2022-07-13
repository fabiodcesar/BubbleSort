namespace BubbleSort.App
{
    public static class BubbleSortExtension
    {
        public static int[] BubbleSort(this int[] elements)
        {
            var arr = elements;
            var length = arr.Length;
            for (var i = 0; i < length - 1; i++)
            {
                for (var j = 0; j < length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
    }
}