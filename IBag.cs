namespace csharp_oop_shop;

public interface IBag
{
    public void Fill(Fruit fruit, int quantity);
    public void AddFruit(Fruit fruit);
    public void RemoveFruit(Fruit fruit);
}