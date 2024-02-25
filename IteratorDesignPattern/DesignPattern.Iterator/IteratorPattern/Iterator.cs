namespace DesignPattern.Iterator.IteratorPattern
{
    public interface Iterator<T>
    {
        T CurrentItem { get; } //aktif öge nedir
        bool NextLocation(); // başka bir öge var mı
    }
}
