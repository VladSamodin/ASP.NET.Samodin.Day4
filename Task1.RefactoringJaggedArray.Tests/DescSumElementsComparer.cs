using System.Linq;

namespace Task1.RefactoringJaggedArray.Tests
{
    class DescSumElementsComparer : IArraysComparer<int>
    {
        public int CompareArrays(int[] a, int[] b)
        {
            return b.Sum() - a.Sum();
        }
    }
}
