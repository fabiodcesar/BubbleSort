using BubbleSort.App;
using Xunit;
using Xunit.Abstractions;

namespace BubbleSort.Test
{
    public class SortingTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public SortingTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Sort_As_Expected()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            string test = "";
            var sorted = arr.BubbleSort();
            _testOutputHelper.WriteLine(test);
            _testOutputHelper.WriteLine("Sorted array");
            PrintArray(sorted);

            int[] expected = { 11, 12, 22, 25, 34, 64, 90 };
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void Sort_Empty()
        {
            int[] arr = new int[] { };
            var sorted = arr.BubbleSort();
            int[] expected = { };
            Assert.Equal(expected, sorted);
        }

        void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                _testOutputHelper.WriteLine(item + " ");
            }
        }
    }
}