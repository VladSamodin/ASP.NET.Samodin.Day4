
namespace Task1.RefactoringJaggedArray
{
    public class JaggedArray
    {
        public static void Sort(int[][] array, IArraysComparer<int> comparer)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer.CompareArrays(array[j], array[indexMin]) < 0)
                    {
                        indexMin = j;
                    }
                }
                Swap<int[]>(ref array[i], ref array[indexMin]);
            }
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T buffer = a;
            a = b;
            b = buffer;
        }
    }
}
