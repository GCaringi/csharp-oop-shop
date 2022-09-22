namespace csharp_oop_shop;

public class FruitBag : Product , IBag
{
    public List<Fruit> Fruits { get; }

    public FruitBag(
        string name, 
        string description, 
        decimal price, 
        float vat) : base(name, description, price, vat)
    {
        Fruits = new List<Fruit>();
    }
    public void Fill(Fruit fruit, int quantity)
    {
        for (int i = 0; i < quantity; i++)
        {
            Fruits.Add(fruit);
        }
    }
    
    public void AddFruit(Fruit fruit)
    {
        Fruits.Add(fruit);
    }
    
    public void RemoveFruit(Fruit fruit)
    {
        if (!Fruits.Contains(fruit))
        {
            throw new Exception("Fruit not found");
        }
        
        Fruits.Remove(fruit);
    }
}