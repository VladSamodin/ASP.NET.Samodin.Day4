
namespace Task1.RefactoringJaggedArray
{
    public interface IArraysComparer<T>
    {
        int CompareArrays(T[] a, T[] b);
    }
}
