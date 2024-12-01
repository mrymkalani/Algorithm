namespace Sortable;
    public interface ISortable<T>
    {
        T[] AscendingSort(T[] values);
    void AscendingSort();
        T[] DescendingSort(T[] values);
    }