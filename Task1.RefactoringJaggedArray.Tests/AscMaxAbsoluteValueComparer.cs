using System.Linq;

namespace Task1.RefactoringJaggedArray.Tests
{
    class AscMaxAbsoluteValueComparer : IArraysComparer<int>
    {
        public int CompareArrays(int[] a, int[] b)
        {
            int maxA = a.Max(x => x < 0 ? -x : x);
            int maxB = b.Max(x => x < 0 ? -x : x);
            return maxA - maxB;
        }
    }
}
