using System.Linq;

namespace Task1.RefactoringJaggedArray.Tests
{
    class AscSumElementsComparer : IArraysComparer<int>
    {
        public int CompareArrays(int[] a, int[] b)
        {
            return a.Sum() - b.Sum();
        }
    }
}
