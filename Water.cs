using System.Runtime.Remoting;

namespace csharp_oop_shop;

public class Water : Product, IBootle
{
    public float Quantity { get; } 
    public float AvailableWater { get; private set; }
    public float Ph { get; }
    public string? Source { get; }
    
    public Water(string? name,
        string? description,
        decimal price,
        float vat,
        float quantity
    ) : base(name, description, price, vat)
    {
        AvailableWater = quantity;
        Quantity = quantity;
        Ph = 7;
        Source = "unknown";
    }
    
    public Water(
        string? name, 
        string? description, 
        decimal price, 
        float vat,
        float quantity,
        float ph,
        string? source
        ) 
        : this(name, description, price, vat, quantity)
    {
        Ph = ph;
        Source = source;
    }
    
    public override string ToString()
    {
        return $"{base.Code} - {base.Name} - {base.Description} -" +
               $" {base.priceWithVat()}$ {Quantity}L Ph: {Ph} Source: {Source}";
    }

    public void Fill(float quantity)
    {
        if (AvailableWater == Quantity)
        {
            throw new Exception("Water is already full");
        }

        AvailableWater = (AvailableWater + quantity > Quantity) ? Quantity : AvailableWater + quantity;
        
    }

    public void Refill(float quantity)
    {
        AvailableWater = Quantity;
    }

    public void Drink(float quantity)
    {
        if (quantity > AvailableWater)
        {
            throw new Exception("Not enough water");
        }

        AvailableWater -= quantity;
    }

    public void Empty()
    {
        AvailableWater = 0;
    }

    public static float LiterToGallon(float liter)
    {
        return liter * 0.264172f;
    }
}