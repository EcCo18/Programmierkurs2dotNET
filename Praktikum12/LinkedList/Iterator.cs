namespace Praktikum12
{
    public interface Iterator<Element>
    {
        Element next();
        bool hasNext();
    }
}