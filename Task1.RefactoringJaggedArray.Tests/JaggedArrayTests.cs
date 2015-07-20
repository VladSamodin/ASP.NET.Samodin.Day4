using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1.RefactoringJaggedArray.Tests
{
    [TestClass]
    public class JaggedArrayTests
    {
        [TestMethod]
        public void Sort_ArrayAndAscMaxAbsolutValueComparer_ArraySortedByMaxAbsoluteValueByAsc()
        {
            int[][] array = new int[][]
            { 
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0},
                new int[] {3, -5, 2, 0},
                new int[] {2, 4, 1}
            };

            int[][] expected = new int[][]
            {
                new int[] {0, 0, 0, 0},
                new int[] {0, 1, 1, 0},
                new int[] {-1, 2},
                new int[] {2, 4, 1},
                new int[] {3, -5, 2, 0}
            };

            JaggedArray.Sort(array, new AscMaxAbsoluteValueComparer());
            IStructuralEquatable actual = array;

            Assert.IsTrue(actual.Equals(expected, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void Sort_ArrayAndDescMaxAbsolutValueComparer_ArraySortedByMaxAbsoluteValueByDesc()
        {
            int[][] array = new int[][]
            { 
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0},
                new int[] {3, -5, 2, 0},
                new int[] {2, 4, 1}
            };

            int[][] expected = new int[][]
            {
                new int[] {3, -5, 2, 0},
                new int[] {2, 4, 1},
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0}
            };

            JaggedArray.Sort(array, new DescMaxAbsoluteValueComparer());
            IStructuralEquatable actual = array;

            Assert.IsTrue(actual.Equals(expected, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void Sort_ArrayAndAscSumElementsComparer_ArraySortedByMaxAbsolutValueByAsc()
        {
            int[][] array = new int[][]
            { 
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0},
                new int[] {3, -5, 2, 3},
                new int[] {2, 4, 1}
            };

            int[][] expected = new int[][]
            {
                new int[] {0, 0, 0, 0},
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {3, -5, 2, 3},
                new int[] {2, 4, 1}
            };

            JaggedArray.Sort(array, new AscSumElementsComparer());
            IStructuralEquatable actual = array;

            Assert.IsTrue(actual.Equals(expected, StructuralComparisons.StructuralEqualityComparer));
        }

        [TestMethod]
        public void Sort_ArrayAndDescSumElementsComparer_ArraySortedByMaxAbsolutValueByDesc()
        {
            int[][] array = new int[][]
            { 
                new int[] {-1, 2},
                new int[] {0, 1, 1, 0},
                new int[] {0, 0, 0, 0},
                new int[] {3, -5, 2, 3},
                new int[] {2, 4, 1}
            };

            int[][] expected = new int[][]
            {
                new int[] {2, 4, 1},
                new int[] {3, -5, 2, 3},
                new int[] {0, 1, 1, 0},
                new int[] {-1, 2},
                new int[] {0, 0, 0, 0}                
            };

            JaggedArray.Sort(array, new DescSumElementsComparer());
            IStructuralEquatable actual = array;

            Assert.IsTrue(actual.Equals(expected, StructuralComparisons.StructuralEqualityComparer));
        }
    }
}
